using System;

namespace Gyongy_29
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Beolvasas
            int n = int.Parse(Console.ReadLine());
            string s = Console.ReadLine();

            // Feldolgozas
            int db = 1;
            //Console.WriteLine(db + " " + s[0]);
            int maxe = 1;
            char c = s[0];
            for (int i = 1; i < n; i++)
            {
                if (s[i] == s[i-1]) db++;
                else db = 1;
                if (db > maxe)
                {
                    maxe = db;
                    c = s[i];
                }
                //Console.WriteLine(db + " " + s[i]);
            }

            int j = 0;
            while (j < s.Length && !(s[j] != s[s.Length-1]))
            {
                j++;
            }
            db += j;
            if (db > n) db = n;

            if (db > maxe)
            {
                maxe = db;
                c = s[0];
            }

            // Kiiras
            Console.WriteLine(maxe);
            Console.WriteLine(c);
        }
    }
}
