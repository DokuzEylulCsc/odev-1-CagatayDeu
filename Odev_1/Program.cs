using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Odev_1
{
    class Program
    {
        static void Main(string[] args)
        {
           

            cagirAsker();
            


         

        }
        static void cagirAsker()
        {
           
           
            

            
            Random rastgele = new Random();
                int yuzbasiSayi = rastgele.Next(1, 3);
                int tegmenSayi = rastgele.Next(1, 3);
                int yuzbasiSayi2 = rastgele.Next(1, 3);
                int tegmenSayi2 = rastgele.Next(1, 3);
            //rastsal olarak kaç adet  tegmen vb olacağını fonksiyona iletmek
            birlikUret(yuzbasiSayi, tegmenSayi, yuzbasiSayi2, tegmenSayi2);
            
           

            

            Console.Read();
        }

        //rastsal olarak asker üretmek
        static void birlikUret(int yuzbasiSayi,int tegmenSayi, int yuzbasiSayi2, int tegmenSayi2)
        {
            int[] temp = new int[2];
            temp[0] = 0; temp[1] = 0;
            Ermeydani meydan = new Ermeydani();
            Takim takım = new Takim();
            Er er = new Er(true, takım, 100,temp);
            Tegmen tegmen = new Tegmen(true, takım, 100, temp);
            Yuzbasi yuzbasi = new Yuzbasi(true, takım, 100, temp);
            Bolge bolge = new Bolge();

            int i = 0;

                if (yuzbasiSayi == 2)
                {
                    takım.Birlik1[i] = yuzbasi;
                    i++;
                }
                if (tegmenSayi == 1)
                {
                    takım.Birlik1[i] = tegmen;
                    i++;
                }
                else
                {
                    takım.Birlik1[i] = tegmen;
                    i++;
                    takım.Birlik1[i] = tegmen;
                    i++;

                }
                for (int x = i; x < 7; x++)
                {
                    takım.Birlik1[x] = er;
                }


                i = 0;

                if (yuzbasiSayi2 == 2)
                {
                    takım.Birlik2[i] = yuzbasi;
                    i++;
                }
                if (tegmenSayi2 == 1)
                {
                    takım.Birlik2[i] = tegmen;
                    i++;
                }
                else
                {
                    takım.Birlik2[i] = tegmen;
                    i++;
                    takım.Birlik2[i] = tegmen;
                    i++;

                }
                for (int x = i; x < 7; x++)
                {
                    takım.Birlik2[x] = er;
                }


                for (int a = 0; a < 7; a++)
                {
                    meydan.askerYerlestir(takım.Birlik1[a],takım.Birlik2[a],bolge.harita,a);
                
                }

        }
    }
}
