using System;

namespace Opgave_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j;
            Console.Write("Gange tabellen fra 1 til 10 \n"); 
            for (i = 1; i <= 10; i++) // her er variablen i = 1 og hvis i er  mindre eller det samme som 10, er dette sandt og hvis det er sandt så adder den 1 til i(1) så pluser.
            {
                for (j=1;j<=10;j++) //Her så giver vi j værdien 1 og siger hvis j er mindre eller det samme som n (Hvor n er det value som brugeren har givet) så er det sandt og derfor vil den adde 1 til j(1) så pluser
                {                   
                        Console.Write((i * j).ToString("00 ")); // denne linje der ganger den resultatet fra i og j sammen og printer svaret og efter så går den op igen og gøre det samme hvor den ganger de 2 tal fra i og j fordi den 1 adder en hver gang også printer den indtil man når til 10.
                }
                Console.Write("\n");
            }
        }
    }
}
