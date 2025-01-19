using System;
using System.Collections.Generic;

namespace Dijazottak
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // példányosítás
            List<string> nevek = new List<string>();
            List<int> pontok = new List<int>();
            int n;
            int maxpont;
            Beolvas(nevek, pontok, out n, out maxpont);
        }

        static void Beolvas(List<string> nevek, List<int> pontok, out int n, out int maxpont)
        {
            // List<string> sor = new List<string>(Console.ReadLine().Split(' '));
            string[] sor = Console.ReadLine().Split(' ');
            //n = Convert.ToInt32(sor[0]);
            //maxpont = Convert.ToInt32(sor[1]);
            n = int.Parse(sor[0]); // "6" => 6
            maxpont = int.Parse(sor[1]);
        }
    }
}
