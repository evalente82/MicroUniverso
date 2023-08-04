namespace TesteMicroUniverso.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CriacaoFKs : DbMigration
    {
        public override void Up()
        {
            CreateIndex("dbo.HistAprovacaos", "IdUsuario");
            CreateIndex("dbo.HistAprovacaos", "IdNota");
            AddForeignKey("dbo.HistAprovacaos", "IdNota", "dbo.Notas", "IdNota", cascadeDelete: true);
            AddForeignKey("dbo.HistAprovacaos", "IdUsuario", "dbo.Usuarios", "IdUsuario", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.HistAprovacaos", "IdUsuario", "dbo.Usuarios");
            DropForeignKey("dbo.HistAprovacaos", "IdNota", "dbo.Notas");
            DropIndex("dbo.HistAprovacaos", new[] { "IdNota" });
            DropIndex("dbo.HistAprovacaos", new[] { "IdUsuario" });
        }
    }
}
