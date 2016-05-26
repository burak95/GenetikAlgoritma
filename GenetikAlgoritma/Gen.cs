using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GenetikAlgoritma
{
    class Gen
    {
        
        double veri;

        public Gen (double veri)
        {
            this.veri = veri;
        }

        public double Veri
        {
            get
            {
                return veri;
            }

            set
            {
                veri = value;
            }
        }
    }
}
