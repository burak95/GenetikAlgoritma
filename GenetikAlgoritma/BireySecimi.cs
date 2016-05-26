using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenetikAlgoritma
{
    abstract class BireySecimi
    {
        
        public static BireySecimi birey_secimi_yontem_sec(string bireySecmeYontemi)
        {
            switch (bireySecmeYontemi)
            {
                case "Rulet Tekerleği": return new RuletTekerlegi();
                case "Deterministik": return new Deterministik();
                case "Rastgele": return new Rastgele();
                case "Turnuva": return new Turnuva();
             
                default: return null;
            }
        }

        abstract public Kromozom birey_sec(List<Kromozom> list);

        
    }
}
