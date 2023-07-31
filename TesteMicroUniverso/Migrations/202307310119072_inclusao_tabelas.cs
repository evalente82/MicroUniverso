namespace TesteMicroUniverso.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class inclusao_tabelas : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ConfigFaixaPrecoes",
                c => new
                    {
                        IdFaixa = c.Int(nullable: false, identity: true),
                        FaixaMin = c.Single(nullable: false),
                        FaixaMax = c.Single(nullable: false),
                        Visto = c.Int(nullable: false),
                        Aprovacao = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.IdFaixa);
            
            CreateTable(
                "dbo.Notas",
                c => new
                    {
                        IdNota = c.Int(nullable: false, identity: true),
                        Emissao = c.DateTime(nullable: false),
                        VlMercadorias = c.Single(nullable: false),
                        Desconto = c.Single(nullable: false),
                        Frete = c.Single(nullable: false),
                        Total = c.Single(nullable: false),
                        Status = c.Boolean(nullable: false),
                        Visto = c.Int(nullable: false),
                        Aprovacao = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.IdNota);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Notas");
            DropTable("dbo.ConfigFaixaPrecoes");
        }
    }
}
