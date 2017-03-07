using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRMKurs.EntityClasses
{
    class Olay:Abstract.EntityIdDefine
    {
        public DateTime Tarih { get; set; }
        public string OlayAdı{ get; set; }
        public string OlayBilgi { get; set; }
        public List<EntityClasses.Staff.Worker> Çalışan { get; set; }

} 
}
