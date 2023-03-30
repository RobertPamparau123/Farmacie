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
            //	Instantierea unui obiect de tip FiguraGeom utilizand constructorul fara parametri
            //	Tipul variabilei f este 'var' (determinat de compilator)
           // var f = new AddMedicament();
            //string s = f.Info();
            //Console.WriteLine(s);

            //	Instantierea unui obiect de tip FiguraGeom utilizand constructorul cu parametri
            //	Tipul variabilei f1 este explicit 'FiguraGeom'
            AddMedicament f1 = new AddMedicament("Algocalmin", "Folosit pentru dureri","Pastile",456);
            string s1 = f1.Info();
            Console.WriteLine(s1);
            string numeFisier = ConfigurationManager.AppSettings["NumeFisier"];
            AdministrareMedicamente_FisierText adminStudenti = new AdministrareMedicamente_FisierText(numeFisier);






            //Citire de la tastatura
            AddMedicament medicament = new AddMedicament();
            //Console.Write("Denumire: ");
            //string denumire = medicament.getDenumire();
            //denumire = Console.ReadLine();
            //string info = medicament.Info();
            //Console.WriteLine(info);

            Console.WriteLine("Introduceti denumirea medicamentului:");
            string denumire = Console.ReadLine();

            Console.WriteLine("Introduceti prospectul medicamentului:");
            string prospect = Console.ReadLine();

            Console.WriteLine("Introduceti tipul medicamentului:");
            string tip = Console.ReadLine();

            Console.WriteLine("Introduceti pretul medicamentului:");
            float.TryParse(Console.ReadLine(), out float pret);

            AddMedicament f2 = new AddMedicament(denumire,prospect,tip,pret);
            adminStudenti.AddMedicament(f2);
            


            Console.WriteLine("Data saved to file.");
            string s2 = f2.Info();
           Console.WriteLine(s2);
            Console.ReadKey();
        }
    }
}
