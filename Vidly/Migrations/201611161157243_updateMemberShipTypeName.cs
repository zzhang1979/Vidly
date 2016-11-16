namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updateMemberShipTypeName : DbMigration
    {
        public override void Up()
        {
            Sql("update MembershipTypes set name='Quarterly' where Id=3");
            Sql("update MembershipTypes set name='Annualy' where Id=4");
        }
        
        public override void Down()
        {
        }
    }
}
