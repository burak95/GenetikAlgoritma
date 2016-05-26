using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenetikAlgoritma
{
      class Kromozom
    {
        List<Gen> genListesi = new List<Gen>();
        private double uygulukDegeri;

        public Kromozom ()
        {
            
        }

        public double UygulukDegeri
        {
            get
            {
                return uygulukDegeri;
            }

            set
            {
                uygulukDegeri = value;
            }
        }

        internal List<Gen> GenListesi
        {
            get
            {
                return genListesi;
            }

            set
            {
                genListesi = value;
            }
        }

        public void genEkle(Gen gen)
        {
            GenListesi.Add(gen);
        }
    }
}
