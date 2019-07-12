namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class first1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Prospects", "MatriculeVehicule", c => c.String());
            AddColumn("dbo.Prospects", "MatriculeChefCampagne", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Prospects", "MatriculeChefCampagne");
            DropColumn("dbo.Prospects", "MatriculeVehicule");
        }
    }
}
