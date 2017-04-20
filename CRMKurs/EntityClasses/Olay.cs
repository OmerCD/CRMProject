﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRMKurs.EntityClasses
{
    class Olay:Abstract.EntityIdDefine
    {
        [PropertyMVC(ControlEnum.DateTime)]
        public DateTime Tarih { get; set; }
        [PropertyMVC(ControlEnum.TextBox)]
        public string OlayAdi{ get; set; }
        [PropertyMVC(ControlEnum.TextBox)]
        public string OlayBilgi { get; set; }
        [PropertyMVC("Çalışan",ControlEnum.Entity)]
        public List<Staff.Worker> Calisan { get; set; }

    } 
}
