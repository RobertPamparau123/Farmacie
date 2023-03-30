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
        string tip;
        float pret;



        //	Constructor fara parametri
        public AddMedicament()
        {
            denumire = string.Empty;
            prospect = string.Empty;
            tip = string.Empty;
            pret = 145;

        }

        //	Constructor cu parametri
        public AddMedicament(string _denumire, string _prospect,string _tip,float _pret)
        {
            denumire = _denumire;
            prospect = _prospect;
            tip = _tip;
            pret = _pret;
        }

        public string getDenumire() 
        {
            return denumire;
        }



        //	Metoda care returneaza informatiile despre figura geometrica 
        //	sub forma unui sir de caractere
        public string Info()
        {
            return $"Denumire: {denumire}, Prospect: {prospect}, Tip:{tip},Pret:{pret}";
        }

        
    }
}
