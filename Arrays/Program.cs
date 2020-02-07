//Programmer: Rachel McNew
//Date: 2/6/2020
//Description: Create a C# console application that demonstrates arrays
using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //populate array automatically
            int[] numArray = new int[] { 101, 201, 301, 401, 501, 601, 701, 801, 901, 1001, 1101, 1201, 1301, 1401, 1501, 1601, 1701, 1801, 1901, 2001, 2101, 2201, 2301, 2401, 2501 };

            //Create loop that displays the element in value
            for (int i = 0; i < numArray.Length; i++)
            {
                Console.WriteLine("Element Number: " + i + " -- Element Value: " + numArray[i]);
            }

        }
    }
}
