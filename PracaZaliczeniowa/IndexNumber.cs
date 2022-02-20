using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracaZaliczeniowa
{
    //Deklaracja klasy statycznej
    static class IndexNumber
    {
        private const int INDEX_NUMBER = 18590; //Deklaracja stałej z numerem indeksu autora

        public static int getIndexNumber()
        {
            return INDEX_NUMBER; //Funkcja zwracająca numer indeksu autora
        }

    }
}
