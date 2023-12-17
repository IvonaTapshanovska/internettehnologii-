namespace WebApplication4.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial0 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.StudentSubjectGrades", "StudentName_StudentId", c => c.Int());
            CreateIndex("dbo.StudentSubjectGrades", "StudentName_StudentId");
            AddForeignKey("dbo.StudentSubjectGrades", "StudentName_StudentId", "dbo.Students", "StudentId");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.StudentSubjectGrades", "StudentName_StudentId", "dbo.Students");
            DropIndex("dbo.StudentSubjectGrades", new[] { "StudentName_StudentId" });
            DropColumn("dbo.StudentSubjectGrades", "StudentName_StudentId");
        }
    }
}
