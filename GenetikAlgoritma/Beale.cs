using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenetikAlgoritma
{
    class Beale:Fonksiyonlar
    {
        
        public Beale() : base (-4.5, 4.5 ,0,2)
        {

        }

        override public double hesapla(List<Gen> x)
        {
            double y = Math.Pow((1.5 - x[0].Veri + x[0].Veri * x[1].Veri), 2) + Math.Pow((2.25 - x[0].Veri + x[0].Veri * Math.Pow(x[1].Veri, 2)), 2)
                + Math.Pow((2.625 - x[0].Veri + x[0].Veri * Math.Pow(x[1].Veri, 3)), 2);
            return y;
        }
    }
}
