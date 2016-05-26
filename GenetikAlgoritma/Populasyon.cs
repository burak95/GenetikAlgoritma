using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenetikAlgoritma
{
    class Populasyon
    {
        List<Kromozom> kromozomList = new List<Kromozom>();
        public Populasyon()
        {
            
        }

        internal List<Kromozom> KromozomList
        {
            get
            {
                return kromozomList;
            }

            set
            {
                kromozomList = value;
            }
        }

        public void kromozomEkle(Kromozom kromozom)
        {
            KromozomList.Add(kromozom);
        }

   
    }
}
