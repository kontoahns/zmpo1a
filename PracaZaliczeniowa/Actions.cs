using System;

namespace PracaZaliczeniowa
{
    class Actions
    {
        protected int number; //Zmienna przechowywujaca numer akcji która ma zostać wykonana

        public void setAction(int action)
        {
            number = action; //Przypisanie wartosci do zmiennej chronionej
        }

        public string doAction()
        {
            var fileSave = new FileSave(); //zmienna przechowujaca obiekt FileSave;
            var fileRead = new FileLoad(); //zmienna przechowujaca obiekt FileLoad;

            //Instrukcja switch obsługujaca menu programu
            switch (number)
            {
                case 1:
                    Console.WriteLine("Podaj tekst do wprowadzenia i zatwierdz [ENTER]");
                    fileSave.save(Console.ReadLine());
                    break;
                case 2:
                    fileRead.getAll(); //Wywolanie funkcji getAll
                    break;
                case 3:
                    fileRead.getAllReverse(); //Wywolanie funkcji getAllReverse
                    break;
                case 4:
                    fileRead.getRandom(); //Wywolanie funkcji getRandom
                    break;
                case 5:
                    fileRead.getLast(); //Wywolanie funkcji getLast
                    break;
                case 6:
                    fileRead.unset(); //Wywolanie funkcji unset
                    break;
            }

            return " ";
        }

    }
}
