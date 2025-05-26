using System;
using System.Collections.Generic;
using System.IO;

namespace Filmek
{
    public class Televizio
    {
        private List<Film> filmek;

        public Televizio(string fajlnev)
        {
            this.filmek = new List<Film>();
            StreamReader sr = new StreamReader(fajlnev);
            while (!sr.EndOfStream)
            {
                string sor = sr.ReadLine();
                Film film = new Film(sor);
                this.filmek.Add(film);
            }
            sr.Close();
        }

        public override string ToString()
        {
            string s = "";
            foreach (Film film in this.filmek)
            {
                s += film + "\n";
            }
            return s;
        }

        public Film Legregebbi()
        {
            Film legregebbi = filmek[0];
            foreach (Film film in filmek)
            {
                // film < legregebbi
                if (film.KorabbiE(legregebbi))
                {
                    legregebbi = film;
                }
            }
            return legregebbi;
        }

        // Buborékos (filmek <=> this.filmek)
        private void Rendez()
        {
            // Hány elem van jó helyen? (i)
            for (int i = 0; i < filmek.Count; i++)
            {
                // Hányat kell még megnézni? (maradék)
                for (int j = 0; j < filmek.Count - 1 - i; j++)
                {
                    // j, j+1 rossz sorrendben van
                    if (filmek[j].Imdb < filmek[j+1].Imdb)
                    {
                        (filmek[j], filmek[j + 1]) = (filmek[j + 1], filmek[j]);
                    }
                }
            }
        }

        public void Kiir(string fajl, int db)
        {
            this.Rendez(); // vagy Rendez()
        }
    }
}
