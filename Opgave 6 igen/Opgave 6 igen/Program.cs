using System;

namespace Opgave_6_igen
{
    class Program
    {
 
        static void Main(string[] args)
        {
            int[] arr = { 3, 8, 9, 7, 6 };
            int a = arr[arr.Length - 1];
            for (int i = arr.Length - 1; i > 0; i--)

            arr[i] = arr[i - 1];

            arr[0] = a;

            Console.Write("{0}", string.Join(",", arr));
            Console.ReadLine();

        }
    }
}
