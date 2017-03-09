using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CRMKurs.EntityClasses.Abstract;

namespace CRMKurs.EntityClasses
{
    class Person : MainEntity
    {
        public string Hitap { get; set; }
        public virtual Okul Okul { get; set; }
        public virtual string Sınıf { get; set; }
        [Required]
        public PersonTypes Type { get; set; }
        public Person() : base() { }
    }
}
