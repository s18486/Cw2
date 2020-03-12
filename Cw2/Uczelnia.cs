using System;
using System.Collections.Generic;
using System.Text;

namespace Cw2
{
    public class Uczelnia
    {
        public string createdAt;
        public string author;
        public HashSet<Student> studenci;
        public List<Course> activeStudies;
    }
}
