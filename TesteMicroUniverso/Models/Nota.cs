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
        public float VlMercadorias { get; set; }
        public float Desconto { get; set; }
        public float Frete{ get; set; }
        public float Total { get; set; }
        public bool Status { get; set; }
        public int Visto { get; set; }
        public int Aprovacao { get; set; }
    }
}
