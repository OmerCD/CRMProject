using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        [PropertyMVC(ControlEnum.Combobox,typeof(Hitaplar))]
        public string Hitap { get; set; }
        [PropertyMVC(ControlEnum.Entity)]
        public virtual Institution Institution { get; set; }
        [PropertyMVC(ControlEnum.TextBox)]
        public virtual string Sinif { get; set; }
        [Required]
        [PropertyMVC(ControlEnum.Entity)]
        public PersonTypes PersonTypes { get; set; }
        public Person() : base() { }
    }
}
