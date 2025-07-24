using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tuezz
{
    internal class swapmethod
    {
        static void swap(int a,int b) {
            int temp = a;
            a = b;
            b = temp;
        }
        static void Main()
        {
            int a = 10,b= 20;
            Console.WriteLine("before swap: a={0} and b={1}", a, b);
            swap(a, b);
            Console.WriteLine("after swap: a={0} and b={1}", a, b);


        }
    }
}
