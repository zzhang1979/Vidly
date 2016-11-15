namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateNameForMembershipType : DbMigration
    {
        public override void Up()
        {
            Sql("update MembershipTypes set Name='Pay As You go' where Id=1");
            Sql("update MembershipTypes set Name = 'Monthly' where Id = 2");
            Sql("update MembershipTypes set Name = '3 Months' where Id = 3");
            Sql("update MembershipTypes set Name = 'Yearly' where Id = 4");
        }
        
        public override void Down()
        {
        }
    }
}
