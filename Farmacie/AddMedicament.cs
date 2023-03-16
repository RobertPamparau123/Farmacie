using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farmacie
{
    public class AddMedicament
    {
        string denumire;
        string prospect;


        //	Constructor fara parametri
        public AddMedicament()
        {
            denumire = string.Empty;
            prospect = string.Empty;
        }

        //	Constructor cu parametri
        public AddMedicament(string _denumire, string _prospect)
        {
            denumire = _denumire;
            prospect = _prospect;
        }

        //	Metoda care returneaza informatiile despre figura geometrica 
        //	sub forma unui sir de caractere
        public string Info()
        {
            return $"Denumire: {denumire}, Prospect: {prospect}";
        }
    }
}
