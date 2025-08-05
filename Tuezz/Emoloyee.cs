using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tuezz
{
    public class EmployeeDemo {

        int empid;
        string ename;
        double esalary;
        public EmployeeDemo() 
        {
        }
        public void showdata(){
            Console.WriteLine("employee id id:" + empid);
            Console.WriteLine("emplooyee name:" + ename);
            Console.WriteLine("employee salary:" + esalary);
        }
    }
   internal class Emoloyee
   {
        public static void main(String[] args) { 
        EmployeeDemo emp = new EmployeeDemo();
            emp.showdata();
        }
   }
}


























































































































































