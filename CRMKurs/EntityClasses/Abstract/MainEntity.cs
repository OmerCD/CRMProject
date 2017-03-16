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
        public string İsim { get; set; }
        public string Tür { get; set; }
        public string EPosta { get; set; }
        [Index(IsUnique = true, Order = 1)]
        [MaxLength(11)]
        public string Telefon { get; set; }
        public string Adres { get; set; }
        public string İl { get; set; }
        public string Bölge { get; set; }
        public string Ülke { get; set; }
        public string PostaKodu { get; set; }
        public string Notlar { get; set; }
    }
}
