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
        public string Hitap { get; set; }
        public virtual Institution Okul { get; set; }
        public virtual string Sınıf { get; set; }
        [Required]
        [PropertyMVC(ControlEnum.Entity)]
        public PersonTypes Type { get; set; }
        public Person() : base() { }
    }
}
