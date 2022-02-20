using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracaZaliczeniowa
{
    //Deklaracja interfejsu
    interface IAuthor
    {
        string firstName { get; set; } //Deklracja zmiennej
        string lastName { get; set; } //Deklracja zmiennej
        string getFirstName(); //Deklracja nazwy funkcji ktora musi zostac wykorzystana
        string getLastName(); //Deklracja nazwy funkcji ktora musi zostac wykorzystana
    }
}
