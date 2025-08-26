using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tuezz
{
    internal class DemoProject
    {
        //not required to be created any project
        class MathMethods {
            //only static data methods and static methods
            void Display() 
            { }
            static void Show() 
            { }
            //only mmethods or
            //not required to be created any project
        }
        class StudentDetails 
        {
            private StudentDetails() { }    
            static StudentDetails()
            {
                
            }

            // Normal (instance) constructor
            public StudentDetails()
            {
                
            }
        }
    }
        class staticClassDemo {

            public void Main(string[] args) {
            //trick-1
            //    1)you cannot ceate an object of a static class.



            MathMethods obj2=new MathMethods();
           
            //    2)you can call static method with class name
            MathMethods.Show(); // This will call the static method Show
            //3) you cannot call non static methods with class name
            MathMethods.Display(); // This will give an error because Display is not static 
            //Trick-2
            //  1)  you can not create an object with private constructor
                2)
                3)





            //to create object of cass
            //to call methods,constoructors,properties etc.
            //to asign values or calculate values for data members
            StudentDetails obj = new StudentDetails();
            StudentDetails.Display() { }
            StudentDetails.Show(){ } // This will call the static method Show

        }

           
            MathMethods obj2 = new MathMethods();


        }
    }

/*alternative:
 * A static class is functionally the same as creating a class with a private  constuructor.
 * An instance of class can never be created.
 * By using the static keyboard,the complier can help by checking the instane members are never acidentally added to the class.
 * If they are a compiler error happens.his can help garantee that an intance is never created*/