using System;

namespace naslijedivanjeKlasa
{
    class Program
    {
        static void Main(string[] args)
        {
            Bjelogoricno hrast = new Bjelogoricno(true);
            Crnogoricno bor = new Crnogoricno(false);


            Console.WriteLine("Hrast je "+hrast.OpadajuListovi+", bor je " + bor.OpadajuListovi);
           
        }
      
    }
}
