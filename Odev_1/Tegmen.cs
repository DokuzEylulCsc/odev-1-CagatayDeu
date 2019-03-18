using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Odev_1
{
    class Tegmen : Asker
    {
        Random rastgele = new Random();
        public Tegmen(bool canlı, Takim takım, int saglık, int[] koordinat) : base(canlı, takım, saglık,koordinat)
        {


        }
        // ..... //
        public override int Ateş_et()
        {
            Random rastgele = new Random();
            int sayi = rastgele.Next(1, 4);
            if (sayi == 1) return 10;
            else if (sayi == 2) return 20;
            else return 25;
        }

        public override int Bekle()
        {
            return 0;
        }

        public override int[] HaraketEt(int[] x)
        {
            int yuru = rastgele.Next(0, 4);
            int[] temp;
            temp = x;

            if (yuru == 0)
            {
                temp[0]++;
                return temp;
            }
            else if (yuru == 1)
            {
                temp[0]--;
                return temp;
            }
            else if (yuru == 2)
            {
                temp[1]++;
                return temp;
            }
            else
            {
                temp[1]--;
                return temp;
            }
        }
    }
}
