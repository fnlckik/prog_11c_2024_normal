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
            string szerzo = Console.ReadLine();
            int szerzoDb = kiadas.SzerzoDarab(szerzo);
            Console.WriteLine($"{szerzoDb} könyvkiadás");

            // F3
            Console.WriteLine("3. feladat:");
            int maxPeldany = kiadas.maxPeldany();
            Console.WriteLine($"Legnagyobb példányszám: {maxPeldany}, előfordult ??? alkalommal");
        }
    }
}
