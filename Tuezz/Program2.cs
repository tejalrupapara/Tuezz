using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tuezz
{
    internal class Program2
    {
        public static void Main(String[] args) {
           int a = 5;
           int b= 5;
            int c = a++ + b++ + b++ + a++;
            Console.WriteLine(c);
        }
    }
}






