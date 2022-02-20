using System;

namespace PracaZaliczeniowa
{
    class Program
    {
        static void Main(string[] args)
        {
            Author author = new Author("Łukasz", "Gniwek"); //Zmienna typu Author
            Copyright copyright = new Copyright(author, IndexNumber.getIndexNumber()); //Zmienna typu Copyright
            Properties properties = new Properties("Baza filmów"); //Zmienna typu Properties
            Menu menu = new Menu(); //Zmienna typu Menu
            Actions action = new Actions(); //Zmienna typu Actions

            Console.WriteLine(copyright.getCopyright()); //Wyswietlenie tekstu z funkcji na ekranie
            Console.WriteLine(properties.getName()); //Wyswietlenie tekstu z funkcji na ekranie

            //Petla wykonujaca sie do czasu wprowadzenia na klawiaturze przycisku 7
            do
            {
                Console.WriteLine(menu.show()); //Wyswietlenie tekstu z funkcji na ekranie
                Console.WriteLine(menu.textToSelect()); //Wyswietlenie tekstu z funkcji na ekranie
                menu.tmpMenu = Console.ReadLine(); //Odczytanie wprowadzonego tekstu i zapis do zmiennej

                //Warunek sprawdzajacy czy wprowadzony tekst jest liczba
                if (int.TryParse(menu.tmpMenu, out menu.menuNumber))
                {
                    action.setAction(menu.getNumber());
                    Console.WriteLine(action.doAction()); //Wyswietlenie tekstu z funkcji na ekranie
                } else {
                    Console.ForegroundColor = ConsoleColor.Red; //Zmiana koloru tekstu
                    Console.WriteLine(menu.textBadNumber()); //Wyswietlenie tekstu z funkcji na ekranie
                    Console.ResetColor(); //Restart koloru do wersji domyslnej
                }

            } while (menu.getNumber() != 7);

        }

    }
}
