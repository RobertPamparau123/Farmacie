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

        public FiguraGeometrica()
        {
            TipFigura = "patrat";
            NrLaturi = 4;
            LungimiLaturi = new List<int>();
        }

        public FiguraGeometrica(string _TipFigura,int _NrLaturi,string _LungimiLaturi)
        {
            TipFigura = _TipFigura;
            NrLaturi = _NrLaturi;
            LungimiLaturi = _LungimiLaturi.Split(' ').Select(Int32.Parse).ToList() ;
        }

        public string Info()
        {
            return $"Figura:{TipFigura},NrLaturi:{NrLaturi},Lungimi:{LungimiLaturi}";
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
