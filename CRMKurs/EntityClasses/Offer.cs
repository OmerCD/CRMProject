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
        public Person Person { get; set; }
        public Person Attendant { get; set; }
        public string Type { get; set; }
        public Person Responsible { get; set; }
        public string Notes { get; set; }   

    }
}
