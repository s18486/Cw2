using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;
using System.Xml.Serialization;

namespace Cw2
{
    public class Uczelnia
    {
        [XmlAttribute(AttributeName = "createdAt")]
        [JsonPropertyName("createdAt")]
        public string createdAt { get; set; }
        [JsonPropertyName("author")]
        [XmlAttribute(AttributeName = "author")]
        public string author { get; set; }
        public HashSet<Student> studenci { get; set; }
        public List<Course> activeStudies { get; set; }
    }
}
