using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRMKurs.EntityClasses
{
    class MainTypes: Abstract.EntityIdDefine
    {
        public MainTypes() : base() { }
        [PropertyMVC(ControlEnum.TextBox)]
        public string Name { get; set; }
        [PropertyMVC(ControlEnum.TextBox)]
        public string ClassName { get; set; }
    }
}
