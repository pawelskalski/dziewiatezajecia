using System.Runtime.Serialization.Formatters;

namespace zajecia9
{
    public static class ExtensionMethods
    {
        public static (int, int) DzielenieZReszta(this int liczba, int dzielnik)
        {
            return (liczba / dzielnik, liczba % dzielnik);
        }

        public static int ZliczLitery(this string tekst, char litera)
        {
            int licznik = 0;
            for (int i = 0; i < tekst.Length; i++)
            {
                if (tekst[i] == litera)
                    licznik++;
            }

            return licznik;
        }
        public static int ZliczLitery(this string tekst, char litera, bool caseInsensitive)
        {
            int licznik = 0;

            if (char.IsLetter(litera) && caseInsensitive)
            {
                licznik += tekst.ZliczLitery(char.ToUpper(litera));
                licznik += tekst.ZliczLitery(char.ToLower(litera));
            }
            else licznik = tekst.ZliczLitery(litera);
            
            return licznik;
        }

        public static bool czyDlaNiepelnoletnich(this PrzedzialWiekowy przedzialWiekowy)
        { return przedzialWiekowy.HasFlag(PrzedzialWiekowy.Dzieci) || przedzialWiekowy.HasFlag(PrzedzialWiekowy.Mlodziez); }
    }
}