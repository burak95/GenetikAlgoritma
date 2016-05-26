using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenetikAlgoritma
{
    class Easom : Fonksiyonlar
    {
        public Easom() : base(-100, 100, -1, 2)
        {
        }

        public override double hesapla(List<Gen> x)
        {
            double y = -Math.Cos(x[0].Veri) * Math.Cos(x[1].Veri) * Math.Exp(-Math.Pow((x[0].Veri - Math.PI), 2) - Math.Pow((x[1].Veri - Math.PI), 2));
            return y;
        }
    }
}
