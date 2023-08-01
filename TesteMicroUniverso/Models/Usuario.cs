using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteMicroUniverso.Models
{
    public class Usuario
    {
        [Key]
        public int IdUsuario { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }
        public string Papel { get; set; }
        public decimal ValorMinAprovacao { get; set; }
        public decimal ValorMaxAprovacao { get; set; }
    }
}
