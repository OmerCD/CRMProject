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
        [PropertyMVC(ControlEnum.TextBox)]
        public string Isim { get; set; }
        [PropertyMVC(ControlEnum.TextBox)]
        public string Tur { get; set; }
        [PropertyMVC(ControlEnum.TextBox)]
        public string EPosta { get; set; }
        [Index(IsUnique = true, Order = 1)]
        [MaxLength(11)]
        [PropertyMVC(ControlEnum.TextBox)]
        public string Telefon { get; set; }
        [PropertyMVC(ControlEnum.MultilineTextBox)]
        public string Adres { get; set; }
        [PropertyMVC(ControlEnum.Combobox)]
        public string Il { get; set; }
        [PropertyMVC(ControlEnum.Combobox)]
        public string Bolge { get; set; }
        [PropertyMVC(ControlEnum.Combobox)]
        public string Ulke { get; set; }
        [PropertyMVC(ControlEnum.TextBox)]
        public string PostaKodu { get; set; }
        [PropertyMVC(ControlEnum.MultilineTextBox)]
        public string Notlar { get; set; }
    }
}
