using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task
{
    class Program
    {
        static void Main(string[] args)
        {
            Hesablamalar h = new Hesablamalar();

            double resToplama = h.ToplamaMetodu(5.5, 15.9, 44.1);
            Console.WriteLine(resToplama);

            double resCixma = h.CixmaMetodu(50, 15, 5, 20);
            Console.WriteLine(resCixma);

            Console.ReadLine();
        }
    }
}
