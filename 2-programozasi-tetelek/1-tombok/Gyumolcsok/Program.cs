using System;

namespace Gyumolcsok
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] gyumolcsok = { "alma", "banán", "citrom", "mango" };
            // a)
            Console.WriteLine("Egyesével:");
            Console.WriteLine(gyumolcsok[0]);
            Console.WriteLine(gyumolcsok[1]);
            Console.WriteLine(gyumolcsok[2]);
            Console.WriteLine(gyumolcsok[3]);

            // b)
            Console.WriteLine();
            Console.WriteLine("Ciklussal:");
            for (int i = 0; i < gyumolcsok.Length; i++)
            {
                Console.WriteLine($"{i+1}. {gyumolcsok[i]}");
            }

            Console.ReadKey();
        }
    }
}
