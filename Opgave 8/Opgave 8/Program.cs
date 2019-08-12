using System;

namespace Opgave_8
{
    class Program
    {
        static int points = 0;
        static Random rnd = new Random();
        public static void Main(string[] args)
        {

            int sværhedsgrad;
            Console.Write("\nVelkommen til regnespillet!" +
                "\n\nInstruktioner:  \nFørst så vælger du sværhedsgrad mellem 1 til 4." +
                "\nEfter så vælger du hvad du vil have af regnestykke f.eks plus, minus osv." +
                "\nOgså kan du for du lov til at skifte discplin efter hver regnestykke og hvor hver svar giver 1 point ud af 10." +
                "\n\nVælg hvad sværhedsgrad du vil have fra 1 til 4 : ");
            

            try
            {
                sværhedsgrad = int.Parse(Console.ReadLine());
            }
            catch
            {
                sværhedsgrad = 1;
            }

            if (sværhedsgrad == 1)
            {
                Console.Clear();
                Console.WriteLine("Du har valgt sværhedsgrad 1");
                svær1();
            }
            else if (sværhedsgrad == 2)
            {
                Console.Clear();
                Console.WriteLine("Du har valgt sværhedsgrad 2");
                svær2();
            }
            else if (sværhedsgrad == 3)
            {
                Console.Clear();
                Console.WriteLine("Du har valgt sværhedsgrad 3");
                svær3();
            }
            else if (sværhedsgrad == 4)
            {
                Console.Clear();
                Console.WriteLine("Du har valgt sværhedsgrad 4");
                svær4();
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Du har ikke valgt en gyldig sværhedsgrad, så den har valgt 1");
                svær1();
            }

        }

        static void svær1()
        {
            for (int i = 10; i > 0; i--)
            {
                int num1 = rnd.Next(1, 10);
                int num2 = rnd.Next(1, 10);
                string act1;
                Console.WriteLine("Vælg en af de har discipliner: '+' '-' '*' '/' " );
                act1 = Console.ReadLine();
                if (act1 == "+")
                {
                    Plus(num1, num2);
                }
                else if (act1 == "-")
                {
                    Minus(num1, num2);
                }
                else if (act1 == "*")
                {
                    Gange(num1, num2);
                }
                else if (act1 == "/")
                {
                    Divison(num1, num2);
                }
                else
                {

                }
            }
            Console.WriteLine("Du fik " + points + " ud af 10 korrekt" );
        }

        static void svær2()
        {
            for (int i = 10; i > 0; i--)
            {
                int num1 = rnd.Next(1, 50);
                int num2 = rnd.Next(1, 50);
                string act1;
                Console.WriteLine("Vælg en af de har discipliner: '+' '-' '*' '/' ");
                act1 = Console.ReadLine();
                if (act1 == "+")
                {
                    Plus(num1, num2);
                }
                else if (act1 == "-")
                {
                    Minus(num1, num2);
                }
                else if (act1 == "*")
                {
                    Gange(num1, num2);
                }
                else if (act1 == "/")
                {
                    Divison(num1, num2);
                }
                else
                {

                }
            }
            Console.WriteLine("Du fik " + points + " ud af 10 korrekt");
        }

        static void svær3()
        {
            for (int i = 10; i > 0; i--)
            {
                int num1 = rnd.Next(1, 100);
                int num2 = rnd.Next(1, 100);
                string act1;
                Console.WriteLine("Vælg en af de har discipliner: '+' '-' '*' '/' ");
                act1 = Console.ReadLine();
                if (act1 == "+")
                {
                    Plus(num1, num2);
                }
                else if (act1 == "-")
                {
                    Minus(num1, num2);
                }
                else if (act1 == "*")
                {
                    Gange(num1, num2);
                }
                else if (act1 == "/")
                {
                    Divison(num1, num2);
                }
                else
                {

                }
            }
            Console.WriteLine("Du fik " + points + " ud af 10 korrekt");
        }

        static void svær4()
        {
            for (int i = 10; i > 0; i--)
            {
                int num1 = rnd.Next(1, 150);
                int num2 = rnd.Next(1, 150);
                string act1;
                Console.WriteLine("Vælg en af de har discipliner: '+' '-' '*' '/' ");
                act1 = Console.ReadLine();
                if (act1 == "+")
                {
                    Plus(num1, num2);
                }
                else if (act1 == "-")
                {
                    Minus(num1, num2);
                }
                else if (act1 == "*")
                {
                    Gange(num1, num2);
                }
                else if (act1 == "/")
                {
                    Divison(num1, num2);
                }
                else
                {

                }
            }
            Console.WriteLine("Du fik " + points + " ud af 10 korrekt");
        }


        static int Plus(int num1, int num2)
        {
            int svar = num1 + num2;
            Console.Write(num1 + " + " + num2 + " = " );
            int ssvar = 0;
            try
            {
                ssvar = int.Parse(Console.ReadLine());   
            }
            catch
            {
                ssvar = 0;
            }
            if (ssvar == svar)
            {
                Console.WriteLine("Korrekt");
                points += 1;
            }
            else
            {
                Console.WriteLine("Forkert");
                Console.WriteLine("svaret er: " + (num1 + num2));
            }
            return ssvar + svar;
        }

        static int Minus(int num1, int num2)
        {
            int svar = num1 - num2;
            Console.Write(num1 + " - " + num2 + " = ");
            int ssvar = 0;
            try
            {
                ssvar = int.Parse(Console.ReadLine());
            }
            catch
            {
                ssvar = 0;
            }
            if (ssvar == svar)
            {
                Console.WriteLine("Korrekt");
                points += 1;
            }
            else
            {
                Console.WriteLine("Forkert");
                Console.WriteLine("svaret er: " + (num1 - num2));
            }
            return ssvar + svar;
        }

        static int Gange(int num1, int num2)
        {
            int svar = num1 * num2;
            Console.Write(num1 + " * " + num2 + " = ");
            int ssvar = 0;
            try
            {
                ssvar = int.Parse(Console.ReadLine());
            }
            catch
            {
                ssvar = 0;
            }
            if (ssvar == svar)
            {
                Console.WriteLine("Korrekt");
                points += 1;
            }
            else
            {
                Console.WriteLine("Forkert");
                Console.WriteLine("svaret er: " + (num1 * num2));
            }
            return ssvar + svar;
        }

        static int Divison(int num1, int num2)
        {
            int svar = num1 / num2;
            Console.Write(num1 + " / " + num2 + " = ");
            int ssvar = 0;
            try
            {
                ssvar = int.Parse(Console.ReadLine());
            }
            catch
            {
                ssvar = 0;
            }
            if (ssvar == svar)
            {
                Console.WriteLine("Korrekt");
                points += 1;
            }
            else
            {
                Console.WriteLine("Forkert");
                Console.WriteLine("svaret er: " + (num1 / num2));
            }
            return ssvar + svar;
        }

    }
}