using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TesteMicroUniverso.DAL;
using TesteMicroUniverso.Models;

namespace TesteMicroUniverso.BLL
{
    public class BLL_HistAprovacao
    {
        DAL_HistAprovacao vDAL_Hist = new DAL_HistAprovacao();

        public Task<List<HistAprovacao>> ListarHistorico()
        {
            return vDAL_Hist.BuscarHist();
        }

        public bool VerificaNotaAprovUsuario(int idUsuario, int idNota)
        {

            return vDAL_Hist.VerificaUsu(idUsuario, idNota);
        }
    }
}
