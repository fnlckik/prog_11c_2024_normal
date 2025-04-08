using System;
using System.Collections.Generic;

namespace Szamok
{
    // long - Int64 (8 bájt), int - Int32 (4 bájt),
    // short - Int16 (2 bájt), byte (1 bájt, 256 féle)
    struct Kerdes
    {
        public string szoveg;
        public int valasz;
        public byte pontszam; // 1-től 3-ig

    }

    internal class Program
    {
        static void Main(string[] args)
        {
            List<Kerdes> kerdesek = new List<Kerdes>();
        }
    }
}
