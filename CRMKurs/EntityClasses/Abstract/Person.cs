using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRMKurs.EntityClasses.Abstract
{
    class Person : MainEntity
    {
        public string Hitap { get; set; }
        public virtual Okul Okul { get; set; }
        public string Sınıf { get; set; }
        public Person() : base() { }
    }
}
