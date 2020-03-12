using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace Cw2
{
    public class Course : IEquatable<Course>
    {
        public string name;
        public int numberOfStudents = 0;

        public bool Equals([AllowNull] Course other)
        {
            return name.Equals(other.name);
        }
    }
}
