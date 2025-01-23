using System;
using System.Collections.Generic;

namespace Jegyek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<List<int>> tanulok = new List<List<int>>();
            Beolvas(tanulok);
            Kiir(tanulok);
            Atlagok(tanulok);
        }

        // Írd ki a tanulók átlagait! 4,4 4,75 2 3,33 ...
        static void Atlagok(List<List<int>> tanulok)
        {
            
        }

        /*
            1. tanuló: 5 3 5 5 4
            2. tanuló: 5 5 4 5
            3. tanuló: 2 2 1 2 3
            4. tanuló: 3 5 2
            5. tanuló: 1 4 1 2 4 4 
        */
        static void Kiir(List<List<int>> tanulok)
        {
            // ???
        }

        static void Beolvas(List<List<int>> tanulok)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                List<int> tanulo = new List<int>(); // létrehoztunk egy üres listát
                string[] sor = Console.ReadLine().Split(' '); // {"5", "3", "5", "5", "4"}
                //for (int j = 0; j < sor.Length; j++)
                //{
                //    tanulo.Add(Convert.ToInt32(sor[j]));
                //}
                foreach (string jegy in sor)
                {
                    tanulo.Add(int.Parse(jegy));
                }
                tanulok.Add(tanulo);
            }
        }
    }
}
