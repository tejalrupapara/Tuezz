using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tuezz
{
    internal class pattern2
    {
        public static void Main(string[] args)
        {
            int totalRows = 7;
            int[][] jagged = new int[totalRows][];

            for (int i = 0; i < totalRows; i++)
            {
                int size;
                if (i <= 3)
                    size = i + 1;
                else
                    size = totalRows - i;

                jagged[i] = new int[size];

                for (int j = 0; j < size; j++)
                {
                    jagged[i][j] = j + 1;
                }
            }
            Console.WriteLine("Pattern using jagged array:");
            for (int i = 0; i < jagged.Length; i++)
            {
                for (int j = 0; j < jagged[i].Length; j++)
                {
                    Console.Write(jagged[i][j]);
                }
                Console.WriteLine();
            }
        }
    }
}