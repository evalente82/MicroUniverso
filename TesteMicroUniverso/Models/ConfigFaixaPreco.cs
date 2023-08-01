using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteMicroUniverso.Models
{
    public class ConfigFaixaPreco
    {
        [Key]
        public int IdFaixa{ get; set; }
        public decimal FaixaMin { get; set; }
        public decimal FaixaMax { get; set; }
        public int Visto { get; set; }
        public int Aprovacao { get; set; }

    }
}
