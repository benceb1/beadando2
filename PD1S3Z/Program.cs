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

            //megrendelõ szavai
            /*Console.WriteLine("Milyen stílusban kívánja összeállítani a mûsort az alábbiak közül?\n(Csaladias, Romantikus, Mulatos, Nyalas, RockNRoll,Jazz)");
            string stilus = Console.ReadLine();
            Console.WriteLine("Adja meg a kívánt idõ hosszúságát percek számában!");
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
