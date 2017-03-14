namespace CRMKurs.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class test : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.MainBosses",
                c => new
                    {
                        OwnerId = c.String(nullable: false, maxLength: 128, storeType: "nvarchar"),
                        KullanıcıAdı = c.String(nullable: false, maxLength: 25, storeType: "nvarchar"),
                        Şifre = c.String(nullable: false, maxLength: 25, storeType: "nvarchar"),
                    })
                .PrimaryKey(t => t.OwnerId)
                .Index(t => t.KullanıcıAdı, unique: true);
            
            CreateTable(
                "dbo.ExtraFields",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128, storeType: "nvarchar"),
                        Name = c.String(unicode: false),
                        InputType = c.String(unicode: false),
                        OwnerId = c.String(unicode: false),
                        ShowType_Id = c.String(maxLength: 128, storeType: "nvarchar"),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.PersonTypes", t => t.ShowType_Id)
                .Index(t => t.ShowType_Id);
            
            CreateTable(
                "dbo.PersonTypes",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128, storeType: "nvarchar"),
                        Name = c.String(maxLength: 25, storeType: "nvarchar"),
                        OwnerId = c.String(unicode: false),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Name, unique: true);
            
            CreateTable(
                "dbo.People",
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
                        OwnerId = c.String(unicode: false),
                        Okul_Id = c.String(maxLength: 128, storeType: "nvarchar"),
                        Type_Id = c.String(nullable: false, maxLength: 128, storeType: "nvarchar"),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Okuls", t => t.Okul_Id)
                .ForeignKey("dbo.PersonTypes", t => t.Type_Id, cascadeDelete: true)
                .Index(t => t.Telefon, unique: true)
                .Index(t => t.Okul_Id)
                .Index(t => t.Type_Id);
            
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
                        OwnerId = c.String(unicode: false),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Telefon, unique: true);
            
            CreateTable(
                "dbo.MainTypes",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128, storeType: "nvarchar"),
                        Name = c.String(unicode: false),
                        OwnerId = c.String(unicode: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Olays",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128, storeType: "nvarchar"),
                        Tarih = c.DateTime(nullable: false, precision: 0),
                        OlayAdı = c.String(unicode: false),
                        OlayBilgi = c.String(unicode: false),
                        OwnerId = c.String(unicode: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Workers",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128, storeType: "nvarchar"),
                        KullanıcıAdı = c.String(maxLength: 25, storeType: "nvarchar"),
                        Şifre = c.String(unicode: false),
                        Statü = c.Int(nullable: false),
                        EMail = c.String(unicode: false),
                        OwnerId = c.String(unicode: false),
                        Olay_Id = c.String(maxLength: 128, storeType: "nvarchar"),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Olays", t => t.Olay_Id)
                .Index(t => t.KullanıcıAdı, unique: true)
                .Index(t => t.Olay_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Workers", "Olay_Id", "dbo.Olays");
            DropForeignKey("dbo.People", "Type_Id", "dbo.PersonTypes");
            DropForeignKey("dbo.People", "Okul_Id", "dbo.Okuls");
            DropForeignKey("dbo.ExtraFields", "ShowType_Id", "dbo.PersonTypes");
            DropIndex("dbo.Workers", new[] { "Olay_Id" });
            DropIndex("dbo.Workers", new[] { "KullanıcıAdı" });
            DropIndex("dbo.Okuls", new[] { "Telefon" });
            DropIndex("dbo.People", new[] { "Type_Id" });
            DropIndex("dbo.People", new[] { "Okul_Id" });
            DropIndex("dbo.People", new[] { "Telefon" });
            DropIndex("dbo.PersonTypes", new[] { "Name" });
            DropIndex("dbo.ExtraFields", new[] { "ShowType_Id" });
            DropIndex("dbo.MainBosses", new[] { "KullanıcıAdı" });
            DropTable("dbo.Workers");
            DropTable("dbo.Olays");
            DropTable("dbo.MainTypes");
            DropTable("dbo.Okuls");
            DropTable("dbo.People");
            DropTable("dbo.PersonTypes");
            DropTable("dbo.ExtraFields");
            DropTable("dbo.MainBosses");
        }
    }
}
