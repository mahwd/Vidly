namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateMemberShipTypes : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO MemberShipTypes(Id, SignUpFee, Duration, DiscountRate) VALUES(1,0,1,0)");
            Sql("INSERT INTO MemberShipTypes(Id, SignUpFee, Duration, DiscountRate) VALUES(2,15,1,10)");
            Sql("INSERT INTO MemberShipTypes(Id, SignUpFee, Duration, DiscountRate) VALUES(3,60,4,15)");
            Sql("INSERT INTO MemberShipTypes(Id, SignUpFee, Duration, DiscountRate) VALUES(4,180,12,20)");
        }
        
        public override void Down()
        {
        }
    }
}
