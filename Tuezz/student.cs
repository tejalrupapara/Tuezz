using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tuezz
{
    internal class student
    {
        int rlo;
        string name;
        int x;
        string y;

        public student()
        {
            rlo = 18;
            name = "tejal rupapara";
          
        }

        public void showdata()
        {
            Console.WriteLine("Roll no. is: " + rlo);
            Console.WriteLine("Name is: " + name);
        }

        internal class Democlass1
        {
          
            public static void Main(string[] args)
            {
                student s1 = new student();   // create object of student class
                s1.showdata();
               
                student s2 = new student();   // create object of student class
                s2.showdata();
                
                // call showdata() method
            }
        }
    }
}

