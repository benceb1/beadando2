using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PD1S3Z
{

    class Program
    {
        
        static void Main(string[] args)
        {
            Konyvtar konnyvtar = new Konyvtar();
            konnyvtar.Beolvasas();

            konnyvtar.keszlet.Bejaras();
            Console.WriteLine();
            
            Console.WriteLine();

            //megrendel� szavai
            /*Console.WriteLine("Milyen st�lusban k�v�nja �ssze�ll�tani a m�sort az al�bbiak k�z�l?\n(Csaladias, Romantikus, Mulatos, Nyalas, RockNRoll,Jazz)");
            string stilus = Console.ReadLine();
            Console.WriteLine("Adja meg a k�v�nt id� hossz�s�g�t percek sz�m�ban!");
            int perc = int.Parse(Console.ReadLine());*/

            TartalomOsszeallito tartalomOsszeallito = new TartalomOsszeallito();

            konnyvtar.keszlet.EsemenyekFelvitele(tartalomOsszeallito.Osszeallitas);

            tartalomOsszeallito.setKiinduloAdatok(26, konnyvtar.keszlet.listaStilusSzerint(Stilus.Csaladias));
            EventService eventService = new EventService();
            tartalomOsszeallito.esemenyFeliratkozas(eventService.ujOptimalis);
            tartalomOsszeallito.Osszeallitas();

            konnyvtar.keszlet[0].setSzerzoJogdij(32);

        }
    }
    
}
