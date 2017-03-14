using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRMKurs.EntityClasses
{
    class ExtraField : Abstract.EntityIdDefine
    {
        public ExtraField() : base() { }

        [NotMapped]
        public static string[] FieldTypes => (new[] {"Tarih","Yazı","Not","Sayı","Para","Liste","Düğme","Hesaplanan/Sabit","Kurum/Kişi","Saat","Konum","Kullanıcı","İlleri","İlçeler"});
        public string Name { get; set; }
        public string InputType { get; set; }
        public PersonTypes ShowType { get; set; }
    }
}
