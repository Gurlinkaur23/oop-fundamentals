using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Lab_1
{
    internal class Student
    {
        // Private fields
        private int StudentId;
        private string FirstName;
        private string LastName;
        private double StudentGrade;
        
        // Using getters and setters to access the private fields
        public int GetterSetterStudentId
        {
            get { return StudentId; }
            set { StudentId = value; }
        }

        public string GetterSetterFirstName
        {
            get { return FirstName; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    this.FirstName = value;
                }
                else
                {
                    throw new Exception("Please enter a valid first name");
                }
            }
        }

        public string GetterSetterLastName
        {
            get { return LastName; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    this.LastName = value;
                }
                else
                {
                    throw new Exception("Please enter a valid last name");
                }
            }
        }

        public double GetterSetterGrade
        {
            get { return StudentGrade; }
            set {
                // Validation for the grade (0 - 100)
                if(value >= 0 && value <= 100)
                {
                    this.StudentGrade = value;
                } else
                {
                    throw new Exception("Please enter a valid grade between 0 and 100.");
                }
            }
        }

        // Default Constructor
        public Student()
        {
            StudentId = 123;
        }

        // Parameterized Constructor
        public Student(string firstName, string lastName, double grade)
        {
            GetterSetterFirstName = firstName;
            GetterSetterLastName = lastName;
            GetterSetterGrade = grade;
        }
    }
}
