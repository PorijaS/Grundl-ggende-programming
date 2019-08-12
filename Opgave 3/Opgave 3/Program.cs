using System;

namespace Opgave_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vælg antal af terninger du vil kaste : ");
            int antalterninger;

            try
            {
                antalterninger = int.Parse(Console.ReadLine());
            }
            catch
            {
                antalterninger = 2;
            }

            int[] tern = new int[antalterninger];
            for (int i = 0; i < tern.Length; i++)
            {
                Random random = new Random();
                tern[i] = random.Next(1, 7);
            }
            bool alleRamtPerfekt = false;

            int antalForsøg = 0;

            while (alleRamtPerfekt == false)
            {
                antalForsøg++;

                for (int i = 0; i < tern.Length; i++)
                {
                    Random random = new Random();
                    tern[i] = random.Next(1, 7);
                }

                for (int i = 0; i < tern.Length; i++)
                {
                    if (tern[i] != 6)
                    {
         
                        alleRamtPerfekt = false;
                        break;
                    }

                    alleRamtPerfekt = true;
                }
            }
            Console.WriteLine("Det tog dig " + antalForsøg + " forsøg at slå rene sekser med " + antalterninger + " terninger");

        }
    }
}
