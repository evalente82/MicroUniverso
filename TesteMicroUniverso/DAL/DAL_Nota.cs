using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows.Forms;
using TesteMicroUniverso.BLL;
using TesteMicroUniverso.Models;

namespace TesteMicroUniverso.DAL
{
    public class DAL_Nota
    {
        public async Task<List<Nota>> BuscarNotas()
        {
            var dbContext = new AppDbContext();
            var results = await dbContext.Nota.ToListAsync();
            return results;
        }

        public async Task ValidarAprovarNota(List<int> listId)
        {
            var dbContext = new AppDbContext();
            string papel = string.Empty;
            decimal? ValorMin = null;
            decimal? ValorMax = null;

            List<int> notasJaVerificadas = new List<int>();
            HistAprovacao historico = new HistAprovacao();
            var notas = dbContext.Nota.Where(n => listId.Contains(n.IdNota)).ToList();

            foreach (var nota in notas)
            {
                if (Program.UsuarioLogadoInstance.Usuario != null)
                {
                    papel = Program.UsuarioLogadoInstance.Usuario.Papel;
                    ValorMin = Program.UsuarioLogadoInstance.Usuario.ValorMinAprovacao;
                    ValorMax = Program.UsuarioLogadoInstance.Usuario.ValorMaxAprovacao;
                }
                BLL_Nota bLL_Nota = new BLL_Nota();
                //*primeiro verifico se esta dentro dos valores
                if (nota.Total >= ValorMin && nota.Total <= ValorMax)
                {
                    //verifico se já foi aprovado ou visto pelo mesmo usuario
                    BLL_HistAprovacao bLL_HistAprovacao = new BLL_HistAprovacao();
                    bool verificaUsu = bLL_HistAprovacao.VerificaNotaAprovUsuario(Program.UsuarioLogadoInstance.Usuario.IdUsuario, nota.IdNota);
                    if (!verificaUsu)
                    {
                        Nota minhNota = new Nota();
                        minhNota = dbContext.Nota.FirstOrDefault(n => n.IdNota == nota.IdNota);
                        int vistoBd = minhNota.Visto;
                        int aprovacaoBd = minhNota.Aprovacao;
                        //verifico o tipo do papel do usuario
                        if (papel == "VISTO")
                        {
                            //verificar a qtd de vistos
                            nota.Visto = vistoBd + 1;

                            dbContext.SaveChanges();

                            //inseriro na historico
                            historico.IdNota = nota.IdNota;
                            historico.IdUsuario = Program.UsuarioLogadoInstance.Usuario.IdUsuario;
                            historico.Operacao = papel;
                            historico.DtData = DateTime.Now;
                            dbContext.HistAprovacao.Add(historico);
                            dbContext.SaveChanges();
                        }
                        else if (papel == "APROVACAO")
                        {
                            //verificar se pode aprovar devido a qtd de vistos obrigatória
                            if (bLL_Nota.VerificaVisto(nota.IdNota) == 1)
                            {
                                nota.Aprovacao = aprovacaoBd + 1;
                                dbContext.SaveChanges();

                                //inseriro na historico
                                historico.IdNota = nota.IdNota;
                                historico.IdUsuario = Program.UsuarioLogadoInstance.Usuario.IdUsuario;
                                historico.Operacao = papel;
                                historico.DtData = DateTime.Now;
                                dbContext.HistAprovacao.Add(historico);
                                dbContext.SaveChanges();
                            }
                            else
                            {
                                MessageBox.Show($"A Nota Não tem a quantidade exigida para aprovação.", "Faltando Vistos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                    else
                    {
                        notasJaVerificadas.Add(nota.IdNota);
                    }
                }
                else
                {
                    MessageBox.Show($"O Valor da Nota está fora dos parametros do Funcionário.", "Fora da Configuração", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                if (bLL_Nota.AprovacaoDeCompra(nota.IdNota) == 1)
                {
                    Nota minhNota = new Nota();
                    minhNota = dbContext.Nota.FirstOrDefault(n => n.IdNota == nota.IdNota);                    
                    minhNota.Status = true;
                    //dbContext.Nota.Add(minhNota);
                    dbContext.SaveChanges();
                    MessageBox.Show($"Nota está Aprovada !", "Nota Aprovada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            if (notasJaVerificadas.Count > 0)
            {
                string idsVerificados = string.Join(", ", notasJaVerificadas);
                MessageBox.Show($"O usuário já validou as notas de IDs: {idsVerificados}", "Notas Já Validadas", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            await Task.CompletedTask;
        }

        public int ValidaVisto(int IdNota)
        {
            List<ConfigFaixaPreco> configFaixaPreco = new List<ConfigFaixaPreco>();

            Nota nota = new Nota();
            var dbContext = new AppDbContext();
            nota = (Nota)dbContext.Nota.FirstOrDefault(n => n.IdNota == IdNota);
            
            configFaixaPreco = dbContext.ConfigFaixaPreco.ToList();
            int config = 0;

            foreach (var item in configFaixaPreco)
            {
                if (nota.Total >= item.FaixaMin && nota.Total <= item.FaixaMax)
                {
                    if (nota.Visto == item.Visto)
                    {
                        config = 1;
                        return config;
                    }
                }
            }
            return config;

        }

        public int CompraAprovada(int idNota)
        {
            List<ConfigFaixaPreco> configFaixaPreco = new List<ConfigFaixaPreco>();
            Nota nota = new Nota();
            var dbContext = new AppDbContext();
            nota = (Nota)dbContext.Nota.FirstOrDefault(n => n.IdNota == idNota);
            configFaixaPreco = dbContext.ConfigFaixaPreco.ToList();

            int aprovada = 0;
            foreach (var item in configFaixaPreco)
            {
                if (nota.Total >= item.FaixaMin && nota.Total <= item.FaixaMax)
                {
                    if (nota.Visto == item.Visto && nota.Aprovacao == item.Aprovacao)
                    {
                        aprovada = 1;
                        return aprovada;
                    }
                }
            }
            return aprovada;
        }

        public List<Nota> NotasDentroLimiteUsu(DateTime dataInicio, DateTime dataFim)
        {
            var dbContext = new AppDbContext();
            decimal vlMinimo = Program.UsuarioLogadoInstance.Usuario.ValorMinAprovacao;
            decimal vlMaximo = Program.UsuarioLogadoInstance.Usuario.ValorMaxAprovacao;

            var results = dbContext.Nota.Where(x => x.Total >= vlMinimo && x.Total <= vlMaximo
            &&
                    x.Emissao >= dataInicio && x.Emissao<= dataFim).ToList();
            return results;
        }

        public IEnumerable<Nota> NotasPorPapel(DateTime dataInicio, DateTime dataFim)
        {
            var dbContext = new AppDbContext();
            string papel = Program.UsuarioLogadoInstance.Usuario.Papel;
            decimal? ValorMin = null;
            decimal? ValorMax = null;

            List<ConfigFaixaPreco> configFaixaPreco = new List<ConfigFaixaPreco>();
            configFaixaPreco = dbContext.ConfigFaixaPreco.ToList();

            List<Nota> notas = new List<Nota>();
            notas = dbContext.Nota.ToList();
            List<Nota> listaFinal = new List<Nota>();

            ValorMin = Program.UsuarioLogadoInstance.Usuario.ValorMinAprovacao;
            ValorMax = Program.UsuarioLogadoInstance.Usuario.ValorMaxAprovacao;
            foreach (var item in notas)
            {
                if (item.Emissao >= dataInicio && item.Emissao <= dataFim)
                {
                    if (papel == "VISTO")
                    {
                        if (!configFaixaPreco.Any(faixa => faixa.Visto == item.Visto))
                        {
                            if (item.Total >= ValorMin && item.Total <= ValorMax)
                            {
                                listaFinal.Add(item);
                            }
                        }
                    }
                    else if (papel == "APROVACAO")
                    {
                        if (!configFaixaPreco.Any(faixa => faixa.Aprovacao == item.Aprovacao))
                        {
                            if (item.Total >= ValorMin && item.Total <= ValorMax)
                            {
                                listaFinal.Add(item);
                            }
                        }
                    }
                }                
            }
            
            return listaFinal;

        }

        public List<Nota> NotasSemVistoAprov(DateTime dataInicio, DateTime dataFim)
        {
            var notas = NotasDentroLimiteUsu(dataInicio, dataFim);
            List<Nota> listaFinal = new List<Nota>();

            foreach (var nota in notas)
            {
                if (nota.Emissao >= dataInicio && nota.Emissao <= dataFim)
                {
                    BLL_HistAprovacao bLL_HistAprovacao = new BLL_HistAprovacao();
                    bool verificaUsu = bLL_HistAprovacao.VerificaNotaAprovUsuario(Program.UsuarioLogadoInstance.Usuario.IdUsuario, nota.IdNota);
                    if (!verificaUsu)
                    {
                        listaFinal.Add(nota);
                    }
                }                
            }            
            return listaFinal;
        }
    }
}
