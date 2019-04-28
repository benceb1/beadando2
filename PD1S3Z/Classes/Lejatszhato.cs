using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PD1S3Z
{
    abstract class Lejatszhato : ILejatszhato
    {
        public string Cim { get; set; }
        public int SzerzoiJogij { get; set; }
        public double Hossz { get; set; }
        public Stilus Stilus { get; set; }

        
    }
}
