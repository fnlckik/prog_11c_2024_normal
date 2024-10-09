using System;

namespace Jegyek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            //int[] jegyek = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            int[] jegyek = new int[16];
            
            // Indexek: 0-tól 15-ig!
            // Jegyek generálása
            for (int i = 0; i < jegyek.Length; i++)
            {
                jegyek[i] = r.Next(1, 6);
            }

            // Jegyek kiírása
            for (int i = 0; i < jegyek.Length; i++)
            {
                Console.Write(jegyek[i] + " ");
            }

            Console.ReadKey();
        }
    }
}
