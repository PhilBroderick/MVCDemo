namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateMembershipTypeNames : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE MembershipTypes set Name = 'Quarterly' WHERE id = 3");
            Sql("UPDATE MembershipTypes set Name = 'Annual' WHERE id = 4");
        }
        
        public override void Down()
        {
        }
    }
}
