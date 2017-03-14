using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CRMKurs.EntityClasses.Abstract;

namespace CRMKurs.EntityClasses
{
    class Log : EntityIdDefine
    {
        public Person Person { get; set; }
        public DateTime Date { get; set; }
        public string Action { get; set; }
        public Log()
        {
            Date = DateTime.Now;
        }
    }
}
