using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farmacie
{
    class FiguraGeometrica
    {
        string TipFigura;
        int  NrLaturi;
        List<int> LungimiLaturi;
        public DateTime hour;

        public FiguraGeometrica()
        {
            TipFigura = "patrat";
            NrLaturi = 4;
            LungimiLaturi = new List<int>();
            hour = new DateTime(2000,5,7, 12, 30, 0);
        }

        public FiguraGeometrica(string _TipFigura,int _NrLaturi,string _LungimiLaturi,DateTime _hour)
        {
            TipFigura = _TipFigura;
            NrLaturi = _NrLaturi;
            LungimiLaturi = _LungimiLaturi.Split(' ').Select(Int32.Parse).ToList() ;
            hour = _hour.Date;
        }

        public string Info()
        {
            return $"Figura:{TipFigura},NrLaturi:{NrLaturi},Lungimi:{LungimiLaturi},Hour:{hour}";
        }

        public int Latura1()
        {
            
            
                if (LungimiLaturi == null || LungimiLaturi.Count < 1)
                {
                    throw new InvalidOperationException("Geometric figure does not have a first side.");
                }
                return LungimiLaturi[3];
            
        }

        public int   Perimetru()
        {
            int perimetru=0;
            foreach(int latura in LungimiLaturi)
            {
                perimetru += latura;
            }
            return perimetru;
        }
    }
}
