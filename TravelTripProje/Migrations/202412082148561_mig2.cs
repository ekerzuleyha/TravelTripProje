namespace TravelTripProje.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig2 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.BizeUlasın",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Adres = c.String(),
                        Mail = c.String(),
                        Telefon = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.BizeUlasın");
        }
    }
}
