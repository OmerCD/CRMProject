using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRMKurs.EntityClasses.Abstract
{
    abstract class EntityIdDefine
    {
        [Key]
        public string Id { get; set; }
        public EntityIdDefine()
        {
            Id = Guid.NewGuid().ToString();
        }
    }
}
