using System;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            var array = new int[5] { 1, 2, 3, 4, 5 };
            //int[] array = new int[5];

            //Console.WriteLine(array[0]);

            //Console.WriteLine(array[0]);

            /*for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }*/

            foreach(int num in array)
            {
                Console.WriteLine(num); 
            }

            Console.ReadKey();
        }
    }
}
