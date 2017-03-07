namespace CRMKurs.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class test : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ExtraFields",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128, storeType: "nvarchar"),
                        Name = c.String(unicode: false),
                        InputType = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.MainTypes",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128, storeType: "nvarchar"),
                        Name = c.String(unicode: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Okuls",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128, storeType: "nvarchar"),
                        AdSoyad = c.String(unicode: false),
                        Tür = c.String(unicode: false),
                        EPosta = c.String(unicode: false),
                        Telefon = c.String(maxLength: 11, storeType: "nvarchar"),
                        Adres = c.String(unicode: false),
                        İl = c.String(unicode: false),
                        Bölge = c.String(unicode: false),
                        Ülke = c.String(unicode: false),
                        PostaKodu = c.String(unicode: false),
                        Notlar = c.String(unicode: false),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Telefon, unique: true);
            
            CreateTable(
                "dbo.Olays",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128, storeType: "nvarchar"),
                        Tarih = c.DateTime(nullable: false, precision: 0),
                        OlayAdı = c.String(unicode: false),
                        OlayBilgi = c.String(unicode: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Workers",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128, storeType: "nvarchar"),
                        KullanıcıAdı = c.String(unicode: false),
                        Şifre = c.String(unicode: false),
                        Statü = c.Int(nullable: false),
                        Olay_Id = c.String(maxLength: 128, storeType: "nvarchar"),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Olays", t => t.Olay_Id)
                .Index(t => t.Olay_Id);
            
            CreateTable(
                "dbo.Öğrenci",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128, storeType: "nvarchar"),
                        Hitap = c.String(unicode: false),
                        Sınıf = c.String(unicode: false),
                        AdSoyad = c.String(unicode: false),
                        Tür = c.String(unicode: false),
                        EPosta = c.String(unicode: false),
                        Telefon = c.String(maxLength: 11, storeType: "nvarchar"),
                        Adres = c.String(unicode: false),
                        İl = c.String(unicode: false),
                        Bölge = c.String(unicode: false),
                        Ülke = c.String(unicode: false),
                        PostaKodu = c.String(unicode: false),
                        Notlar = c.String(unicode: false),
                        Okul_Id = c.String(maxLength: 128, storeType: "nvarchar"),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Okuls", t => t.Okul_Id)
                .Index(t => t.Telefon, unique: true)
                .Index(t => t.Okul_Id);
            
            CreateTable(
                "dbo.Öğretmen",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128, storeType: "nvarchar"),
                        Hitap = c.String(unicode: false),
                        Sınıf = c.String(unicode: false),
                        AdSoyad = c.String(unicode: false),
                        Tür = c.String(unicode: false),
                        EPosta = c.String(unicode: false),
                        Telefon = c.String(maxLength: 11, storeType: "nvarchar"),
                        Adres = c.String(unicode: false),
                        İl = c.String(unicode: false),
                        Bölge = c.String(unicode: false),
                        Ülke = c.String(unicode: false),
                        PostaKodu = c.String(unicode: false),
                        Notlar = c.String(unicode: false),
                        Okul_Id = c.String(maxLength: 128, storeType: "nvarchar"),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Okuls", t => t.Okul_Id)
                .Index(t => t.Telefon, unique: true)
                .Index(t => t.Okul_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Öğretmen", "Okul_Id", "dbo.Okuls");
            DropForeignKey("dbo.Öğrenci", "Okul_Id", "dbo.Okuls");
            DropForeignKey("dbo.Workers", "Olay_Id", "dbo.Olays");
            DropIndex("dbo.Öğretmen", new[] { "Okul_Id" });
            DropIndex("dbo.Öğretmen", new[] { "Telefon" });
            DropIndex("dbo.Öğrenci", new[] { "Okul_Id" });
            DropIndex("dbo.Öğrenci", new[] { "Telefon" });
            DropIndex("dbo.Workers", new[] { "Olay_Id" });
            DropIndex("dbo.Okuls", new[] { "Telefon" });
            DropTable("dbo.Öğretmen");
            DropTable("dbo.Öğrenci");
            DropTable("dbo.Workers");
            DropTable("dbo.Olays");
            DropTable("dbo.Okuls");
            DropTable("dbo.MainTypes");
            DropTable("dbo.ExtraFields");
        }
    }
}
