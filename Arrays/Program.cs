using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //manually populated array
            int[] numArray = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25 };

            //loop that displays the eleement number and value 
            for (int i = 0; i < numArray.Length; i++)
            {
                Console.WriteLine("Element Number: " + i + " -- Element Value: " + numArray[i]);
            }

        }
    }
}
