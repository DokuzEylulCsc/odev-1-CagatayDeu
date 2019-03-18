using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Odev_1
{
    class Ermeydani
    {
        Bolge bolge = new Bolge();

        Bolge[,] harita = new Bolge[16, 16];

        public Bolge[,] Harita { get { return harita; } set { harita = value; } }

        int x = 0;
        int y = 0;
        int x2 = 15;

        public Ermeydani()
        {
            
        }

        public void trytry()
        {

            Random rastgele = new Random();
            int sayi = rastgele.Next(0, 7);




            for (int a = 0; a < 16; a++)
                for (int b = 0; b < 16; b++)
                    Console.WriteLine(a + "," + b + "  " + bolge.harita[a, b]);
        }


        //askerleri 2 boyutlu harita dizisine yerleştirme

        public void askerYerlestir(Asker asker, Asker asker2,Array harita,int index)
        {  
            int[] temp = new int[2];
            

            bolge.harita[x, y] = asker;
            temp[0] = x; temp[1] = y;
            asker.Koordinat = temp;

            bolge.harita[x2, y] = asker2;
            temp[0] = x2; temp[1] = y;
            asker2.Koordinat = temp;

            y++;

            trytry();

        }

    }
}
