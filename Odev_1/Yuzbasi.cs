using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Odev_1
{
    class Yuzbasi : Asker
    {
        Random rastgele = new Random();
        public Yuzbasi(bool canlı, Takim takım, int saglık, int[] koordinat) : base(canlı, takım, saglık,koordinat)
        {


        }
        public override int Ateş_et()
        {
            Random rastgele = new Random();
            int sayi = rastgele.Next(1, 4);
            if (sayi == 1) return 15;
            else if (sayi == 2) return 25;
            else return 40;
        }

        public override int Bekle()
        {
            return 0;
        }

        public override int[] HaraketEt(int[] x)
        {
            int yuru = rastgele.Next(1, 9);
            int[] temp;
            temp = x;
            
            if(yuru == 1)
            {
                temp[0]++;
                return temp;
            }
            else if (yuru == 2)
            {
                temp[0]--;
                return temp;
            }
            else if (yuru == 3)
            {
                temp[1]++;
                return temp;
            }
            else if (yuru == 3)
            {
                temp[1]++;
                return temp;
            }
            else if (yuru == 4)
            {
                temp[1]--;
                return temp;
            }
            else if (yuru == 5)
            {
                temp[0]++;
                temp[1]++;
                return temp;
            }
            else if (yuru == 6)
            {
                temp[0]--;
                temp[1]--;
                return temp;

            }
            else if (yuru == 7)
            {
                temp[0]++;
                temp[1]--;
                return temp;

            }
            else
            {
                temp[0]--;
                temp[1]++;
                return temp;

            }
            
        }
    }
}
