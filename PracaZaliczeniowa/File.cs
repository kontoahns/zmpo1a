using System;
using System.IO;

namespace PracaZaliczeniowa
{
    //Deklaracja klasy
    class LocalFile
    {
        protected const string FILE_DATABASE = "dbfile"; //Deklaracja stałej z nazwa pliku bazy danych

        //Konstruktor klasy
        public LocalFile()
        {
            createFile(); // Wywołanie funkcji odpowiadajacej za tworzenie pliku
        }

        //Funkcja odpowiadajaca za tworzenie pliku
        private void createFile()
        {
            try
            {
                //Warunek sprawdzajacy czy plik istnieje
                if (!File.Exists(FILE_DATABASE))
                {
                    //Tworzenie pliku
                    using (File.Create(FILE_DATABASE));
                }
            }
            catch (Exception error)
            {
                //Wypisanie błędu w przypadku niepowodzenia
                Console.WriteLine(error.Message);
            }
        }

        //Funkcja statyczna zwracajaca nazwe pliku
        public static string fileName()
        {
            return FILE_DATABASE;  //Zwracanie zdefiniowanej nazwy pliku
        }
    }
}
