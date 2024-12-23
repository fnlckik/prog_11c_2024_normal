using System;

namespace Karacsonyfa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            int db = 1;
            int szokoz = 6; // első sorban 6 szóköz kell balra és jobbra
            Console.ForegroundColor = ConsoleColor.Green;
            for (int i = 1; i <= 7; i++)
            {
                // Az i. sor első szóközei
                for (int j = 0; j < szokoz; j++)
                {
                    Console.Write(" ");
                }
                // Az i. sor csillagai
                for (int j = 1; j <= db; j++)
                {
                    int p = r.Next(1, 101); // p: valószínűség
                    if (p <= 20)
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write("*");
                        Console.ForegroundColor = ConsoleColor.Green;
                    }
                    else if (p <= 40)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write("*");
                        Console.ForegroundColor = ConsoleColor.Green;
                    }
                    else
                    {
                        Console.Write("*");
                    }
                }
                // Az i. sor utolsó szóközök
                for (int j = 0; j < szokoz; j++)
                {
                    Console.Write(" ");
                }
                Console.WriteLine();
                db += 2;
                szokoz--;
            }
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
