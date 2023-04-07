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

        private const int DENUMIRE = 1;
        private const int PROSPECT = 2;
        private const int TIP = 3;
        private const int PRET = 4;
        private const char SEPARATOR_PRINCIPAL_FISIER = ';';

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

        public AddMedicament(string linieFisier)
        {
            var dateFisier = linieFisier.Split(SEPARATOR_PRINCIPAL_FISIER);

            //ordinea de preluare a campurilor este data de ordinea in care au fost scrise in fisier prin apelul implicit al metodei ConversieLaSir_PentruFisier()
            denumire = dateFisier[DENUMIRE];
            prospect = dateFisier[PROSPECT];
            tip = dateFisier[TIP];
            //pret = ;
        }

        //	Metoda care returneaza informatiile despre figura geometrica 
        //	sub forma unui sir de caractere
        public string Info()
        {
            return $"Denumire: {denumire}, Prospect: {prospect}, Tip:{tip},Pret:{pret}";
        }

        public string ConversieLaSir_PentruFisier()
        {
            string obiectMedicamentPentruFisier = string.Format("{1}{0}{2}{0}{3}{0}{4}{0}",
                SEPARATOR_PRINCIPAL_FISIER,
                (denumire ?? " NECUNOSCUT "),
                (prospect ?? " NECUNOSCUT "),
                (tip ?? " NECUNOSCUT "),
                pret.ToString());

            return obiectMedicamentPentruFisier;
        }
    }
}
