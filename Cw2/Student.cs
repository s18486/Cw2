using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;
using System.Xml.Serialization;

namespace Cw2
{
    [Serializable]
    public class Student
    {
        [JsonPropertyName("indexNumber")]
        [XmlAttribute(AttributeName = "indexNumber")]
        public string indexNumber { get; set; }      
        public string fname { get; set; }
        public string lname { get; set; }
        public string birthdate { get; set; }
        public string email { get; set; }
        public string mothersName { get; set; }
        public string fathersName { get; set; }
        public StCourse studies { get; set; }

    }
}
