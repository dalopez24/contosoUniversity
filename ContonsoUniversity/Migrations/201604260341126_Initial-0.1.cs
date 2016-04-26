namespace ContonsoUniversity.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial01 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Enrollments", "Course_CourseID", "dbo.Courses");
            DropIndex("dbo.Enrollments", new[] { "Course_CourseID" });
            DropColumn("dbo.Enrollments", "CourseID");
            RenameColumn(table: "dbo.Enrollments", name: "Course_CourseID", newName: "CourseID");
            DropPrimaryKey("dbo.Courses");
            AlterColumn("dbo.Courses", "CourseID", c => c.Int(nullable: false));
            AlterColumn("dbo.Enrollments", "CourseID", c => c.Int(nullable: false));
            AddPrimaryKey("dbo.Courses", "CourseID");
            CreateIndex("dbo.Enrollments", "CourseID");
            AddForeignKey("dbo.Enrollments", "CourseID", "dbo.Courses", "CourseID", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Enrollments", "CourseID", "dbo.Courses");
            DropIndex("dbo.Enrollments", new[] { "CourseID" });
            DropPrimaryKey("dbo.Courses");
            AlterColumn("dbo.Enrollments", "CourseID", c => c.Long());
            AlterColumn("dbo.Courses", "CourseID", c => c.Long(nullable: false));
            AddPrimaryKey("dbo.Courses", "CourseID");
            RenameColumn(table: "dbo.Enrollments", name: "CourseID", newName: "Course_CourseID");
            AddColumn("dbo.Enrollments", "CourseID", c => c.Int(nullable: false));
            CreateIndex("dbo.Enrollments", "Course_CourseID");
            AddForeignKey("dbo.Enrollments", "Course_CourseID", "dbo.Courses", "CourseID");
        }
    }
}
