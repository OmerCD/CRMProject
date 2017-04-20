﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRMKurs.EntityClasses
{
    public class PersonTypes : Abstract.EntityIdDefine
    {
        [Index(IsUnique =  true)]
        [MaxLength(25)]
        [PropertyMVC("İsim",ControlEnum.TextBox)]
        public string Isim { get; set; }
    }
}
