using System;

namespace PracaZaliczeniowa
{
    //Deklaracja klasy
    class Copyright : CopyMark
    {
        private readonly Author authorData; //Zmienna deklarująca klase autora pracy
        private readonly int indexNumber; //Zmienna deklarująca numer indeksu autora pracy

        //Konstruktor klasy przyjmujący 2 parametry i zapisujący je do zmiennej
        public Copyright(Author author, int number)
        {
            authorData = author;
            indexNumber = number;
        }

        //Funkcja publiczna zwracająca imie i nazwisko autora wraz z znakiem oraz datą
        public string getCopyright()
        {
            return copyMark + " " + authorData.getFirstName() + " " + authorData.getLastName() + ", " + indexNumber; 
        }

    }
}
