using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CRMKurs.EntityClasses.Abstract
{
    public abstract class MainEntity:EntityIdDefine
    {
        public MainEntity() : base() { }
        [PropertyMVC("İsim", ControlEnum.TextBox)]
        public string Isim { get; set; }
        [PropertyMVC("Tür", ControlEnum.TextBox)]
        public string Tur { get; set; }
        [PropertyMVC("EPosta", ControlEnum.TextBox)]
        public string EPosta { get; set; }
        [Index(IsUnique = true, Order = 1)]
        [MaxLength(11)]
        [PropertyMVC("Telefon", ControlEnum.TextBox)]
        public string Telefon { get; set; }
        [PropertyMVC("Adres", ControlEnum.MultilineTextBox)]
        public string Adres { get; set; }
        [PropertyMVC("İl", ControlEnum.TextBox)]
        public string Il { get; set; }
        [PropertyMVC("Bölge", ControlEnum.TextBox)]
        public string Bolge { get; set; }
        [PropertyMVC("Ülke", ControlEnum.TextBox)]
        public string Ulke { get; set; }
        [PropertyMVC("Posta Kodu", ControlEnum.TextBox)]
        public string PostaKodu { get; set; }
        [PropertyMVC("Notlar", ControlEnum.MultilineTextBox)]
        public string Notlar { get; set; }
    }
}
