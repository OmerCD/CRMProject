using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
