using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenetikAlgoritma
{
    class RuletTekerlegi : BireySecimi
    {
        List<double> bireyinSecilmeOranı = new List<double>();
        Random rnd = new Random();
        
        public override Kromozom birey_sec(List<Kromozom> list)
        {
            bireyinSecilmeOranı.Clear();
            double rastgeleSayi;
            double altsinir = 0;
            double toplam = uygunluk_toplami(list);

            for (int i = 0; i < list.Count; i++)
            {
                bireyinSecilmeOranı.Add(toplam/list[i].UygulukDegeri);
            }
           

            rastgeleSayi = (rnd.NextDouble() * bireyinSecilmeOranı[0]);

            for (Form1.index = bireyinSecilmeOranı.Count-1; Form1.index>=0; Form1.index--)
            {
                if (rastgeleSayi>=altsinir && rastgeleSayi<bireyinSecilmeOranı[Form1.index])
                {
                    return list[Form1.index];
                }
                altsinir = bireyinSecilmeOranı[Form1.index];
            }
            Form1.index = 0;     
            return list[0];
        }

        double uygunluk_toplami(List<Kromozom> list)
        {
            double toplam=0;
            foreach (var item in list)
            {
                toplam = toplam + item.UygulukDegeri;
            }
            return toplam;
        }
        

    }
}
