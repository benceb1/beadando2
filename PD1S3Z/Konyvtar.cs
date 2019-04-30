using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace PD1S3Z
{
    class Konyvtar
    {
        
        public RendezettLancoltLista<ILejatszhato> keszlet { get; set; }

        public Konyvtar()
        {
            
            keszlet = new RendezettLancoltLista<ILejatszhato>();
        }

        public void Beolvasas()
        {
            
            StreamReader sr = new StreamReader("adatok.txt");
            while (!sr.EndOfStream)
            {
                string[] sor = sr.ReadLine().Split(';');
                keszlet.Beszuras(sorElem(sor));
            }
            sr.Close();
        }
        
        

        private ILejatszhato sorElem(string[] sor)
        {
            switch (sor[0])
            {
                case "0":
                    return new TorrentZene()
                    {
                        Cim = sor[1],
                        SzerzoiJogdij = int.Parse(sor[2]),
                        Hossz = int.Parse(sor[3]),
                        Stilus = (Stilus)int.Parse(sor[4])
                    };
                    break;
                case "1":
                    return new VasaroltZene()
                    {
                        Cim = sor[1],
                        SzerzoiJogdij = int.Parse(sor[2]),
                        Hossz = int.Parse(sor[3]),
                        Stilus = (Stilus)int.Parse(sor[4])
                    };
                    break;
                case "2":
                    return new Film()
                    {
                        Cim = sor[1],
                        SzerzoiJogdij = int.Parse(sor[2]),
                        Hossz = int.Parse(sor[3]),
                        Stilus = (Stilus)int.Parse(sor[4])
                    };
                    break;
                case "3":
                    return new BakelitLemez()
                    {
                        Cim = sor[1],
                        SzerzoiJogdij = int.Parse(sor[2]),
                        Hossz = int.Parse(sor[3]),
                        Stilus = (Stilus)int.Parse(sor[4])
                    };
                    break;

                default:
                    return null;
            }
        }
    }
    
}
