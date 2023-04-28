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
            /* var figura = new FiguraGeometrica();
             string f7 = figura.Info();
             Console.WriteLine(figura.hour.TimeOfDay);
             var figura1 = new FiguraGeometrica("Dreptunghi", 4, "3 5 3 5",new DateTime());
             string f9 = figura1.Info();
             Console.WriteLine(f9);
             int latura = figura1.Latura1();
             int perimetru = figura1.Perimetru();
             Console.WriteLine(latura);
             Console.WriteLine(perimetru);
             var s = new Sondaj();
             string f = s.Info();
             Console.WriteLine(f);

             var s5 = new Sondaj(12,17,80, EnumParerePersoana.Obez);
             float varsta1 = s.getVarsta();
             string interval = s5.IntervalVarsta(varsta1);
             float greutate = s5.GreutateIdeala();
             var f5 = s5.Info();
             Console.WriteLine(f5);
             Console.WriteLine(interval);
             Console.WriteLine(greutate);*/


            AddMedicament f1 = new AddMedicament("Algocalmin", "Folosit pentru dureri", "Pastile", 456);
            string s1 = f1.Info();
            Console.WriteLine(s1);
            string numeFisier = ConfigurationManager.AppSettings["NumeFisier"];
            AdministrareMedicamente_FisierText adminStudenti = new AdministrareMedicamente_FisierText(numeFisier);






            //Citire de la tastatura
            AddMedicament medicament = new AddMedicament();

            //Console.WriteLine("Introduceti denumirea medicamentului:");
            string denumire = Console.ReadLine();

            // Console.WriteLine("Introduceti prospectul medicamentului:");
            string prospect = Console.ReadLine();

            //Console.WriteLine("Introduceti tipul medicamentului:");
            string tip = Console.ReadLine();

            // Console.WriteLine("Introduceti pretul medicamentului:");
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
            Console.ReadKey();

        }
    }
}
