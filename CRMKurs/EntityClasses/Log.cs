using System;
using CRMKurs.EntityClasses.Abstract;
using CRMKurs.EntityClasses.Staff;

namespace CRMKurs.EntityClasses
{
    public class Log : EntityIdDefine
    {
        public Worker Worker { get; set; }
        public DateTime Date { get; set; }
        public string Action { get; set; }
        public Log()
        {
            Date = DateTime.Now;
        }
    }
}
