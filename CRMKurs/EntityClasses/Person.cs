using System.ComponentModel.DataAnnotations;
using CRMKurs.Attributes;
using CRMKurs.EntityClasses.Abstract;

namespace CRMKurs.EntityClasses
{
    public class Person : MainEntity
    {
        enum Hitaplar
        {
            Bay,
            Bayan,
            Doktor,
            Profesör
        }
        [PropertyMVC("Hitap",ControlEnum.Combobox,typeof(Hitaplar))]
        public string Hitap { get; set; }
        [PropertyMVC("Kurum",ControlEnum.Entity)]
        public virtual Institution Institution { get; set; }
        [PropertyMVC("Sınıf",ControlEnum.TextBox)]
        public string Sinif { get; set; }
        [Required]
        [ExtraFieldSeperator]
        [PropertyMVC("Kişi Türü",ControlEnum.Entity)]
        public virtual PersonTypes PersonTypes { get; set; }
        public Person() : base() { }
    }
}
