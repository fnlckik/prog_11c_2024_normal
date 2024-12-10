using System;

namespace Eljarasok
{
    internal class Program
    {
        static void Kiir(string s)
        {
            Random r = new Random();
            int n = r.Next(3, 10); // 3-tól 10-ig
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(s);
            }
        }

        static void Beolvas(out int n)
        {
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Függvényen belül: " + n);
        }

        // ref: cím szerinti paraméter átadás
        static void Duplaz(ref int a)
        {
            if (a % 2 != 0)
            {
                a *= 2;
            }
        }

        static void Teglalap(int x, int y, out int t, out int k)
        {
            k = 2 * (x + y);
            t = x * y;
        }
        
        static void Novel(int[] t)
        {
            for (int i = 0; i < t.Length; i++)
            {
                t[i] = t[i] + 1;
            }
        }

        static void Kiir(int[] t)
        {
            for (int i = 0; i < t.Length; i++)
            {
                Console.Write(t[i] + " ");
            }
        }

        static void f(int[] t)
        {
            t[0] = 2024;
        }

        static void Main(string[] args)
        {
            Kiir("kifli");

            Beolvas(out int n);
            Console.WriteLine("Függvény után: " + n);

            int a = 7;
            Duplaz(ref a); // 7 => 14; 12 => 12
            Console.WriteLine("Új 'a' érték: " + a);

            int x = 5; int y = 7;
            Teglalap(x, y, out int t, out int k);
            Console.WriteLine("Kerület: " + k);
            Console.WriteLine("Terület: " + t);

            int[] tomb = { 5, 7, -3 };
            f(tomb); // {2024, 7, -3};
            Novel(tomb);
            Kiir(tomb);
        }
    }
}
