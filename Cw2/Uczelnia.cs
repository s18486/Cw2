using System.Collections.Generic;
using System.Xml.Serialization;

namespace Cw2
{ 
    public class Uczelnia
    {
        [XmlAttribute(AttributeName = "createdAt")]      
        public string createdAt { get; set; }
        [XmlAttribute(AttributeName = "author")]
        public string author { get; set; }
        public HashSet<Student> studenci { get; set; }
        public List<Course> activeStudies { get; set; }
    }
}
