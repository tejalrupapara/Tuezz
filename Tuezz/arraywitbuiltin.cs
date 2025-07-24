using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tuezz
{
    internal class arraywitbuiltin
    {
        static void Main(string[] args)
        {
            int[] a = { 1, 2, 36, 47, 83, 74 };

            Console.WriteLine("maximum number:" + a.Max());
            Console.WriteLine("minimum number:" + a.Min());
            var revrese = a.Reverse();
            Console.WriteLine("Reversed array:");
            foreach (int i in revrese)
            {
                Console.Write(i + " ");
            }


            Array.Sort(a);
            Console.Write("Sorted array:");
            foreach (int i in a)
            {
                Console.Write(i + " ");
            }
        }
    }
}
