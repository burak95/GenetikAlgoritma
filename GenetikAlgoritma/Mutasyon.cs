using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenetikAlgoritma
{
    abstract class Mutasyon
    {
        public static Mutasyon mutasyon_yontem_sec(string bireySecmeYontemi)
        {
            switch (bireySecmeYontemi)
            {
                case "Toplama": return new ToplamaMutasyon();
                case "Çıkarma": return new CikarmaMutasyon();
                default: return null;
            }
        }

        abstract public List<Kromozom> mutasyon_yap(List<Kromozom> list,double mutasyonOrani,double altsinir,double ustsinir);

    }
}
