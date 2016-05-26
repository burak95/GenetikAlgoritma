using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenetikAlgoritma
{
    class Michalewicz10:Fonksiyonlar
    {
        public Michalewicz10() : base(0, Math.PI, -9.660151715641349, 10)
        {

        }

        override public double hesapla(List<Gen> x)
        {
            double y = 0;
            for (int i = 0; i < x.Count; i++)
                y = y + (Math.Sin(x[i].Veri) * Math.Pow(Math.Sin((i + 1) * Math.Pow(x[i].Veri, 2) / Math.PI), 20));
            y = y * -1;
            return y;
        }
    }
}
