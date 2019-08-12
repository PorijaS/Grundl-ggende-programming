using System;

namespace Opgave_4
{
    class Program
    {
        static bool afslut = false;

        static bool brugSidsteResultat = false;
        static bool harSidsteResultat = false;
        static double sidsteResultat = 0;

        static void Main(string[] args)
        {
            while (afslut == false)
            {
                double num1 = 0;
                double num2 = 0;
                double answer = 0;
                double answer2 = 0;

                if (harSidsteResultat == true)
                {
                    Console.WriteLine("Du har regnet før, vil du bruge dit sidste regnestykke?");
                    Console.WriteLine("y/Y = Ja | n/N = Nej");

                    string svar = Console.ReadLine().ToLower();

                    if (svar == "y") 
                    {
                        brugSidsteResultat = true;
                    }
                    else
                    {
                        brugSidsteResultat = false;
                    }
                }

                Console.WriteLine("Lommeregner\r");
                Console.WriteLine("-------------------------\n");

                Console.WriteLine("Indtast et nummer og tryk enter");
                num1 = Convert.ToDouble(Console.ReadLine());

                if (brugSidsteResultat == true)
                {
                    num2 = sidsteResultat;
                }
                else
                {
                    Console.WriteLine("Indtast et andet nummer og tryk enter igen");
                    num2 = Convert.ToDouble(Console.ReadLine());
                }

                Console.WriteLine("Vælg hvad du vil gøre fra listen");

                Console.WriteLine("\t+ - Plus");
                Console.WriteLine("\t- - Minus");
                Console.WriteLine("\t* - Gange");
                Console.WriteLine("\t/ - Divider");
                Console.WriteLine("\ta - Afslut");
                Console.WriteLine("Vælg hvad du vil gøre");

                switch (Console.ReadLine().ToLower())
                {
                    case "+":
                        Console.WriteLine($"Resultat: ");

                        if (harSidsteResultat == true)
                        {
                            answer = (num2 + num1);
                        }
                        else
                        {
                            answer = (num1 + num2);
                        }

                        harSidsteResultat = true;
                        sidsteResultat = answer;

                        Console.WriteLine(answer);
                        break;

                    case "-":
                        Console.WriteLine($"Resultat: ");

                        if (harSidsteResultat == true)
                        {
                            answer = (num2 - num1);
                        }
                        else
                        {
                            answer = (num1 - num2);
                        }

                        harSidsteResultat = true;
                        sidsteResultat = answer;

                        Console.WriteLine(answer);
                        break;

                    case "*":
                        Console.WriteLine($"Resultat: ");

                        if (harSidsteResultat == true)
                        {
                            answer = (num2 * num1);
                        }
                        else
                        {
                            answer = (num1 * num2);
                        }

                        harSidsteResultat = true;
                        sidsteResultat = answer;

                        Console.WriteLine(answer);
                        break;

                    case "/":
                        Console.WriteLine($"Resultat: ");

                        if (harSidsteResultat == true)
                        {
                            answer = (num2 / num1);
                        }
                        else
                        {
                            answer = (num1 / num2);
                        }

                        harSidsteResultat = true;
                        sidsteResultat = answer;

                        Console.WriteLine(answer);
                        break;

                    case "a":
                        afslut = true;
                        break;

                }

                Console.WriteLine("Regn videre...");
                Console.WriteLine(answer);
            }
        }
    }
}


        