using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Lab_1
{
    // Teacher Class (Child Class) inherits from the Student Class (Parent Class)
    internal class Teacher : Student
    {
        public string TeacherSubject { get; set; }

        // Parameterized constructor
        public Teacher(string firstName, string lastName, string subject) { 
            GetterSetterFirstName = firstName;
            GetterSetterLastName = lastName;
            TeacherSubject = subject;
        }
        
        // Method to display the teacher info
        public void Teach()
        {
            Console.WriteLine($"Prof. {GetterSetterLastName} is teaching {TeacherSubject}");
        }
    }
}
