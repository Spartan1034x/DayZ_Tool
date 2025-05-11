using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace GlobalsEditor
{
    // Base element
    [XmlRoot(ElementName = "variables")]
    public class Variables
    {

        [XmlElement(ElementName = "var")]
        public List<Var> Var { get; set; }
    }

    [XmlRoot(ElementName = "var")]
    public class Var
    {

        [XmlAttribute(AttributeName = "name")]
        public string Name { get; set; }

        [XmlAttribute(AttributeName = "type")]
        public int Type { get; set; }

        [XmlAttribute(AttributeName = "value")]
        public int Value { get; set; }
    }
}
