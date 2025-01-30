using System;
using System.Collections.Generic;

namespace Szotar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // szótár ~ Dictionary ~ Map ~ asszociatív tömb (asszociáció = képzettársítás)
            // szótár: kulcs-érték párokból áll (kulcs egyedi)
            Dictionary<string, string> magyarAngol = new Dictionary<string, string>();
            magyarAngol.Add("kutya", "dog");
            magyarAngol.Add("macska", "cat");
            magyarAngol.Add("oroszlán", "lion");
            magyarAngol.Add("alma", "apple");
            magyarAngol.Add("elefánt", "elephant");
            //magyarAngol.Add("kutya", "hound"); // HIBA!!! Nem egyedi kulcs!
            //magyarAngol.Add("auto", "car");
            //magyarAngol.Add("kocsi", "car");

            magyarAngol.Remove("alma");

            Console.WriteLine("Szópárok száma: " + magyarAngol.Count);

            Console.WriteLine("Macska angolul: " + magyarAngol["macska"]);

            // Hiba!
            //Console.WriteLine("Egér angolul: " + magyarAngol["egér"]);
            Console.WriteLine("Az egér szót tudjuk-e angolul? " + magyarAngol.ContainsKey("egér")); // false
            Console.WriteLine("A lion szót tudjuk-e magyarul? " + magyarAngol.ContainsValue("lion")); // true

            Kiir(magyarAngol);

            // -----------------------------------------
            Console.Clear();

            // Egy tálban a következő gyümölcsök vannak:
            List<string> gyumolcsok = new List<string> { "narancs", "alma", "körte", 
                                                         "alma", "narancs", "alma", 
                                                         "alma", "szilva", "narancs" };
            // Melyik gyümölcsből van a legtöbb?
            Dictionary<string, int> mennyisegek = new Dictionary<string, int>();
            Megszamol(gyumolcsok, mennyisegek);
        }

        static void Megszamol(List<string> gyumolcsok, Dictionary<string, int> mennyisegek)
        {
            foreach (string gyumolcs in gyumolcsok)
            {
                if (mennyisegek.ContainsKey(gyumolcs))
                {
                    mennyisegek[gyumolcs]++;
                }
                else
                {
                    mennyisegek.Add(gyumolcs, 1);
                }
            }
        }

        static void Kiir(Dictionary<string, string> szotar)
        {
            Console.WriteLine("\nMagyar - Angol szótár:");
            // Dictionary<string, string>.KeyCollection kulcsok = szotar.Keys;
            foreach (string kulcs in szotar.Keys)
            {
                Console.WriteLine(kulcs + " - " + szotar[kulcs]);
            }
        }
    }
}
