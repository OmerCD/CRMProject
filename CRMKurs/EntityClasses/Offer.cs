using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using CRMKurs.EntityClasses.Abstract;

namespace CRMKurs.EntityClasses
{
    class Offer : EntityIdDefine
    {
        [PropertyMVC(ControlEnum.Entity)]
        public Person Person { get; set; }
        [PropertyMVC(ControlEnum.Entity)]
        public Person Attendant { get; set; }
        [PropertyMVC(ControlEnum.TextBox)]
        public string Type { get; set; }
        [PropertyMVC(ControlEnum.Entity)]
        public Person Responsible { get; set; }
        [PropertyMVC(ControlEnum.TextBox)]
        public string Notes { get; set; }   

    }
}
