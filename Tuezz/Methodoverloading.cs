using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tuezz
{
    internal class method_overloding
    {
        class Student
        {
            private string firstName;
            private string lastName;

            public string GetFirstName()
            {
                return firstName;
            }

            public string GetLastName()
            {
                return lastName;
            }

            public void SetName(string first)
            {
                firstName = first;
            }

            public void SetName(string first, string last)
            {
                firstName = first;
                lastName = last;
            }

            public void Display()
            {
                Console.WriteLine("First Name: " + firstName);
                Console.WriteLine("Last Name: " + lastName);
            }
        }

        static void Main(string[] args)
        {
            Student s1 = new Student();
            Student s2 = new Student();

            s1.SetName("Tejal","Rupapara");
            s2.SetName("Prinsal", "Kotadiya");

            Console.WriteLine("Student 1:");
            s1.Display();

            Console.WriteLine("\nStudent 2:");
            s2.Display();
        }
    }
}
