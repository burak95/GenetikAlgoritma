using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenetikAlgoritma
{
    class Rastgele:BireySecimi
    {
        Random rnd = new Random();

        public override Kromozom birey_sec(List<Kromozom> list)
        {
            Form1.index = rnd.Next(0, list.Count);
            return list[Form1.index];
        }
    }
}
