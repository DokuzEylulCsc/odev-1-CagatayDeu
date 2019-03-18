using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Odev_1
{
    class Er : Asker
    {
        Random rastgele = new Random();

        public Er(bool canlı,Takim takım,int saglık,int[] koordinat) : base(canlı,takım,saglık,koordinat)
        {

            
        }

        //rastgele hasarla ateş etme
        public override int Ateş_et()
        {
            Random rastgele = new Random();
            int sayi = rastgele.Next(1, 4);
            if (sayi == 1) return 5;
            else if (sayi == 2) return 10;
            else return 15;
        }

        // hiçbir şey yapma //
        public override int Bekle()
        {
            return 0;
        }


        // asker hareket etme
        public override int[] HaraketEt(int[] x)
        {
            int yuru = rastgele.Next(0, 2);
            int[] temp;
            temp = x;
            if (yuru == 0)
            {
                temp[0]++;
                return temp;
            } else
            {
                temp[0]--;
                return temp;
            }
        }

    }
}
