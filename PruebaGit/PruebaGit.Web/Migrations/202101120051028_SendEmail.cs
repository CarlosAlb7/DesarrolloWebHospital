namespace PruebaGit.Web.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SendEmail : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.SendEmails", "verificar", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.SendEmails", "verificar");
        }
    }
}
