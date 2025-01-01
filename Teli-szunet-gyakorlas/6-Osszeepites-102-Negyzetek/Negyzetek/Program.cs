using System;

namespace Negyzetek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            while (n > 0)
            {
                int k = (int)Math.Sqrt(n);
                Console.Write(k + " ");
                n -= k * k;
            }
        }
    }
}
