using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PD1S3Z
{
    class UjOptimalisEventArgs : EventArgs
    {
        public double Ido { get; set; }
        public int Ar { get; set; }
        public RendezettLancoltLista<ILejatszhato> Osszeallitas { get; set; }
        public bool[] OPT { get; set; }
    }
}
