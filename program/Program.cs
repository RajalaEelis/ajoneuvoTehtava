using System;
using System.Collections.Generic;

namespace program
{
    class Program
    {
        static void Main(string[] args)
        {
            //gsg
            //fhfsdbfshsbfshd
            Ajoneuvo auto1 = new Ajoneuvo();
            Ajoneuvo auto2 = new Ajoneuvo();
            Ajoneuvo auto3 = new Ajoneuvo();
            Ajoneuvo auto4 = new Ajoneuvo();

            List<Ajoneuvo> autot = new List<Ajoneuvo>();

            string input;
            int aktiivinenAuto = 0;
            bool lopeta = false;

            while (!lopeta)
            {

             Console.WriteLine("T <= Tankkaa ajoneuvoa");
             Console.WriteLine("A <= Aja ajoneuvolla");
                Console.WriteLine("L <= Lopeta sovellus");
                Console.WriteLine("U <= lisää ajoneuvo");
             Console.WriteLine("valitse toiminto");
             input = Console.ReadLine();
             switch (input)
             {
                case "T":
                    auto1.Tankkaus();
                    break;
                case "A":
                    Console.WriteLine("montako kilometriä ajetaan?");
                    input = Console.ReadLine();
                    auto1.Ajo(double.Parse(input));
                    break;
                    case "U":
                        autot.Add(new Ajoneuvo());
                        break;
                    case "L":
                        lopeta = true;
                        break;
                default:
                    break;
             }
            }
        }
    }
}
