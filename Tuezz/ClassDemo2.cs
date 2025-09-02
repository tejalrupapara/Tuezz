using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tuezz
{
    public class Student1
    {
        int rlno;
        string name;
        string branch;
        static int sem = 5;
        int s1, s2, s3;
        double avg;


        public Student1(int rlno, string name, string branch, int s1, int s2, int s3)
        {
            this.rlno = rlno;
            this.name = name;
            this.branch = branch;
            this.s1 = s1;
            this.s2 = s2;
            this.s3 = s3;
        }
        public void calcAvg()
        {
            avg = (s1 + s2 + s3) / 3.0;
        }
        public double Avg
        {
            get { return avg; } //read only property
        }
        public void showDetail()
         { 
            Console.WriteLine("Roll No: " + rlno);
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Branch: " + branch);
            Console.WriteLine("Semester: " + sem);
         } 
    }
    internal class ClassDemo2
    {

        static void Main(string[] args)
        {
            Student1 s = new Student1(101, "Amit", "CSE", 78, 89, 90);
            s.calcAvg();
            Student1 s2 = new Student1(101, "Amit", "CSE", 78, 89, 90);
            s2.calcAvg();
           if (s.Avg > s2.Avg)
               s.showDetail();
            else
               s2.showDetail();

        }
    }
}
