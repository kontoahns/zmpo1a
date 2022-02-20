using System;

namespace PracaZaliczeniowa
{
    //Klasa definiująca menu
    class Menu
    {
        public string tmpMenu; //Deklaracja publicznej zmiennej tmpMenu typu string
        public int menuNumber = 0; //Deklaracja publicznej zmiennej menuNumber typu int

        //Funkcja publiczna zwracająca menu w programie
        public string show()
        {
            return "MENU:\n" +
                "1. Dodaj nowy film\n" +
                "2. wyświetl liste wszystkich dodanych od najstarszych\n" +
                "3. wyświetl liste wszystkich dodanych od najnowszych\n" +
                "4. co zobaczyć teraz (losowy wybór)\n" +
                "5. ostatnio dodany\n" +
                "6. Usuń wszystkie\n" +
                "7. Wyjdź z programu\n";
        }

        //Funkcja publiczna zwracająca tekst który ma się wyświetlić nad menu programu
        public string textToSelect()
        {
            return "Wpisz numer z menu";
        }

        //Funkcja publiczna zwracająca tekst który ma się wyświetlić w przypadku wybrania złego numeru z menu
        public string textBadNumber()
        {
            return "\n Wprowadziłeś zły numer, wpisz jeszcze raz \n";
        }

        //Funkcja publiczna zwracająca wartość aktualnie wybranej pozycji z menu
        public int getNumber()
        {
            return menuNumber;
        }

    }
}
