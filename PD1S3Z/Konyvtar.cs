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

            }
            sr.Close();
        }
    }
    
}
