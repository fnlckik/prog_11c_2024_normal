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

            Console.WriteLine("Szópárok száma: " + magyarAngol.Count);

            Console.WriteLine("Macska angolul: " + magyarAngol["macska"]);
        }
    }
}
