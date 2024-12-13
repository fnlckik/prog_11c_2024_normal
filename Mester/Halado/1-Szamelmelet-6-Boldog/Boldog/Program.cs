using System;

namespace Boldog
{
    internal class Program
    {
        static int Negyzetosszeg(int n)
        {
            string s = Convert.ToString(n);
            // s = "alma" s[0] == 'a', s[1] == 'l'
            // s = "135" s[0] == '1', s[1] == '3', s[2] == '5'
            int osszeg = 0;
            for (int i = 0; i < s.Length; i++)
            {
                int jegy = Convert.ToInt32(Convert.ToString(s[i]));
                osszeg += jegy * jegy;
            }
            return osszeg;
        }

        static int Negyzetosszeg2(int n)
        {
            // 61398 - %10 -> 8
            // 61398 - /10 -> 6139
            int osszeg = 0;
            while (n > 0)
            {
                int jegy = n % 10;
                osszeg += jegy * jegy;
                n = n / 10;
            }
            return osszeg;
        }

        static void Main(string[] args)
        {
            //Console.WriteLine(Negyzetosszeg(23)); // 13
            //Console.WriteLine(Negyzetosszeg(135)); // 35
            //Console.WriteLine(Negyzetosszeg(61398)); // 191

            //Console.WriteLine(BoldogE(23)); // true
            //Console.WriteLine(BoldogE(15)); // false
            //Console.WriteLine(BoldogE(18)); // false
            //Console.WriteLine(BoldogE(19)); // true
        }
    }
}
