using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRMKurs.EntityClasses
{
    public class PersonTypes : CRMKurs.EntityClasses.Abstract.EntityIdDefine
    {
        [Index(IsUnique =  true)]
        [MaxLength(25)]
        [PropertyMVC(ControlEnum.TextBox)]
        public string TypeName { get; set; }
    }
}
