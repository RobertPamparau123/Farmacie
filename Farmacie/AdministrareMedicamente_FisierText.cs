using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Farmacie
{
    public class AdministrareMedicamente_FisierText
    {
        private const int NR_MAX_MEDICAMENTE = 50;
        private string numeFisier;


        public AdministrareMedicamente_FisierText(string numeFisier)
        {
            this.numeFisier = numeFisier;
            Stream streamFisierText = File.Open(numeFisier, FileMode.OpenOrCreate);
            streamFisierText.Close();
        }

        public void AddMedicament(AddMedicament medicament)
        {
            // instructiunea 'using' va apela la final streamWriterFisierText.Close();
            // al doilea parametru setat la 'true' al constructorului StreamWriter indica
            // modul 'append' de deschidere al fisierului
            using (StreamWriter streamWriterFisierText = new StreamWriter(numeFisier, true))
            {
                streamWriterFisierText.WriteLine(medicament.ConversieLaSir_PentruFisier());
            }
        }

        public AddMedicament[] GetMedicamente(out int nrMedicamente)
        {
            AddMedicament[] medicamente = new AddMedicament[NR_MAX_MEDICAMENTE];

            // instructiunea 'using' va apela streamReader.Close()
            using (StreamReader streamReader = new StreamReader(numeFisier))
            {
                string linieFisier;
                nrMedicamente = 0;

                // citeste cate o linie si creaza un obiect de tip Student
                // pe baza datelor din linia citita
                while ((linieFisier = streamReader.ReadLine()) != null)
                {
                    medicamente[nrMedicamente++] = new AddMedicament(linieFisier);
                }
            }

            return medicamente;
        }

        public ArrayList GetMedicamente1()
        {
            ArrayList studenti = new ArrayList();
            // instructiunea 'using' va apela streamReader.Close()
            using (StreamReader streamReader = new StreamReader(numeFisier))
            {
                string linieFisier;

                // citeste cate o linie si creaza un obiect de tip Student
                // pe baza datelor din linia citita
                while ((linieFisier = streamReader.ReadLine()) != null)
                {
                    AddMedicament student = new AddMedicament(linieFisier);
                    studenti.Add(student);
                }
            }
            return studenti;
        }
    }
               
}
