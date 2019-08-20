using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project20190820
{
    class Operations
    {
        //public float Add(float a, float b)
        //{
        //    float result = a + b;
        //    return result;
        //}

        public float Add(params float[] ededler)
        {
            float result = 0;
            for (int i = 0; i < ededler.Length; i++)
            {
                result += ededler[i];
            }

            return result;
        }

        public void DisplayResult(float cavab)
        {
            Console.WriteLine(cavab);
        }

    }
}
