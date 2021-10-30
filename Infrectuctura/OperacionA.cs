using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Alcoholemia.Api.Infrectuctura
{
    public class OperacionA
    {
        public double PruebaAlcoholemia (string Bebidas, double numero, double Kilos)
        {
            double AlcoholTotal;
            double AlcoholS;
            double MGS;
            double LS;
            double AVS;

            double mili;
            double NivelAlchohol;

            switch (Bebidas)
            {
                case "Cerveza":
                    mili = 330 * numero;
                    NivelAlchohol = 5;
                    break;
                case "Vino":
                    mili = 100 * numero;
                    NivelAlchohol = 12;
                    break;
                case "Cava":
                    mili = 100 * numero;
                    NivelAlchohol = 12;
                    break;
                case "Vermu":
                    mili = 70 * numero;
                    NivelAlchohol = 17;
                    break;
                case "Licor":
                    mili = 45 * numero;
                    NivelAlchohol = 23;
                    break;
                case "Brandy":
                    mili = 45 * numero;
                    NivelAlchohol = 38;
                    break;
                case "Combinado":
                    mili = 45 * numero;
                    NivelAlchohol = 38;
                    break;
                default:
                    mili = 0;
                    NivelAlchohol = 0;
                    break;     
            }
            
            AlcoholTotal = (NivelAlchohol * 0.010) * mili;
            AlcoholS = 0.15 * AlcoholTotal;
            MGS = 0.789 * AlcoholS;
            LS = 0.08 * Kilos;
            AVS = MGS / LS;
            return AVS;   
        }
    }
}