using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;


namespace Farmacie
{
    class Program
    {
        static void Main()
        {
            AddMedicament f1 = new AddMedicament("Algocalmin", "Folosit pentru dureri", "Pastile", 456);
            string s1 = f1.Info();
            Console.WriteLine(s1);
            string numeFisier = ConfigurationManager.AppSettings["NumeFisier"];
            AdministrareMedicamente_FisierText adminStudenti = new AdministrareMedicamente_FisierText(numeFisier);






            //Citire de la tastatura
            AddMedicament medicament = new AddMedicament();

            Console.WriteLine("Introduceti denumirea medicamentului:");
            string denumire = Console.ReadLine();

             Console.WriteLine("Introduceti prospectul medicamentului:");
            string prospect = Console.ReadLine();

            Console.WriteLine("Introduceti tipul medicamentului:");
            string tip = Console.ReadLine();

             Console.WriteLine("Introduceti pretul medicamentului:");
            float.TryParse(Console.ReadLine(), out float pret);

            //Incarcare in fisier
            AddMedicament f2 = new AddMedicament(denumire, prospect, tip, pret);
            adminStudenti.AddMedicament(f2);
            




            int nrMedicamente;
            AddMedicament[] medicamente = adminStudenti.GetMedicamente(out nrMedicamente);

            for (int i = 0; i < nrMedicamente; i++)
            {
                string info = medicamente[i].Info();
                Console.WriteLine(info);
            }
            Console.WriteLine("Data saved to file.");
            string s2 = f2.Info();
            Console.WriteLine(s2);
            adminStudenti.GetMedicamente1();
            Console.ReadKey();

        }
    }
}
