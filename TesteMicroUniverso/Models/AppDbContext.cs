using System;
using System.Data.Entity;
using System.Linq;

namespace TesteMicroUniverso.Models
{
    public class AppDbContext : DbContext
    {
      public AppDbContext()
            : base("name=DefaultConnection")
        {
            
        }
        public virtual DbSet<Usuario> Usuarios{ get; set; }
        public virtual DbSet<HistAprovacao> HistAprovacao { get; set; }
        public virtual DbSet<Nota> Nota { get; set; }
        public virtual DbSet<ConfigFaixaPreco> ConfigFaixaPreco { get; set; }
    }
}