namespace TesteMicroUniverso.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ajustesNoBd : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.ConfigFaixaPrecoes", "FaixaMin", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.ConfigFaixaPrecoes", "FaixaMax", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.Notas", "VlMercadorias", c => c.Decimal(nullable: true, precision: 18, scale: 2));
            AlterColumn("dbo.Notas", "Desconto", c => c.Decimal(nullable: true, precision: 18, scale: 2));
            AlterColumn("dbo.Notas", "Frete", c => c.Decimal(nullable: true, precision: 18, scale: 2));
            AlterColumn("dbo.Notas", "Total", c => c.Decimal(nullable: true, precision: 18, scale: 2));
            AlterColumn("dbo.Usuarios", "ValorMinAprovacao", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.Usuarios", "ValorMaxAprovacao", c => c.Decimal(nullable: false, precision: 18, scale: 2));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Usuarios", "ValorMaxAprovacao", c => c.Single(nullable: false));
            AlterColumn("dbo.Usuarios", "ValorMinAprovacao", c => c.Single(nullable: false));
            AlterColumn("dbo.Notas", "Total", c => c.Single(nullable: true));
            AlterColumn("dbo.Notas", "Frete", c => c.Single(nullable: true));
            AlterColumn("dbo.Notas", "Desconto", c => c.Single(nullable: true));
            AlterColumn("dbo.Notas", "VlMercadorias", c => c.Single(nullable: true));
            AlterColumn("dbo.ConfigFaixaPrecoes", "FaixaMax", c => c.Single(nullable: false));
            AlterColumn("dbo.ConfigFaixaPrecoes", "FaixaMin", c => c.Single(nullable: false));
        }
    }
}
