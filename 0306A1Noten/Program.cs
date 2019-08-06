using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0306A1Noten
{
    class Program
    {
        static void Main(string[] args)
        {
            char n;
            string t;

            Console.Write("Bitte Note eingeben: ");
            n = Console.ReadKey().KeyChar;
            Console.WriteLine();

            switch (n)
            {
                case '1':
                    t = "Sehr Gut";
                    break;

                case '2':
                    t = "Gut";
                    break;

                case '3':
                    t = "Befriedigend";
                    break;

                case '4':
                    t = "Ausreichend";
                    break;

                case '5':
                    t = "Mangelhaft";
                    break;

                case '6':
                    t = "Totaler Unfug";
                    break;

                default:
                    t = "";
                    break;
            }
            if (t == "")
                Console.WriteLine("Eingabefehler!");
            else
                Console.WriteLine("{0} steht für \"{1}\"",n,t);
        }
    }
}
