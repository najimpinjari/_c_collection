using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //declaring and intialization in a single line 

            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, };
            Console.WriteLine(numbers[6]); //Accesesing Array Elemnt 
            numbers[2] = 22;
            Console.WriteLine(numbers[2]);
            int ArrayLenth  = numbers.Length;
            Console.WriteLine(ArrayLenth); //finding lenth 
            //declaring and then inialization 

            string[] frites;
            frites = new string[] { "Apple", "Banans", "Orenge" };
            Console.WriteLine(frites.Length); // Accessing Array lenth 

            //declaring with a spesific size 

            char[] charecters = new char[5];

            //Array Element can be accses using there indeces (starting from o )







           Console.ReadLine();
        }
    }
}
