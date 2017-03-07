using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRMKurs.EntityClasses.Staff
{
    class Worker:Abstract.EntityIdDefine
    {
        public string KullanıcıAdı { get; set; }
            public string Şifre { get; set; }
        public enum Status
        {
            Boss, Admin, User

        }
        public Status Statü { get; set; }
    }
}
