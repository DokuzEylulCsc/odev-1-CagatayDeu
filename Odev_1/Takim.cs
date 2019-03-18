using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Odev_1
{
    class Takim
    {
        // 2 farklı takım için 2 farklı dizi
        Asker[] birlik1 = new Asker[7];
        Asker[] birlik2 = new Asker[7];


        public Asker[] Birlik1 { get { return birlik1; } set { birlik1 = value; } }
        public Asker[] Birlik2 { get { return birlik2; } set { birlik2 = value; } }

        public Takim()
        {
            Birlik1 = birlik1;
            Birlik2 = birlik2;
        }
    }
}
