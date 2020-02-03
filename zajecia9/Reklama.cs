using System;

namespace zajecia9
{
    public class Reklama
    {
        public string Tekst;
        public PrzedzialWiekowy przedzialWiekowy;
        public Zainteresowania zainteresowania;


        public void Test()
        {
            if(przedzialWiekowy.HasFlag(PrzedzialWiekowy.Dzieci))
                Console.WriteLine("Reklama dla dzieci");
            
            if(przedzialWiekowy >= PrzedzialWiekowy.Dorosli)
                Console.WriteLine("Reklama dla doroslych");
        }
        public Reklama(string tekst, PrzedzialWiekowy przedzialWiekowy, Zainteresowania zainteresowania)
        {
            Tekst = tekst;
            this.przedzialWiekowy = przedzialWiekowy;
            this.zainteresowania = zainteresowania;
        }
    }
}