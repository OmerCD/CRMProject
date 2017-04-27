using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CRMKurs.EntityClasses
{
    public class MainBoss
    {
        [Key]
        public string OwnerId { get; set; }
        [Required]
        [Index(IsUnique = true)]
        [MaxLength(25)]
        public string KullaniciAdi { get; set; }
        [Required]
        [MaxLength(25)]
        public virtual string Sifre { get; set; }
    }
}
