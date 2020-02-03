using System;
using System.Runtime.InteropServices;

namespace zajecia9
{
    class Program
    {
        static void Main(string[] args)
        {
//            int liczba = Convert.ToInt32(Console.ReadLine());
//            int wynik, resztaZDzielenia;
//            (wynik, resztaZDzielenia) = liczba.DzielenieZReszta(3);
//            Console.WriteLine($"{liczba}/3={wynik}r{resztaZDzielenia}");
            //metoda dla typu string ktora zliczy ile danej litery jest w tekscie
//            string cos = "alA ma kota";
//            Console.WriteLine(cos.ZliczLitery('a', true));
//            Console.WriteLine(cos.ZliczLitery('a', false));

            Reklama reklama = new Reklama("Kup teraz!", PrzedzialWiekowy.Dorosli | PrzedzialWiekowy.Mlodziez, Zainteresowania.Elektronika);
            reklama.Test();
            
            Reklama reklama2 = new Reklama("Kup teraz!", PrzedzialWiekowy.Dzieci | PrzedzialWiekowy.Mlodziez, Zainteresowania.Elektronika);
            reklama2.Test();
            Console.WriteLine(reklama2.przedzialWiekowy.czyDlaNiepelnoletnich());
        }
    }
}