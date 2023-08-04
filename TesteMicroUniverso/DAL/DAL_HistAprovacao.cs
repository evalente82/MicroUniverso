using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TesteMicroUniverso.Models;

namespace TesteMicroUniverso.DAL
{
    public class DAL_HistAprovacao
    {
        public async Task<List<HistAprovacao>> BuscarHist()
        {
            var dbContext = new AppDbContext();
            var results = await dbContext.HistAprovacao.ToListAsync();
            return results;
        }

        public bool VerificaUsu(int idUsuario ,int idNota)
        {
            var dbContext = new AppDbContext();

            var usuario = dbContext.HistAprovacao.FirstOrDefault(h => h.IdUsuario == idUsuario && h.IdNota == idNota);

            if (usuario != null)
            {
                return true;
            }
            return false;
        }
    }
}
