using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task
{
    class Hesablamalar
    {
        // Toplama
        public double ToplamaMetodu(params double[] menimGozelMassivim)
        {
            double result = 0;

            foreach (double massiviminElementi in menimGozelMassivim)
            {
                result += massiviminElementi;
            }


            return result;
        }


        // Cixma
        public double CixmaMetodu(params double[] massiv)
        {
            double cixmaninCavabi = 0;
            if (massiv.Length > 0)
            {
                cixmaninCavabi = massiv[0];
            }

            for (int i = 1; i < massiv.Length; i++)
            {
                cixmaninCavabi -= massiv[i];
            }

            return cixmaninCavabi;

        }



        // Vurma
        // Bolme
        // Mod
        // Kvadrat

    }
}
