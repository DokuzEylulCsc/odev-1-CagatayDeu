using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Odev_1
{
    abstract class Asker
    {
        public int[] Koordinat = new int[2];

        private Takim takım;

        private bool canlı;

        private int saglık;

        

        public Asker(bool canlı,Takim takım,int saglık,int[] koordinat)
        {
            Canlı = canlı;
            Saglık = saglık;
            Koordinat = koordinat;
           
        }


        public bool Canlı { get { return canlı; } set { canlı = value; } }

        public Takim Takım { get { return takım; }  }

        public int Saglık { get { return saglık; } set { saglık = value; } }


        public abstract int[] HaraketEt(int[] x);
        
        public abstract int Bekle();

        public abstract int Ateş_et();



    }
}
