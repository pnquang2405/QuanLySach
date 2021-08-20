namespace QuanLySach.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateTables : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.KhachHangs",
                c => new
                    {
                        IDKH = c.Int(nullable: false, identity: true),
                        TenKH = c.String(),
                    })
                .PrimaryKey(t => t.IDKH);
            
            CreateTable(
                "dbo.Muons",
                c => new
                    {
                        IDSach = c.Int(nullable: false),
                        IDKH = c.Int(nullable: false),
                        Sach_MaSach = c.Int(),
                    })
                .PrimaryKey(t => new { t.IDSach, t.IDKH })
                .ForeignKey("dbo.KhachHangs", t => t.IDKH, cascadeDelete: true)
                .ForeignKey("dbo.Saches", t => t.Sach_MaSach)
                .Index(t => t.IDKH)
                .Index(t => t.Sach_MaSach);
            
            CreateTable(
                "dbo.Saches",
                c => new
                    {
                        MaSach = c.Int(nullable: false, identity: true),
                        TenSach = c.String(nullable: false),
                        TheLoai_MaTL = c.Int(),
                    })
                .PrimaryKey(t => t.MaSach)
                .ForeignKey("dbo.TheLoais", t => t.TheLoai_MaTL)
                .Index(t => t.TheLoai_MaTL);
            
            CreateTable(
                "dbo.TheLoais",
                c => new
                    {
                        MaTL = c.Int(nullable: false, identity: true),
                        TenTL = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.MaTL);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Saches", "TheLoai_MaTL", "dbo.TheLoais");
            DropForeignKey("dbo.Muons", "Sach_MaSach", "dbo.Saches");
            DropForeignKey("dbo.Muons", "IDKH", "dbo.KhachHangs");
            DropIndex("dbo.Saches", new[] { "TheLoai_MaTL" });
            DropIndex("dbo.Muons", new[] { "Sach_MaSach" });
            DropIndex("dbo.Muons", new[] { "IDKH" });
            DropTable("dbo.TheLoais");
            DropTable("dbo.Saches");
            DropTable("dbo.Muons");
            DropTable("dbo.KhachHangs");
        }
    }
}
