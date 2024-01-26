using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Lab_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // Creating student object of Student class (Default constructor)
                Student studentObj = new Student();

                // Creating student object of Student class (Parameter constructor)
                Student studentObjParam = new Student("Chandler", "Bing", 95);

                // Displaying the student information to the console
                Console.WriteLine("The student details are as follows:");

                // Displaying student ID using the Default Constructor
                Console.WriteLine($"Student ID: {studentObj.GetterSetterStudentId}");

                // Setting the values of attributes using properties

                // Displaying student first name, last name and grade using the Parameter Constructor
                Console.WriteLine($"Student First Name: {studentObjParam.GetterSetterFirstName}");
                Console.WriteLine($"Student Last Name: {studentObjParam.GetterSetterLastName}");
                Console.WriteLine($"Student Grade: {studentObjParam.GetterSetterGrade}");

                // - * - * - * - * - * - * - * - * - * - * - * - * - * - * - * - * - * -
                Console.WriteLine();
                Console.WriteLine("- * - * - * - * - * - * - * - * -");
                Console.WriteLine();

                // Creating an object of Teacher Class
                Teacher teacherObj = new Teacher("Sheldon", "Cooper", "Physics");

                // Displaying the teacher information
                Console.WriteLine("The teacher details are as follows:");
                Console.WriteLine($"Teacher First Name: {teacherObj.GetterSetterFirstName}");
                Console.WriteLine($"Teacher Last Name: {teacherObj.GetterSetterLastName}");
                Console.WriteLine($"Teacher Subject: {teacherObj.TeacherSubject}");
                Console.WriteLine();

                // Displaying the teacher information to the console by calling a method from the Teacher class
                teacherObj.Teach();

                // - * - * - * - * - * - * - * - * - * - * - * - * - * - * - * - * - * -
                Console.WriteLine();
                Console.WriteLine("- * - * - * - * - * - * - * - * -");
                Console.WriteLine();

                // Creating a new student object of the modified Student class
                Student studentObjNew = new Student();

                // Setting values for attributes using properties
                studentObjNew.GetterSetterStudentId = 456;
                studentObjNew.GetterSetterFirstName = "Rachel";
                studentObjNew.GetterSetterLastName = "Green";
                studentObjNew.GetterSetterGrade = 78;

                // Displaying the student information to the console
                Console.WriteLine("The new student details are as follows:");

                Console.WriteLine($"Student ID: {studentObjNew.GetterSetterStudentId}");
                Console.WriteLine($"Student First Name: {studentObjNew.GetterSetterFirstName}");
                Console.WriteLine($"Student Last Name: {studentObjNew.GetterSetterLastName}");
                Console.WriteLine($"Student Grade: {studentObjNew.GetterSetterGrade}");

                Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadKey();
            }
        }
    }
}
