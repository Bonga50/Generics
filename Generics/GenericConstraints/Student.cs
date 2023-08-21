using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics.GenericConstraints
{
    public class Student
    {
        public int StudentId { get; set; }
        public string Name { get; set; }

        public Student(int studentId, string name)
        {
            StudentId = studentId;
            Name = name;
        }

        public override string ToString()
        {
            return ($"{Name} - {StudentId}");
        }
    }
}
