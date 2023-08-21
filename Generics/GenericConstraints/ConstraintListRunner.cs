using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics.GenericConstraints
{
    public class ConstraintListRunner
    {
        public static void Main(string[] args)
        {
            MyLinkedList<Student> myStudents = new MyLinkedList<Student>();

            myStudents.AddToFirst(new Student(1,"Benn"));
            myStudents.AddToFirst(new Student(2, "Henry"));
            myStudents.AddToFirst(new Student(3, "Dan"));
            myStudents.AddToFirst(new Student(4, "Stan"));
            myStudents.AddToFirst(new Student(5, "Car"));

            foreach (var student in myStudents)
            {
                Console.WriteLine($"My name is {student.Name} and my student id {student.StudentId}");
            }

            Console.Read();


        }

    }
}
