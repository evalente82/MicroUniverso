namespace TesteMicroUniverso.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ajustesNoBd1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Notas", "Visto", c => c.Int(nullable: false));
            AlterColumn("dbo.Notas", "Aprovacao", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Notas", "Aprovacao", c => c.Int());
            AlterColumn("dbo.Notas", "Visto", c => c.Int());
        }
    }
}
