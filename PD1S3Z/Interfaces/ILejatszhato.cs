using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PD1S3Z
{
    interface ILejatszhato
    { 
        string Cim { get; set; }
        int SzerzoiJogdij { get; set; }
        double Hossz { get; set; }

        Stilus Stilus { get; set; }
        void esemenyFeliratkozas(Action a);
        void setSzerzoJogdij(int szerzoJogdij);


    }
}
