using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRMKurs.EntityClasses.Staff
{
    class Worker:Abstract.EntityIdDefine
    {
        [Index(IsUnique = true,Order = 1)]
        [MaxLength(25)]
        public string KullanıcıAdı { get; set; }
            public string Şifre { get; set; }
        public enum Status
        {
            Yönetici,
            Kullanıcı

        }
        public Status Statü { get; set; }
        public string EMail { get; set; }
    }
}
