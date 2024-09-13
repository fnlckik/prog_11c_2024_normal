using System;

namespace Szokoev
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            // int ev = r.Next(2002, 2024); // [2002..2023]
            int ev = r.Next(2001, 2025); // [2001..2024]

            //if (ev % 4 == 0)
            //{
            //    Console.WriteLine($"{ev} szökőév!");
            //}
            //else
            //{
            //    Console.WriteLine($"{ev} nem szökőév!");
            //}

            if (ev % 4 == 0) Console.WriteLine($"{ev} szökőév!");
            else Console.WriteLine($"{ev} nem szökőév!");
             
            Console.ReadKey();
        }
    }
}
