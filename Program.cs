using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // decalaring arry first way 
            // declaring and initialization of an array 

            int[] numbers = new int[5];

            // decalaring an array of inteer with a length of 5 

            // assending values to the array elements 
            numbers[0] = 10;
            numbers[1] = 20;
            numbers[2] = 30;
            numbers[3] = 40;
            numbers[4] = 50;


            // printing array elements 

            for(int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine("elements of index " + i+ ";" + numbers[i]);
            }


            // declaring array second way 

            string[] names = new string[]
            {"ajay", "ganesh","vishal","kamlesh"};

            Console.WriteLine($"numbers of names :  {names.Length}");

            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine(names[i]);
            }

            //reverce array 

            int[] num = new int[] { 4, 6, 2, 8, 2, 4 };

            // reverce arry output wiil be {4,,2,8,2,6,,4 }
            Console.WriteLine("Original items ");

                for (int i = 0;i < num.Length; i++)
            {
                Console.Write($"{num[i] }");
            }

            Console.WriteLine("\n Reverce Array ");
            for (int i = num.Length - 1; i>=0; i--)
            {
                Console.WriteLine(num[i]);
            }

            // find highest number using array and loops 


            int[] numbers1 = new int[] { 12, 34, 34, 65, 2, 7, 45, 78, 09 };
            int highest = 0;

            for (int i = 0; i < numbers.Length;i++) 
            {
                for (int j = 1+ 1; j < numbers.Length; j++)
                {
                    if (numbers1    )
                }
            }





        }
    }
}
