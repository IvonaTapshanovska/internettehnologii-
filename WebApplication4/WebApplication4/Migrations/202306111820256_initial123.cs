namespace WebApplication4.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial123 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.StudentSubjectGrades",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        SubjectId = c.Int(nullable: false),
                        selectedStudent = c.Int(nullable: false),
                        Grade = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Subjects", t => t.SubjectId, cascadeDelete: true)
                .Index(t => t.SubjectId);
            
            AddColumn("dbo.Students", "StudentSubjectGrades_Id", c => c.Int());
            CreateIndex("dbo.Students", "StudentSubjectGrades_Id");
            AddForeignKey("dbo.Students", "StudentSubjectGrades_Id", "dbo.StudentSubjectGrades", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.StudentSubjectGrades", "SubjectId", "dbo.Subjects");
            DropForeignKey("dbo.Students", "StudentSubjectGrades_Id", "dbo.StudentSubjectGrades");
            DropIndex("dbo.StudentSubjectGrades", new[] { "SubjectId" });
            DropIndex("dbo.Students", new[] { "StudentSubjectGrades_Id" });
            DropColumn("dbo.Students", "StudentSubjectGrades_Id");
            DropTable("dbo.StudentSubjectGrades");
        }
    }
}
