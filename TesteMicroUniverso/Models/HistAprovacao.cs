using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteMicroUniverso.Models
{
    public class HistAprovacao
    {
        [Key]
        public int IdHistAprovacao { get; set; }
        public int IdUsuario{ get; set; }
        public string Operacao { get; set; }
        public int IdNota{ get; set; }
        public DateTime DtData { get; set; }
    }
}
