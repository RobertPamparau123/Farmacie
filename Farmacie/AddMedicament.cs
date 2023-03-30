using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farmacie
{
    public class AddMedicament
    {
<<<<<<< HEAD
        string denumire;
        string prospect;
        string tip;
        float pret;

=======
        private const char SEPARATOR_PRINCIPAL_FISIER = ';';
        private string denumire;
        private string prospect;

        private const int DENUMIRE = 1;
        private const int PROSPECT = 2;
>>>>>>> 8c236bedb45a23bae6f58b9f89e72028bbd053d3


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

<<<<<<< HEAD
        public string getDenumire() 
        {
            return denumire;
        }



=======
        public AddMedicament(string linieFisier)
        {
            var dateFisier = linieFisier.Split(SEPARATOR_PRINCIPAL_FISIER);

            //ordinea de preluare a campurilor este data de ordinea in care au fost scrise in fisier prin apelul implicit al metodei ConversieLaSir_PentruFisier()
            denumire = dateFisier[DENUMIRE];
            prospect = dateFisier[PROSPECT];
        }

>>>>>>> 8c236bedb45a23bae6f58b9f89e72028bbd053d3
        //	Metoda care returneaza informatiile despre figura geometrica 
        //	sub forma unui sir de caractere
        public string Info()
        {
            return $"Denumire: {denumire}, Prospect: {prospect}, Tip:{tip},Pret:{pret}";
        }

<<<<<<< HEAD
        
=======
        public string ConversieLaSir_PentruFisier()
        {
            string obiectMedicamentPentruFisier = string.Format("{1}{0}{2}{0}{3}{0}",
                SEPARATOR_PRINCIPAL_FISIER,
                (denumire ?? " NECUNOSCUT "),
                (prospect ?? " NECUNOSCUT "));

            return obiectMedicamentPentruFisier;
        }
>>>>>>> 8c236bedb45a23bae6f58b9f89e72028bbd053d3
    }
}
