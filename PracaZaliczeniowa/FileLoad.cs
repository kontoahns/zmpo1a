using System;
using System.IO;

namespace PracaZaliczeniowa
{
    //Deklaracja klasy
    class FileLoad : LocalFile
    {
        string[] loadText; //Deklaracja zmiennej typu array

        //Funkcja zwracajaca wszystkie wpisy
        public void getAll()
        {
            loadText = File.ReadAllLines(fileName());
            foreach (string line in loadText)
            {
                Console.WriteLine(line);
            }
        }

        //Funkcja zwracajaca wszystkie wpisy w odwrotnej kolejnosci
        public void getAllReverse()
        {
            loadText = File.ReadAllLines(fileName());
            Array.Reverse(loadText);
            foreach (string line in loadText)
            {
                Console.WriteLine(line);
            }
        }

        //Funkcja zwracajaca wylosowany wpis
        public void getRandom()
        {
            loadText = File.ReadAllLines(fileName());
            if (loadText.Length > 0)
            {
                Random rnd = new Random();
                var rndNumber = rnd.Next(0, loadText.Length);

                for (var i =0; i < loadText.Length; i++)
                {
                    if (i == rndNumber)
                    {
                        Console.WriteLine(loadText[i]);
                    }
                }
            }
            else
            {
                Console.WriteLine("Brak dodanych elementow");
            }
        }

        //Funkcja zwracajaca ostatni wpis
        public void getLast()
        {
            loadText = File.ReadAllLines(fileName());
            if (loadText.Length > 0)
            {
                Console.WriteLine(loadText[loadText.Length - 1]);
            }
            else
            {
                Console.WriteLine("Brak dodanych elementow");
            }
        }

        //Funkcja czyszczaca plik
        public void unset()
        {
            int n = 0;
            loadText = File.ReadAllLines(fileName());
            while (n < loadText.Length)
            {
                Console.WriteLine(loadText[n] + " - Zostanie usunięty");
                n++;
            }
            File.WriteAllText(fileName(), string.Empty);
        }
    }
}
