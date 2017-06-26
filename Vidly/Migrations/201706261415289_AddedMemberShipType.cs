namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedMemberShipType : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.MemberShipTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        SignUpFee = c.Short(nullable: false),
                        Duration = c.Byte(nullable: false),
                        DiscountRate = c.Int(nullable: false),
                        MemberShipTypeId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Customers", "isSubscribed", c => c.Boolean(nullable: false));
            AddColumn("dbo.Customers", "memberShipTypeId", c => c.Int(nullable: false));
            CreateIndex("dbo.Customers", "memberShipTypeId");
            AddForeignKey("dbo.Customers", "memberShipTypeId", "dbo.MemberShipTypes", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Customers", "memberShipTypeId", "dbo.MemberShipTypes");
            DropIndex("dbo.Customers", new[] { "memberShipTypeId" });
            DropColumn("dbo.Customers", "memberShipTypeId");
            DropColumn("dbo.Customers", "isSubscribed");
            DropTable("dbo.MemberShipTypes");
        }
    }
}
