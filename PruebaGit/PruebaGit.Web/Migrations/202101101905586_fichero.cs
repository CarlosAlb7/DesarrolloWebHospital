namespace PruebaGit.Web.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class fichero : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.SendEmails", "fichero", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.SendEmails", "fichero");
        }
    }
}
