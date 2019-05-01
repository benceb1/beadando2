using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PD1S3Z
{
    public interface ILejatszhato
    { 
        string Cim { get; set; }
        int SzerzoiJogdij { get; set; }
        double Hossz { get; set; }

        Stilus Stilus { get; set; }
        void esemenyFeliratkozas(ArvaltozasEventHandler handler);
        void setSzerzoJogdij(int szerzoJogdij);


    }
}
