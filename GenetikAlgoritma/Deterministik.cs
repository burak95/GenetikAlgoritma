using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenetikAlgoritma
{
    class Deterministik : BireySecimi
    {
        public override Kromozom birey_sec(List<Kromozom> list)
        {
            Form1.index = 0;
            return list[Form1.index];
        }
   
    }
}
