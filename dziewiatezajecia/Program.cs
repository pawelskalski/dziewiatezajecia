using System;
using System.Collections.Generic;
using System.Text;


namespace dziewiatezajecia
{
    public static class ExtensionMethods
    {
        public static (int wynik, int reszta) DzielenieZReszta(this int liczba, int dzielnik)
        {
            return (liczba / dzielnik, liczba % dzielnik);
        }

        public static int ZliczLitery(this string tekst, char litera)
        {
            int count = 0;
            foreach (var liter in tekst.ToCharArray())
            {
                if (liter == litera)
                {
                    count -= -1;
                }
            }

            return count;
        }

        public static int ZliczLitery(this string tekst, string litera)
        {
            int count = 0;
            foreach (var liter in tekst.ToCharArray())
            {
                if (liter.ToString() == litera)
                {
                    count -= -1;
                }
            }

            return count;
        }

        public static int ZliczLitery(this string tekst, string litera, bool isCaseSensitive = true)
        {
            if (isCaseSensitive)
            {
                int count = 0;
                tekst = tekst.ToLower();

                foreach (var liter in tekst.ToCharArray())
                {
                    if (char.IsLetter(liter))
                    {
                        if (liter.ToString() == litera)
                        {
                            count -= -1;
                        }
                    }
                }

                return count;
            }
            else
            {
                return ZliczLitery(tekst, litera);
            }
        }

        public static bool czyDlaNiepelnoletnich(this PrzedialWiekowy przedial)
        {
            if (przedial > (PrzedialWiekowy) 18)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }

    public enum PrzedialWiekowy
    {
        Brak = 0,
        Dzieci = 12,
        Mlodziez = 18,
        Dorosli = 60,
        Starsi = 61
    }

    public enum Zainteresowania
    {
        Elektronika,
        Gaming,
        Ekonomia,
        Motoryzacja
    }

    public class Reklama
    {
        public string Tekst;
        public PrzedialWiekowy przedial;
        public Zainteresowania _zainteresowania;

        public Reklama(string tekst, PrzedialWiekowy przedial, Zainteresowania zainteresowania)
        {
            Tekst = tekst;
            this.przedial = przedial;
            _zainteresowania = zainteresowania;
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
//            Console.WriteLine("Podaj liczbe:");
//            int liczba = Convert.ToInt32(Console.ReadLine());
//            int wynik, resztaZDzielenia;
//            (wynik, resztaZDzielenia) = liczba.DzielenieZReszta(3);
//            Console.WriteLine($"{liczba}/3={wynik}r{resztaZDzielenia}");
//            
//            string tekst = "AlaMaKota";
//            Console.WriteLine(tekst.ZliczLitery("a"));
//            Console.WriteLine(tekst.ZliczLitery('a'));
//            Console.WriteLine(tekst.ZliczLitery("a", true));
            Reklama reklama = new Reklama("Kup teraz", (PrzedialWiekowy) 10, Zainteresowania.Ekonomia);
            Console.WriteLine(reklama.przedial.czyDlaNiepelnoletnich());
        }
    }
}