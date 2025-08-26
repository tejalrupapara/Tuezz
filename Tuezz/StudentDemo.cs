using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tuezz
{

namespace StudentDemo
    {
        class Student
        {
          
            private int enrolmentNo;
            private string name;

            public int EnrolmentNo
            {
                get { return enrolmentNo; }
                set { enrolmentNo = value; }
            }

            public string Name
            {
                get { return name; }
                set { name = value; }
            }

            public Student()
            {
                enrolmentNo = 0;
                name = "Unknown";
            }

         
            public Student(int enrolmentNo, string name)
            {
                this.enrolmentNo = enrolmentNo;
                this.name = name;
            }


            public void DisplayInfo()
            {
                Console.WriteLine("Enrolment No: " + EnrolmentNo);
                Console.WriteLine("Name: " + Name);
                Console.WriteLine("------------------------");
            }
        }

        class Program
        {
            static void Main(string[] args)
            {
             
                Student student1 = new Student();
                student1.EnrolmentNo = 101;
                student1.Name = "Tejal";
                student1.DisplayInfo();

                Student student2 = new Student(102, "Dhruv");
                student2.DisplayInfo();


                Student[] students = new Student[3];
                students[0] = new Student(103, "Prinsal");
                students[1] = new Student(104, "Trushali");
                students[2] = new Student(105, "Yashudi");

                foreach (Student s in students)
                {
                    s.DisplayInfo();
                }

                Console.ReadLine();
            }
        }
    
}
}
