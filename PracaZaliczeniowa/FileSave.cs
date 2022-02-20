using System;
using System.IO;
using System.Text;

namespace PracaZaliczeniowa
{
    //Deklaracja klasy
    class FileSave : LocalFile
    {
        //Funkcja odpowiadajaca za zapis zmiennej do pliku
        public void save(string textToSave)
        {
            if (File.Exists(fileName()))
            {
                using (TextWriter tw = new StreamWriter(fileName(), append: true, Encoding.ASCII))
                {
                    tw.WriteLine(textToSave); //Zapisanie tekstu do pliku w nowej linii
                }
            }
        }
    }
}
