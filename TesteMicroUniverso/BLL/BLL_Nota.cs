using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TesteMicroUniverso.DAL;
using TesteMicroUniverso.Models;

namespace TesteMicroUniverso.BLL
{
    public class BLL_Nota
    {
        DAL_Nota vDAL_Nota = new DAL_Nota();

        public Task<List<Nota>> ListarNotas()
        {
            return vDAL_Nota.BuscarNotas();
        }

        public Task VistoAprovacao(List<int> listId)
        {
            return vDAL_Nota.ValidarAprovarNota(listId);
        }

        public int VerificaVisto(int IdNota)
        {
            return vDAL_Nota.ValidaVisto(IdNota);
        }

        public int AprovacaoDeCompra(int IdNota)
        {
            return vDAL_Nota.CompraAprovada(IdNota);
        }

        public List<Nota> ListarNotasDentroLimiteUsu(DateTime dataInicio, DateTime dataFim)
        {
            return vDAL_Nota.NotasDentroLimiteUsu(dataInicio, dataFim);
        }

        public IEnumerable<Nota> ListarNotasPapel(DateTime dataInicio, DateTime dataFim)
        {
            return vDAL_Nota.NotasPorPapel(dataInicio, dataFim);
        }

        public List<Nota> ListarSemVistoAprov(DateTime dataInicio, DateTime dataFim)
        {
            return vDAL_Nota.NotasSemVistoAprov(dataInicio, dataFim);
        }
    }
}
