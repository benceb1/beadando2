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
        public ElsoElemek keszlet { get; set; }
        public RendezettLancoltLista<ILejatszhato> elsoElemek { get; set; }

        public Konyvtar()
        {
            keszlet = new ElsoElemek();
            elsoElemek = new RendezettLancoltLista<ILejatszhato>();
        }

        public void Beolvasas()
        {
            //parhuzamosan tegyük be a dolgokat, majd járjuk be a két tömbböt

        }
    }
    
}
