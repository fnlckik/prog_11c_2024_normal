using System;

namespace konyvek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // F1
            Kiadas kiadas = new Kiadas("kiadas.txt");
            //Console.WriteLine(kiadas.Konyvek.Count);

            // F2
            //Console.WriteLine(kiadas.Konyvek[0].SzerzoE("Benedek Elek")); // false
            //Console.WriteLine(kiadas.Konyvek[0].SzerzoE("Szobonya Erzsébet")); // true
            Console.WriteLine("2. feladat:");
            Console.Write("Szerző: ");
            string szerzo = "Benedek Elek"; //Console.ReadLine();
            int szerzoDb = kiadas.SzerzoDarab(szerzo);
            Console.WriteLine($"{szerzoDb} könyvkiadás");

            // F3
            Console.WriteLine("3. feladat:");
            Tuple<int, int> max = kiadas.MaxPeldanyDarab();
            //int maxDb = kiadas.Hanyszor(maxPeldany);
            Console.WriteLine($"Legnagyobb példányszám: {max.Item1}, előfordult {max.Item2} alkalommal");

            // F4
            Console.WriteLine("4. feladat:");
            Konyv nepszeru = kiadas.NepszeruKulfoldi(40000);
            Console.WriteLine(nepszeru); // ToString() kéne

            // F5
            Console.WriteLine("5. feladat:");
            kiadas.KiirStatisztika();
        }
    }
}
