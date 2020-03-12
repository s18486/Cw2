using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace Cw2
{
    [Serializable]
    public class Course : IEquatable<Course>
    {
        public string name { get; set; }
        public int numberOfStudents{ get; set; }

    public bool Equals([AllowNull] Course other)
        {
            return name.Equals(other.name);
        }
    }
}
