using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenetikAlgoritma
{
    class Colville : Fonksiyonlar
    {
        public Colville() : base( -10, 10, 0,4)
        {

        }

       

        public override double hesapla(List<Gen> x)
        {
            double y = 100 * Math.Pow(Math.Pow(x[0].Veri, 2) - x[1].Veri, 2) + Math.Pow(x[0].Veri - 1, 2) + Math.Pow(x[2].Veri - 1, 2) +
                90 * Math.Pow(Math.Pow(x[2].Veri, 2) - x[3].Veri, 2) + 10.1 * (Math.Pow(x[1].Veri - 1, 2) + Math.Pow(x[3].Veri - 1, 2)) +
                19.8 * (x[1].Veri - 1) * (x[3].Veri - 1);
            return y;
        }
    }
}
