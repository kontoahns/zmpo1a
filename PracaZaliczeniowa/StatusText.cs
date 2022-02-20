using System;

namespace PracaZaliczeniowa
{
    class StatusText
    {
        public string error(string text)
        {
            return text; //Funkcja zwracająca tekst w przypadku pojawienia się błędu
        }

        public string success(string text)
        {
            return text; //Funkcja zwracająca tekst w przypadku powodzenia operacji
        }
    }
}
