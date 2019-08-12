using System;

namespace Opgave_5
{
    class Program
    {
        public static int FrøHop(int X, int Y, int D)
        {
            if ((Y-X) % D==0)
            {
                return (Y - X) / D;
            }
            return (Y - X) / D + 1;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(FrøHop(10, 85, 30));
        }
    }
}
