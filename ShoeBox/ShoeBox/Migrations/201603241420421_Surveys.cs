namespace ShoeBox.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Surveys : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CookieSurveys",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Question1 = c.String(),
                        Question2 = c.String(),
                        Question3 = c.String(),
                        QuestionAnswer = c.String(),
                        QuestionScore = c.Int(nullable: false),
                        TotalScore = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.CookieSurveys");
        }
    }
}
