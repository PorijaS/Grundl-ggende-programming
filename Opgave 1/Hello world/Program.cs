using System;

namespace Hello_world
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Hvad er dit fornavn? : " );
            string fornavn = Console.ReadLine();
            Console.Clear();

            
            Console.Write("Hejsa " + fornavn + ", hvad er dit efternavn? : ");
            string efternavn = Console.ReadLine();
            Console.Clear();


            Console.WriteLine("Hvad er dit køn?: ");
            Console.WriteLine("\n");
            Console.WriteLine("Skriv M/m for mand eller K/k for kvinde. ");

            char køn = 'O';
            køn = char.Parse(Console.ReadLine().ToLower());

            string køn1 = "None";

            if (køn == 'm')
            {
                køn1 = "Mand";
            }
            else if(køn == 'k')
            {
                køn1 = "Kvinde";
            }
            else
            {
                køn1 = "Dit input er ugyldig.";
            }
            Console.Clear();


            Console.Write(fornavn + " " + efternavn + ", hvor gammel er du? : ");
            int alder = Convert.ToInt16(Console.ReadLine());
            Console.Clear();

            Console.Write("Hvor gammel mener du man skal være før man er gammel? : ");
            int gammel = Convert.ToInt16(Console.ReadLine());
            Console.Clear();
            int resultat;
            int gammelår;
            DateTime current = DateTime.Now;

            if (alder < gammel)
            {
                resultat = gammel - alder;
                gammelår = resultat + current.Year;
                Console.WriteLine("Der er " + resultat + " år til du bliver " + gammel + " År gammel, som er i år " + gammelår + ".");

            }
            else if (alder >= gammel)
            {
                Console.WriteLine("Du er en gammel " + køn1 + ".");
            }
            Console.ReadLine(); 
        }
    }
}
