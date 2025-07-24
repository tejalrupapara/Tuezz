using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tuezz
{
    internal class Program3
    {
        static void Main(string[] args)
        {

            for (int i = 5; i >= 1; i--)
            { //according to no of rows
                for (int j = i; j >= 1; j--)
                { //according to no of columns

                    Console.Write("*");//dealing with printing
                }
                Console.WriteLine();


            }
        }
    }
}
