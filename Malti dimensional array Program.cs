using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Malti_dimensional_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // multi dimensional array 

            int[,] numbers = new int[4, 4];

            for (int i = 0; i < 4; i++) 
            { 
                for(int j = 0; j < 4; j++)
                {
                    // Console.Write($"* ");
                    if (i == j)
                    {
                        Console.Write("*\t");
                    }
                    else
                    {
                        Console.Write("\t");

                    }
                }
                        
                Console.WriteLine();
            }





            Console.ReadLine();

        }
    }
}
