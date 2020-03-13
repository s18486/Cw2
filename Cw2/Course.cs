using System;
using System.Diagnostics.CodeAnalysis;

namespace Cw2
{
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
