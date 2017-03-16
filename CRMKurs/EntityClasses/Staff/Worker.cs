using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRMKurs.EntityClasses.Staff
{
    public class Worker:Abstract.EntityIdDefine
    {
        /// <summary>
        /// Çalışanların kullanıcı adı.
        /// </summary>
        [Index(IsUnique = true,Order = 1)]
        [MaxLength(25)]
        public string KullanıcıAdı { get; set; }
        /// <summary>
        /// Çalışanların kullanıcı şifresi
        /// </summary>
            public string Şifre { get; set; }
        public enum Status
        {
            Yönetici,
            Kullanıcı

        }
        /// <summary>
        /// Çalışanın yönetici, kullanıcı gibi gruplara ayrılması
        /// </summary>
        public Status Statü { get; set; }
        /// <summary>
        /// Çalışanın e-posta bilgisi
        /// </summary>
        public string EMail { get; set; }
    }
}
