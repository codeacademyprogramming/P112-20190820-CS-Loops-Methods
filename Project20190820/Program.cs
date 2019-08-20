using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project20190820
{
    class Program
    {
        static void Main(string[] args)
        {
            //int x = 5, y = 20;
            //string netice;

            //netice = x > y ? "shert odendi" : "shert odenmedi";

            //Console.WriteLine(netice);


            //string name = "Gunel";

            //switch (name)
            //{
            //    case "Ulvi":
            //        Console.WriteLine("Name is Ulvi");
            //        break;
            //    case "Gunel":
            //        Console.WriteLine("Name is Gunel");
            //        break;
            //    case "Huseyn":
            //        Console.WriteLine("Name is Huseyn");
            //        break;
            //    case "Yaver":
            //        Console.WriteLine("Name is Yaver");
            //        break;

            //}


            // LOOPS

            //int i = 5;

            //for (; i < 20; i++)
            //{
            //    int sqr = i * i;
            //    Console.WriteLine("i-nin deyeri = " + i + " - i-nin kvadrati " + sqr);
            //    Console.WriteLine("i-nin deyeri = {0} - i-nin kvadrati {1}", i, sqr);
            //    Console.WriteLine($"i-nin deyeri = {i} - i-nin kvadrati {sqr}");

            //    Console.WriteLine("=================");
            //}

            //for (int i = 1; i <= 100; i++)
            //{
            //    i++;
            //    Console.WriteLine("i value: {0}", i);
            //}


            //Console.WriteLine("Salam {0}, salam {1}", "Kamil", "Anar");


            // WHILE

            //int i = 1;

            //while (i < 4)
            //{
            //    Console.WriteLine("i value: {0}", i);

            //    if (i == 50)
            //    {
            //        break;
            //    }
            //    i++;
            //}


            // FOREACH

            //string[] names = new string[4] {
            //    "Teymur",
            //    "Anar",
            //    "Misir",
            //    "Cavid"
            //};


            //for (int i = 0; i < names.Length; i++)
            //{
            //    if (i == 1)
            //    {
            //        continue;
            //    }

            //    Console.WriteLine(names[i]);
            //}

            //Console.WriteLine("____________");


            //foreach (string ad in names)
            //{
            //    Console.WriteLine(ad);
            //}


            Operations opt = new Operations();
            float cavab = opt.Add(3.3f, 3.7f, 10, 5.7f, 8, 19.1f);

            opt.DisplayResult(cavab);


            Messages.Name();

            Console.ReadLine();
        }


        public string GetName()
        {
            return "P112";
        }
    }
}
