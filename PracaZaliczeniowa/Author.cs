using System;

namespace PracaZaliczeniowa
{
    //Deklaracja klasy
    class Author : IAuthor
    {
        private string firstName; //Deklaracja zmiennej
        private string lastName; //Deklaracja zmiennej

        public Author(string name, string surname)
        {
            firstName = name; //Przypisanie imienia do zmiennej
            lastName = surname; //Przypisanie nazwiska do zmiennej
        }

        string IAuthor.firstName { 
            get => throw new NotImplementedException(); 
            set => throw new NotImplementedException();
        } //Zmienna deklarująca imie autora pracy z wykorzystaniem interfejsu

        string IAuthor.lastName { 
            get => throw new NotImplementedException(); 
            set => throw new NotImplementedException();
        } //Zmienna deklarująca nazwisko autora pracy z wykorzystaniem interfejsu

        public string getFirstName()
        {
            return firstName; //Funkcja publiczna zwracająca imie autora pracy
        }

        public string getLastName()
        {
            return lastName; //Funkcja publiczna zwracająca nazwisko autora pracy
        }

        string IAuthor.getFirstName()
        {
            throw new NotImplementedException();
        }

        string IAuthor.getLastName()
        {
            throw new NotImplementedException();
        }
    }
}
