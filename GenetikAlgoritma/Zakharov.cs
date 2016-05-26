using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenetikAlgoritma
{
    class Zakharov : Fonksiyonlar
    {
        public Zakharov() : base(-5,10,0,10)
        {

        }

  

        public override double hesapla(List<Gen> x)
        {
            double y1 = 0, y2 = 0, y3 = 0;
            for (int i = 0; i < x.Count(); i++)
            {
                y1 = y1 + Math.Pow(x[i].Veri, 2);
                y2 = y2 + 0.5 * (i + 1) * x[i].Veri;
                y3 = y3 + 0.5 * (i + 1) * x[i].Veri;
            }
            return y1 + Math.Pow(y2, 2) + Math.Pow(y3, 4);
        }
    
    }
}
