using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using CRMKurs.Attributes;

namespace CRMKurs.EntityClasses.Staff
{
    public class Worker:Abstract.EntityIdDefine
    {
        /// <summary>
        /// Çalışanların kullanıcı adı.
        /// </summary>
        [Index(IsUnique = true,Order = 1)]
        [MaxLength(25)]
        [PropertyMVC(ControlEnum.TextBox)]
        public string KullaniciAdi { get; set; }
        /// <summary>
        /// Çalışanların kullanıcı şifresi
        /// </summary>
        [PropertyMVC(ControlEnum.TextBox)]
        public string Sifre { get; set; }
        public enum Status
        {
            Yönetici,
            Kullanıcı

        }
        /// <summary>
        /// Çalışanın yönetici, kullanıcı gibi gruplara ayrılması
        /// </summary>
        [PropertyMVC(ControlEnum.Combobox,typeof(Status))]
        public Status Statu { get; set; }
        /// <summary>
        /// Çalışanın e-posta bilgisi
        /// </summary>
        [PropertyMVC(ControlEnum.TextBox)]
        public string EMail { get; set; }
    }
}
