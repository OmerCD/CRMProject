using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRMKurs.EntityClasses
{
    class ExtraField : Abstract.EntityIdDefine
    {
        public ExtraField() : base() { }
        public enum FieldType
        {
            Tarih,Yazı,
            Not,Sayı,
            Para,Liste,
            Düğme,Hesaplanan_Sabit,
            Kurum_Kişi,Saat,
            Konum,Kullanıcı,
            İlleri,İlçeler
        }
        public string Name { get; set; }
        public FieldType InputType { get; set; }
    }
}
