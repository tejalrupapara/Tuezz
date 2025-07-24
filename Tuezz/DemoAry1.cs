using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tuezz
{
    internal class DemoAry1
    {
        
            //int[,] ary = new int[2, 1];
            //ary[0, 0] = 1;
            //ary[0, 1] = 2;
            //ary[0, 2] = 3;
            //ary[0, 3] = 4;

            //Console.WriteLine("fIRST ELEMENT:", ary[0, 0]);
public static void Main(string[] args)
        {
            int[,] ary = new int[3, 3];
            Console.WriteLine("Enter elemnt of 3x3 array:");
            for (int i = 0; i < ary.GetLength(0); i++)
            {
                for (int j = 0; j < ary.GetLength(1); j++)
                {
                    Console.Write("Enter element at position [{0},{1}]: ", i, j);
                    ary[i, j] = Int32.Parse(Console.ReadLine());
                }
            }

            //int[,] ary = { { 1, 2 }, { 3, 4 }, {5,6 } };
            for (int i = 0; i < ary.GetLength(0); i++)
            {
                for (int j = 0; j < ary.GetLength(1); j++)
                {
                    Console.Write(ary[i, j] + " ");
                }

            }

            //int[,] ary = new int[2, 2];
            //ary[0,0] = 1;
            //ary[0,1] = 2;
            //ary[1,0] = 3;
            //ary[1,1] = 4;

            //Console.WriteLine("Frist elemnt: " + ary[0,0]);
            //Console.WriteLine("Second elemnt: " + ary[0, 1]);
            //Console.WriteLine("Third elemnt: " + ary[1, 0]); 
            //Console.WriteLine("Fourth elemnt: " + ary[1, 1]);

        }
    }
}
