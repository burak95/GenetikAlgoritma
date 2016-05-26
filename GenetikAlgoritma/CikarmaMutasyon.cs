using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenetikAlgoritma
{
    class CikarmaMutasyon : Mutasyon
    {
        public override List<Kromozom> mutasyon_yap(List<Kromozom> list, double mutasyonOrani,double altsinir, double ustsinir)
        {
            for (int i = 0; i < list.Count; i++)
            {
                for (int j = 0; j < list[i].GenListesi.Count; j++)
                {
                    list[i].GenListesi[j].Veri = list[i].GenListesi[j].Veri - mutasyonOrani;
                    if (list[i].GenListesi[j].Veri > 4.5)
                    {
                        list[i].GenListesi[j].Veri = 4.5;
                    }
                    if (list[i].GenListesi[j].Veri < -4.5)
                    {
                        list[i].GenListesi[j].Veri = -4.5;
                    }
                }
            }
            return list;
        }
    }
}
