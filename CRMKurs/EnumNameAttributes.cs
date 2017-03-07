using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRMKurs
{
    class EnumNameAttributes
    {
        [AttributeUsage(AttributeTargets.Field)]
        public class ReprAttribute : Attribute
        {
            public string Representation;
            public ReprAttribute(string representation)
            {
                this.Representation = representation;
            }
            public override string ToString()
            {
                return this.Representation;
            }
        }

    }
}
