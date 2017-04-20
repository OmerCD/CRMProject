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
        [NotMapped]
        public static string[] FieldTypes => new[] {"Tarih","Yazı","Not","Sayı","Para","Liste","Düğme","Hesaplanan/Sabit","Kurum/Kişi","Saat","Konum","Kullanıcı","İlleri","İlçeler"}; // Seçilebilecek Ekstra alan türleri
        public string ExtraName { get; set; }
        /// <summary>
        /// FieldTypes'dan alınacak türün saklanacığı yer.
        /// </summary>
        public string InputType { get; set; } 
        /// <summary>
        /// kullanıcı/kurum veya kişi gibi kişi türleri arasından hangisine gösterileceğini seçmek
        /// </summary>
        public PersonTypes ShowType { get; set; }
    }
}
