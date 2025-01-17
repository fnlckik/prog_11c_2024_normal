using System;
using System.Collections.Generic;

namespace Listak
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Tömb
            int[] tomb = new int[] { 3, 12, -7, 1, 5 };
            Kiir(tomb);

            string[] autok = { "Audi", "Nissan", "Honda", "Toyota" };
            Kiir(autok);

            Console.WriteLine();

            // Lista
            List<int> lista = new List<int> { 3, 12, -7, 1, 5 };
            Console.WriteLine($"Lista 1. eleme: {lista[0]}");
            Console.WriteLine($"Elemek száma: {lista.Count}");
            Print(lista);
            lista.Add(31);
            Console.WriteLine($"Elemek száma: {lista.Count}");
            Print(lista);

            List<string> cars = new List<string>();
            cars.Add("Audi");
            cars.Add("Nissan");
            cars.Add("Honda");
            cars.Add("Toyota");
            Print(cars);

            List<double> szamok = new List<double> { 4.5, 1.24, 6 };
            Console.WriteLine(Osszeg(lista));
            Console.WriteLine(Osszeg(szamok));

            //!Vigyázat Stringekből nem tudunk double elemet csinálni!
            //Console.WriteLine(Osszeg(cars));

            cars.Add("Honda");
            cars.Add("Honda");
            Print(cars);

            cars.Remove("Honda");
            Print(cars);
        }

        static double Osszeg<T>(List<T> lista)
        {
            double s = 0;
            foreach (T elem in lista)
            {
                s += Convert.ToDouble(elem);
            }
            return s;
        }

        // T: Template (sablon típust adunk a függvénynek)
        static void Print<T>(List<T> lista)
        {
            Console.Write("Lista elemei: ");
            foreach (T elem in lista)
            {
                Console.Write(elem + " ");
            }
            Console.WriteLine();
        }

        static void Kiir(List<string> lista)
        {
            Console.Write("Lista elemei: ");
            foreach (string elem in lista)
            {
                Console.Write(elem + " ");
            }
            Console.WriteLine();
        }

        static void Kiir(List<int> lista)
        {
            Console.Write("Lista elemei: ");
            /*
            for (int i = 0; i < lista.Count; i++)
            {
                Console.Write(lista[i] + " ");
            }
            */
            foreach (int elem in lista)
            {
                Console.Write(elem + " ");
            }
            Console.WriteLine();
        }

        //  Ezek más függvények (más a paraméterek sorrendje)
        static void f(int a, double b)
        {

        }

        static void f(double b, int a)
        {

        }

        // function overloading (függvény túlterhelés)
        static void Kiir(string[] autok)
        {
            Console.Write("Tömb elemei: ");
            foreach (string auto in autok)
            {
                Console.Write(auto + " ");
            }
            //for (int i = 0; i < autok.Length; i++)
            //{
            //    Console.Write($"{i+1}. {autok[i]}\t");
            //}
            Console.WriteLine();
        }

        static void Kiir(int[] tomb)
        {
            Console.Write("Tömb elemei: ");
            /*
            for (int i = 0; i < tomb.Length; i++)
            {
                Console.Write(tomb[i] + " ");
            }
            */
            foreach (int elem in tomb)
            {
                Console.Write(elem + " ");
            }
            Console.WriteLine();
        }
    }
}
