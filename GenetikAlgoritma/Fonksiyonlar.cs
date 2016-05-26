using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenetikAlgoritma
{
    abstract class Fonksiyonlar
    {
        int genSayisi;
        double altsinir, ustsinir, minimumDegeri;

        public Fonksiyonlar( double altsinir, double ustsinir,double minimumDegeri,int genSayisi)
        {
            this.Altsinir = altsinir;
            this.Ustsinir = ustsinir;
            this.MinimumDegeri = minimumDegeri;
            this.genSayisi = genSayisi;
        }

        public double Altsinir
        {
            get
            {
                return altsinir;
            }

            set
            {
                altsinir = value;
            }
        }

        public double MinimumDegeri
        {
            get
            {
                return minimumDegeri;
            }

            set
            {
                minimumDegeri = value;
            }
        }

        public double Ustsinir
        {
            get
            {
                return ustsinir;
            }

            set
            {
                ustsinir = value;
            }
        }

        public int GenSayisi
        {
            get
            {
                return genSayisi;
            }

            set
            {
                genSayisi = value;
            }
        }

        public static Fonksiyonlar fonksiyon_olustur (string fonksiyonIsmi)
        {
            switch (fonksiyonIsmi)
            {
                case "Beale": return new Beale();
                case "Easom": return new Easom();
                case "Colville": return new Colville();
                case "Michalewicz 2": return new Michalewicz2();
                case "Michalewicz 5": return new Michalewicz5();
                case "Michalewicz 10": return new Michalewicz10();
                case "Zakharov": return new Zakharov();
               
                default: return null;
            }
        }
        abstract public double hesapla(List<Gen> x);
    }
}
