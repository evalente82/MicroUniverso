namespace TesteMicroUniverso.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ajustesNoBd2 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Notas", "VlMercadorias", c => c.Decimal(precision: 18, scale: 2));
            AlterColumn("dbo.Notas", "Desconto", c => c.Decimal(precision: 18, scale: 2));
            AlterColumn("dbo.Notas", "Frete", c => c.Decimal(precision: 18, scale: 2));
            AlterColumn("dbo.Notas", "Total", c => c.Decimal(precision: 18, scale: 2));
            AlterColumn("dbo.Notas", "Visto", c => c.Int());
            AlterColumn("dbo.Notas", "Aprovacao", c => c.Int());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Notas", "Aprovacao", c => c.Int(nullable: false));
            AlterColumn("dbo.Notas", "Visto", c => c.Int(nullable: false));
            AlterColumn("dbo.Notas", "Total", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.Notas", "Frete", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.Notas", "Desconto", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.Notas", "VlMercadorias", c => c.Decimal(nullable: false, precision: 18, scale: 2));
        }
    }
}
