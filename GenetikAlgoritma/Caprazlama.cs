using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenetikAlgoritma
{
    abstract class Caprazlama
    {
        public static Caprazlama caprazlama_secimi_yontem_sec(string bireySecmeYontemi)
        {
            switch (bireySecmeYontemi)
            {
                case "Tek Noktalı": return new TekNoktaliCaprazlama();
               
                default: return null;
            }
        }

        abstract public List<Kromozom> caprazlama_yap(Kromozom birey1,Kromozom birey2,double caprazlamaOrani);
    }
}
