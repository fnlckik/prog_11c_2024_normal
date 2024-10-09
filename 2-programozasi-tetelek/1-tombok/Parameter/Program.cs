using System;

namespace Parameter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(args.Length);
            Console.WriteLine("1. paraméter: " + args[0]);

            Console.ReadKey();
        }
    }
}
