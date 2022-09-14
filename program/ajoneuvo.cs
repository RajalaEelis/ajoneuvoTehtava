using System;
using System.Collections.Generic;
using System.Text;

namespace program
{
    class Ajoneuvo
    {
        
        public double Polttoaineenmaara { get; set; }
        public double Polttoainetankki { get; set; }
        public double Keskikulutus { get; set; }

        public Ajoneuvo()
        {
            Polttoaineenmaara = 5;
            Polttoainetankki = 50;
            Keskikulutus = 7.8;
        }

        public void Tankkaus()
        {
            double polttoaineenHinta = 1.88;

            double puuttuvaPolttoaine = Polttoainetankki - Polttoaineenmaara;
            puuttuvaPolttoaine = Math.Truncate(puuttuvaPolttoaine * 100) / 100;
            Console.WriteLine("Polttoainetta tankattu: " + $"{puuttuvaPolttoaine}");
            Polttoaineenmaara = Polttoainetankki;

            double hinta = puuttuvaPolttoaine * polttoaineenHinta;
            hinta = Math.Truncate(hinta * 100) / 100;
            Console.WriteLine($"Polttoaineen hinta: {hinta} ");




        }
        public void Ajo(double ajetutkilometrit)
        {
            double Kulunutpolttoaine = ajetutkilometrit / 100 * Keskikulutus;
           
            Kulunutpolttoaine = Math.Truncate(Kulunutpolttoaine * 100) / 100;
            Console.WriteLine($"kuluneen polttoaineen määrä: {Kulunutpolttoaine} ");
            Polttoaineenmaara = Polttoaineenmaara - Kulunutpolttoaine;
            Polttoaineenmaara = Math.Truncate(Polttoaineenmaara * 100) / 100;
            Console.WriteLine($"Polttoainetta jäljellä: {Polttoaineenmaara}");




           // Ajoneuvo.Ajo(parametri);
           //kaava: kilometrit / 100* keskikulutus
            //Console.WriteLine("tämä on parametri");
            //Ajoneuvo auto1 = new Ajoneuvo();
            //auto1.Ajo(parametri);
            //auto1.Ajo(35.6);
        } 

        






    }
}
