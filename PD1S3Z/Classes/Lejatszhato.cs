using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PD1S3Z
{
    abstract class Lejatszhato : ILejatszhato, IComparable
    {
        public int SzerzoiJogij { get; set; }
        public double Hossz { get; set; }
        public Stilus Stilus { get; set; }

        public int CompareTo(object obj)
        {
            if (this.Stilus > (obj as Lejatszhato).Stilus)
            {
                return 1;
            }
            else if (this.Stilus < (obj as Lejatszhato).Stilus)
                return -1;
            else
                return 0;
        }
    }
}
