using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using CRMKurs.Attributes;

namespace CRMKurs.EntityClasses
{
    public class PersonTypes : Abstract.EntityIdDefine
    {
        [Index(IsUnique =  true)]
        [MaxLength(25)]
        [DisplayProperty]
        [PropertyMVC("İsim",ControlEnum.TextBox)]
        public string Isim { get; set; }
    }
}
