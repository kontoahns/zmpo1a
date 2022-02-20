using System;

namespace PracaZaliczeniowa
{
    //Deklracja klasy 
    class Properties
    {
        protected string name; //Deklaracja chronionej zmiennej name typu string

        //Konstruktor klasy przyjmujący 1 parametr i zapisuje do zmiennej
        public Properties(string programName)
        {
            name = programName; //Przypisanie wartosci do zmiennej lokalnej
        }

        //Funkcja publiczna zwracająca zmienna name
        public string getName()
        {
            return "\n" + name + "\n";
        }

    }
}
