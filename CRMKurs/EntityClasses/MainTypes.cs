using CRMKurs.Attributes;

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
