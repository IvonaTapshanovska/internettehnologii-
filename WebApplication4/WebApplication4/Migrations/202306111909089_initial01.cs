namespace WebApplication4.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial01 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.StudentSubjectGrades", "StudentName_StudentId", "dbo.Students");
            DropIndex("dbo.StudentSubjectGrades", new[] { "StudentName_StudentId" });
            DropColumn("dbo.StudentSubjectGrades", "StudentName_StudentId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.StudentSubjectGrades", "StudentName_StudentId", c => c.Int());
            CreateIndex("dbo.StudentSubjectGrades", "StudentName_StudentId");
            AddForeignKey("dbo.StudentSubjectGrades", "StudentName_StudentId", "dbo.Students", "StudentId");
        }
    }
}
