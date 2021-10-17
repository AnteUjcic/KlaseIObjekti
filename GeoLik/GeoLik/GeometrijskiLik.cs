using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeoLik
{
    class GeometrijskiLik
    {
        int BrojStranica;

        public double[] stranice = new double[10];

        public GeometrijskiLik(int brojStranica, double[] stranice)
        {
            BrojStranica = brojStranica;
            this.stranice = stranice;
        }

        
        public double[] Stranice { get => stranice; set => stranice = value; }
        public int BrojStranica1 { get => BrojStranica; set => BrojStranica = value; }

        public void UcitajStranice()
        {
            Stranice = new double[BrojStranica];

            for (int i = 0; i < BrojStranica; i++)
            {
                Console.Write("Unesite stranicu: ");
                Stranice[i] = Convert.ToInt32(Console.ReadLine());
            }
        }

        public double Opseg()
        {
            double retrn= 0;
            foreach (double broj in Stranice)
            {
               retrn += broj;
            }
            return retrn;
        }
    }
}
