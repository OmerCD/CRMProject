using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRMKurs.EntityClasses
{
    class PersonTypes : CRMKurs.EntityClasses.Abstract.EntityIdDefine
    {
        [Index(IsUnique =  true)]
        [MaxLength(25)]
        public string Name { get; set; }
    }
}
