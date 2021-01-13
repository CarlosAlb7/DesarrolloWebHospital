namespace PruebaGit.Web.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
<<<<<<< HEAD:PruebaGit/PruebaGit.Web/Migrations/202101082227391_email.cs
    public partial class email : DbMigration
=======
    public partial class Send : DbMigration
>>>>>>> Daniel:PruebaGit/PruebaGit.Web/Migrations/202101100853555_Send.cs
    {
        public override void Up()
        {
            CreateTable(
                "dbo.SendEmails",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        To = c.String(),
                        From = c.String(),
                        Subject = c.String(),
                        Body = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.SendEmails");
        }
    }
}
