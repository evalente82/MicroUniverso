using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteMicroUniverso.Models
{
    public class Nota
    {
        [Key]
        public int IdNota { get; set; }
        public DateTime Emissao { get; set; }
        public decimal? VlMercadorias { get; set; }
        public decimal? Desconto { get; set; }
        public decimal? Frete { get; set; }
        public decimal? Total { get; set; }
        public bool? Status { get; set; }
        public int Visto { get; set; }
        public int Aprovacao { get; set; }
    }
}
