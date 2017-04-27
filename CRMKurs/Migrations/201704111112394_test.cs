namespace CRMKurs.Migrations
{
    using System.Data.Entity.Migrations;
    
    public partial class test : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ExtraField",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128, storeType: "nvarchar"),
                        ExtraName = c.String(unicode: false),
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
                        Isim = c.String(maxLength: 25, storeType: "nvarchar"),
                        OwnerId = c.String(unicode: false),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Isim, unique: true);
            
            CreateTable(
                "dbo.Institution",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128, storeType: "nvarchar"),
                        Isim = c.String(unicode: false),
                        Tur = c.String(unicode: false),
                        EPosta = c.String(unicode: false),
                        Telefon = c.String(maxLength: 11, storeType: "nvarchar"),
                        Adres = c.String(unicode: false),
                        Il = c.String(unicode: false),
                        Bolge = c.String(unicode: false),
                        Ulke = c.String(unicode: false),
                        PostaKodu = c.String(unicode: false),
                        Notlar = c.String(unicode: false),
                        OwnerId = c.String(unicode: false),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Telefon, unique: true);
            
            CreateTable(
                "dbo.Log",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128, storeType: "nvarchar"),
                        Date = c.DateTime(nullable: false, precision: 0),
                        Action = c.String(unicode: false),
                        OwnerId = c.String(unicode: false),
                        Worker_Id = c.String(maxLength: 128, storeType: "nvarchar"),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Worker", t => t.Worker_Id)
                .Index(t => t.Worker_Id);
            
            CreateTable(
                "dbo.Worker",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128, storeType: "nvarchar"),
                        KullaniciAdi = c.String(maxLength: 25, storeType: "nvarchar"),
                        Sifre = c.String(unicode: false),
                        Statu = c.Int(nullable: false),
                        EMail = c.String(unicode: false),
                        OwnerId = c.String(unicode: false),
                        Olay_Id = c.String(maxLength: 128, storeType: "nvarchar"),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Olay", t => t.Olay_Id)
                .Index(t => t.KullaniciAdi, unique: true)
                .Index(t => t.Olay_Id);
            
            CreateTable(
                "dbo.MainBoss",
                c => new
                    {
                        OwnerId = c.String(nullable: false, maxLength: 128, storeType: "nvarchar"),
                        KullaniciAdi = c.String(nullable: false, maxLength: 25, storeType: "nvarchar"),
                        Sifre = c.String(nullable: false, maxLength: 25, storeType: "nvarchar"),
                    })
                .PrimaryKey(t => t.OwnerId)
                .Index(t => t.KullaniciAdi, unique: true);
            
            CreateTable(
                "dbo.MainTypes",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128, storeType: "nvarchar"),
                        Name = c.String(unicode: false),
                        ClassName = c.String(unicode: false),
                        OwnerId = c.String(unicode: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Olay",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128, storeType: "nvarchar"),
                        Tarih = c.DateTime(nullable: false, precision: 0),
                        OlayAdi = c.String(unicode: false),
                        OlayBilgi = c.String(unicode: false),
                        OwnerId = c.String(unicode: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Person",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128, storeType: "nvarchar"),
                        Hitap = c.String(unicode: false),
                        Sinif = c.String(unicode: false),
                        Isim = c.String(unicode: false),
                        Tur = c.String(unicode: false),
                        EPosta = c.String(unicode: false),
                        Telefon = c.String(maxLength: 11, storeType: "nvarchar"),
                        Adres = c.String(unicode: false),
                        Il = c.String(unicode: false),
                        Bolge = c.String(unicode: false),
                        Ulke = c.String(unicode: false),
                        PostaKodu = c.String(unicode: false),
                        Notlar = c.String(unicode: false),
                        OwnerId = c.String(unicode: false),
                        Institution_Id = c.String(maxLength: 128, storeType: "nvarchar"),
                        PersonTypes_Id = c.String(nullable: false, maxLength: 128, storeType: "nvarchar"),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Institution", t => t.Institution_Id)
                .ForeignKey("dbo.PersonTypes", t => t.PersonTypes_Id, cascadeDelete: true)
                .Index(t => t.Telefon, unique: true)
                .Index(t => t.Institution_Id)
                .Index(t => t.PersonTypes_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Person", "PersonTypes_Id", "dbo.PersonTypes");
            DropForeignKey("dbo.Person", "Institution_Id", "dbo.Institution");
            DropForeignKey("dbo.Worker", "Olay_Id", "dbo.Olay");
            DropForeignKey("dbo.Log", "Worker_Id", "dbo.Worker");
            DropForeignKey("dbo.ExtraField", "ShowType_Id", "dbo.PersonTypes");
            DropIndex("dbo.Person", new[] { "PersonTypes_Id" });
            DropIndex("dbo.Person", new[] { "Institution_Id" });
            DropIndex("dbo.Person", new[] { "Telefon" });
            DropIndex("dbo.MainBoss", new[] { "KullaniciAdi" });
            DropIndex("dbo.Worker", new[] { "Olay_Id" });
            DropIndex("dbo.Worker", new[] { "KullaniciAdi" });
            DropIndex("dbo.Log", new[] { "Worker_Id" });
            DropIndex("dbo.Institution", new[] { "Telefon" });
            DropIndex("dbo.PersonTypes", new[] { "Isim" });
            DropIndex("dbo.ExtraField", new[] { "ShowType_Id" });
            DropTable("dbo.Person");
            DropTable("dbo.Olay");
            DropTable("dbo.MainTypes");
            DropTable("dbo.MainBoss");
            DropTable("dbo.Worker");
            DropTable("dbo.Log");
            DropTable("dbo.Institution");
            DropTable("dbo.PersonTypes");
            DropTable("dbo.ExtraField");
        }
    }
}
