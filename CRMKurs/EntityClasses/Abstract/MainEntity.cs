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
        public string İsim { get; set; }
        [PropertyMVC(ControlEnum.TextBox)]
        public string Tür { get; set; }
        [PropertyMVC(ControlEnum.TextBox)]
        public string EPosta { get; set; }
        [Index(IsUnique = true, Order = 1)]
        [MaxLength(11)]
        [PropertyMVC(ControlEnum.TextBox)]
        public string Telefon { get; set; }
        public string Adres { get; set; }
        [PropertyMVC(ControlEnum.Combobox)]
        public string İl { get; set; }
        [PropertyMVC(ControlEnum.Combobox)]
        public string Bölge { get; set; }
        [PropertyMVC(ControlEnum.Combobox)]
        public string Ülke { get; set; }
        [PropertyMVC(ControlEnum.TextBox)]
        public string PostaKodu { get; set; }
        [PropertyMVC(ControlEnum.TextBox)]
        public string Notlar { get; set; }
    }
}
