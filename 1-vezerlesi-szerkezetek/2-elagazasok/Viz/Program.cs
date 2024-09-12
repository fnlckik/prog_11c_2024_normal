using System;

namespace Viz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Hőmérséklet: ");
            double homerseklet = Convert.ToDouble(Console.ReadLine());

            string halmazallapot;
            //if (homerseklet <= 0)
            //{
            //    halmazallapot = "szilárd";
            //}
            //else if (homerseklet <= 100)
            //{
            //    halmazallapot = "folyadék";
            //}
            //else
            //{
            //    halmazallapot = "gáz";
            //}
            if (homerseklet <= 0) halmazallapot = "szilárd";
            else if (homerseklet <= 100) halmazallapot = "folyadék";
            else halmazallapot = "gáz";

            Console.WriteLine($"A víz {halmazallapot} halmazállapotú.");

            Console.ReadKey();
        }
    }
}
