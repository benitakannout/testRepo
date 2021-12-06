using System;
using System.Collections.Generic;
using System.Linq;

namespace MyApp // Note: actual namespace depends on the project name.
{
    public struct Pazymiai
    {
        public int PirmasTrimestras;
        public int AntrasTrimestras;
        public int TreciasTrimestras;

        public Pazymiai(int pirmasTrimestras, int antrasTrimestras, int treciasTrimestras)
        {
            PirmasTrimestras = pirmasTrimestras;
            AntrasTrimestras = antrasTrimestras;
            TreciasTrimestras = treciasTrimestras;
        }

        public void IsvestiVidurki()
        {
            Console.WriteLine($"Mokinio vidurkis yra {(PirmasTrimestras + AntrasTrimestras + TreciasTrimestras) / 3}");
        }

    }

    public class Program
    {
        public static void Main(string[] args)
        {
            Pazymiai pazymiai = new Pazymiai();
            pazymiai.PirmasTrimestras = 9;
            pazymiai.AntrasTrimestras = 6;
            pazymiai.TreciasTrimestras = 10;

            pazymiai.IsvestiVidurki();

            Pazymiai pazymiai1 = new Pazymiai(9, 6, 10);
            pazymiai1.IsvestiVidurki();



            Console.ReadLine();
            
        }
    }
}