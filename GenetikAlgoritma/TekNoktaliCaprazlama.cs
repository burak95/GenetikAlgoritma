using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenetikAlgoritma
{
    class TekNoktaliCaprazlama : Caprazlama
    {
        List<Kromozom> cocukBireyler = new List<Kromozom>();
        Random rnd = new Random();
        public override List<Kromozom> caprazlama_yap(Kromozom birey1, Kromozom birey2, double caprazlamaOrani)
        {
            cocukBireyler.Clear();
            int rastgelesayi = rnd.Next(0,birey1.GenListesi.Count);
            for (int i = 0; i < 2; i++)
            {
                Kromozom kromozom = new Kromozom();
                for (int j = 0; j < birey1.GenListesi.Count; j++)
                {
                  
                    if (i == 0)
                    {
                        if (rastgelesayi == j)
                        {
                            kromozom.genEkle(birey2.GenListesi[rastgelesayi]);
                        }
                        else
                        {
                            kromozom.genEkle(birey1.GenListesi[j]);
                        }
                    }
                    else
                    {
                        if (rastgelesayi == j)
                        {
                            kromozom.genEkle(birey1.GenListesi[rastgelesayi]);
                        }
                        else
                        {
                            kromozom.genEkle(birey2.GenListesi[j]);
                        }
                    }
                }
                
                cocukBireyler.Add(kromozom);
            }

            return cocukBireyler;
        }
    }
}
