using System;

namespace GeoLik
{
    class Program
    {
        static void Main(string[] args)
        {

            Trokut trokut = new Trokut();
            Cetverkout cetverkut = new Cetverkout();

            Console.WriteLine("Trokut");
            trokut.UcitajStranice();
            double opsegTrokuta = trokut.Opseg();
            Console.WriteLine();

            Console.WriteLine("Kvadrat");
            cetverkut.UcitajStranice();
            double opsegKvadrata = cetverkut.Opseg();
            Console.WriteLine();

            Console.WriteLine($"Opseg trokuta je: {opsegTrokuta}");
            Console.WriteLine($"Opseg kvadrata je: {opsegKvadrata}");
            Console.ReadKey();

        }
    }
}
