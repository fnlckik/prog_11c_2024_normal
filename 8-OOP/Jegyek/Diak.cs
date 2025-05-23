﻿using System;
using System.Collections.Generic;

namespace Jegyek
{
    // Osztály: egységbe zárja az objektumok
    // 1. Adattagjait (field) - mező
    // 2. Műveleteit (method) - metódus
    class Diak
    {
        #region 1. Adattagok
        // public: mindenhol elérhető
        // private: csak az osztályon belül elérhető
        private string nev;
        private int kor;
        private double hangulat; // 0.00-1.00 százalékos érték
        private List<int> jegyek = new List<int>();
        #endregion

        #region 2. Konstruktorok
        // function overloading (függvény túlterhelés)
        // Ugyanazon névvel, más paraméterezéssel többféle függvény is készíthető
        public Diak() { }

        // this: az aktuális objektum példány
        public Diak(string nev, int kor, double hangulat)
        {
            this.nev = nev;
            this.kor = kor;
            this.hangulat = Math.Round(hangulat, 2);
            //Console.WriteLine("Létrejött az objektum egy példánya!");
        }
        #endregion

        #region 3. Getter, Setter (classic)
        public double GetHangulat()
        {
            return this.hangulat * 100;
        }

        public string GetNev()
        {
            return this.nev;
        }

        // setter esetén végezhetünk ellenőrzést a kapott paraméterre
        public void SetNev(string nev)
        {
            if (nev == "" || nev.Length > 20) return;
            this.nev = nev;
        }

        public int GetKor()
        {
            return this.kor;
        }
        #endregion

        #region 3. Getter, Setter (property)
        // Property
        public int Kor
        {
            get => this.kor;
        }

        // Arrow function (nyíl függvény)
        // x => x^2 (hozzárendelem az x^2-et)
        /*
        get
        {
            return this.nev;
        }
        */
        public string Nev
        {
            get => this.nev;

            set
            {
                if (value == "" || value.Length > 20) return;
                this.nev = value;
            }
        }

        /*
        get
        {
            return this.hangulat * 100;
        }
        */
        public double Hangulat
        {
            get => this.hangulat * 100;
        }

        /*
        List<int> jegyek = new List<int>();
        foreach (int jegy in this.jegyek)
        {
            jegyek.Add(jegy);
        }
        return jegyek;
        */
        // return new List<int>(this.jegyek);
        public List<int> Jegyek
        {
            get => new List<int>(this.jegyek);
        }
        #endregion

        #region 4. Metódusok
        public string Bemutatkozas()
        {
            return $"{this.nev} vagyok, {this.kor} éves.";
        }

        // override: felülírjuk az eredeti ToString() metódust
        public override string ToString()
        {
            return $"{this.nev} vagyok, {this.kor} éves.";
        }

        // n nap pihenés hatására a hangulat növekszik n*0.05-tel
        // Flatten your code (lapítsuk ki a kódot)
        // early return: egy szélsőséges eset lekezelése a metódus elején
        public void Pihen(int nap)
        {
            if (nap < 0) return;
            this.hangulat += nap * 0.05;
            if (this.hangulat > 1) this.hangulat = 1;
        }

        // Kiírja a diák jegyeit
        public void KiirJegyek()
        {
            Console.Write(this.nev + ": ");
            foreach (int jegy in this.jegyek)
            {
                Console.Write(jegy + " ");
            }
            Console.WriteLine();
        }

        // Ha nincs jegye: -
        // különben: az átlagot
        public string Atlag()
        {
            if (this.jegyek.Count == 0) return "-";
            int osszeg = 0;
            foreach (int jegy in this.jegyek)
            {
                osszeg += jegy;
            }
            double atlag = (double)osszeg / this.jegyek.Count;
            return Math.Round(atlag, 2).ToString();
        }

        public void JegyetKap(int jegy)
        {
            if (jegy < 1 || jegy > 5) return;
            this.jegyek.Add(jegy);
        }
        #endregion
    }
}
