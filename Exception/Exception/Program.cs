using System;

namespace Exception
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var arr = new int[3];

            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine(arr[i]);
            }

            Console.ReadKey();
        }
    }
}
