using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farmacie
{
    enum EnumParerePersoana
    {
        PreaSlab = 1,
        Normal = 2,
        Obez = 3
    }
    class Sondaj
    {
        float inaltime;
        float varsta;
        float greutate;
        EnumParerePersoana parerePersoana;


        public Sondaj(float _inaltime, float _varsta, float _greutate, EnumParerePersoana _parerePersoana)
        {
            inaltime = _inaltime;
            varsta = _varsta;
            greutate = _greutate;
            parerePersoana = _parerePersoana;
        }

        public Sondaj()
        {
            inaltime = 0.0f;
            varsta = 3.0f;
            greutate = 5.0f;
            parerePersoana = EnumParerePersoana.Normal;
        }

        public float getVarsta()
        {
            return varsta;
        }

        public string Info()
        {
            return $"Inaltime: {inaltime},Varsta:{varsta},Greutate:{greutate},Parere_Persoana:{parerePersoana}";

        }

        public string IntervalVarsta(float varsta)
        {
            
            
                if (varsta < 12)
                {
                    return "Copil";
                }
                else if (varsta >= 12 && varsta < 18)
                {
                    return "Adolescent";
                }
                else
                {
                    return "Adult";
                }
            
        }

        public float GreutateIdeala()
        {
            return (inaltime - 100 + varsta / 10) * 0.9f;
        }
    }

}
