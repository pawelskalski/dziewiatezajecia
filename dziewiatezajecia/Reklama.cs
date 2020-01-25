namespace dziewiatezajecia
{
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
}