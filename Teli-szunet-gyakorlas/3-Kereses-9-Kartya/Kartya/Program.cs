using System;

namespace Kartya
{
    internal class Program
    {
        static void Beolvas(char[] szinek, char[] ertekek)
        {
            for (int i = 0; i < szinek.Length; i++)
            {
                string[] sor = Console.ReadLine().Split(' ');
                szinek[i] = Convert.ToChar(sor[0]);
                ertekek[i] = Convert.ToChar(sor[1]);
            }
        }

        static int Keres(char[] szinek)
        {
            int i = 0;
            while (i < szinek.Length - 1 && !(szinek[i] == szinek[i+1]))
            {
                i++;
            }
            if (i < szinek.Length - 1)
            {
                return i+1;
            }
            else
            {
                return 0;
            }
        }

        static void Main(string[] args)
        {
            char[] szinek = new char[32];
            char[] ertekek = new char[32];
            Beolvas(szinek, ertekek);
            int azonos = Keres(szinek);
            Console.WriteLine(azonos);
        }
    }
}
