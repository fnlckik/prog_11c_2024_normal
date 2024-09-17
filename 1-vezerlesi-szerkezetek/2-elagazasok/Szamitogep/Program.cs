using System;

namespace Szamitogep
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // a)
            Random r = new Random();
            int ar = r.Next(230, 371);
            ar = ar * 1000; // ar *= 1000;
            Console.WriteLine($"Sorsolt ár: {ar}");

            // b) => c)
            Console.Write("Add meg, hogy mennyi pénzt tettél félre: ");
            int penz = Convert.ToInt32(Console.ReadLine());

            if (penz >= ar)
            {
                Console.WriteLine("Sikeres a gyűjtés!");
            }
            else
            {
                double szazalek = (double) penz / ar * 100;
                Console.WriteLine($"A pénz {(int) szazalek}%-a van meg!");
            }

            Console.ReadKey();
        }
    }
}
