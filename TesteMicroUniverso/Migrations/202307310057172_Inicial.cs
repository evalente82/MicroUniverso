namespace TesteMicroUniverso.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Inicial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.HistAprovacaos",
                c => new
                    {
                        IdHistAprovacao = c.Int(nullable: false, identity: true),
                        IdUsuario = c.Int(nullable: false),
                        Operacao = c.String(),
                        IdNota = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.IdHistAprovacao);
            
            CreateTable(
                "dbo.Usuarios",
                c => new
                    {
                        IdUsuario = c.Int(nullable: false, identity: true),
                        Login = c.String(),
                        Senha = c.String(),
                        Papel = c.String(),
                        ValorMinAprovacao = c.Single(nullable: false),
                        ValorMaxAprovacao = c.Single(nullable: false),
                    })
                .PrimaryKey(t => t.IdUsuario);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Usuarios");
            DropTable("dbo.HistAprovacaos");
        }
    }
}
