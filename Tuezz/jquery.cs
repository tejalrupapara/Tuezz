using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
/
namespace Tuezz
{
    internal class jquery
    {
         static void Main(String[] args)
         {
            int[][] jary = new int[4][];
            jary[0]= new int[4];
            jary[1]= new int[3];
            jary[2]= new int[2];
            jary[3]= new int[1];
            Console.WriteLine("enter jaged array elements:");
            for (int i = 0; i < jary.Length; i++) {
                for (int j = 0; j < jary[i].Length; j++)
                {
                    jary[i][j] = Convert.ToInt32(Console.ReadLine()); 
                }
                
            }
            Console.WriteLine("enter jagged aray:");
            for (int i = 0; i < jary.Length; i++)
            {
                for (int j = 0; j < jary[i].Length; j++)
                {
                    Console.WriteLine(jary[i][j]);
                }
                Console.WriteLine();

            }


        }
    }
}
