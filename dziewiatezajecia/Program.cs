using System;
using System.Collections.Generic;
using System.Text;


namespace dziewiatezajecia
{
    

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