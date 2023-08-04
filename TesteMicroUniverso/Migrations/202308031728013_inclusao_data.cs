namespace TesteMicroUniverso.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class inclusao_data : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.HistAprovacaos", "DtData", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.HistAprovacaos", "DtData");
        }
    }
}
