using System;
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
            AddMedicament f1 = new AddMedicament("Algocalmin", "Folosit pentru dureri");
            string s1 = f1.Info();
            Console.WriteLine(s1);
            string numeFisier = ConfigurationManager.AppSettings["NumeFisier"];
            AdministrareMedicamente_FisierText adminStudenti = new AdministrareMedicamente_FisierText(numeFisier);

            Console.ReadKey();
        }
    }
}
