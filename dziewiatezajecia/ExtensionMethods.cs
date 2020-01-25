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
}