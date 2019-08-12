using System;

namespace Opgave_7
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array1 = new int[] { 3, 3, 4, 4, 5, 5, 6, 6, 7 };


            int current = 0;
            foreach (int value in array1)
            {
                current ^= value;
            }

            Console.WriteLine(current);
            Console.ReadLine();
        }
    }
}
