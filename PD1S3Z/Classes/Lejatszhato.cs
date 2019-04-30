using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PD1S3Z
{
    public delegate void ArvaltozasMetodus();
    abstract class Lejatszhato : ILejatszhato
    {
        public ArvaltozasMetodus arvaltozas { get; set; }

        public string Cim { get; set; }
        public int SzerzoiJogdij { get; set; }
        public double Hossz { get; set; }
        public Stilus Stilus { get; set; }

        protected Lejatszhato(string cim, int szerzoiJogij, double hossz, Stilus stilus)
        {
            Cim = cim;
            SzerzoiJogdij = szerzoiJogij;
            Hossz = hossz;
            Stilus = stilus;
        }
        public Lejatszhato()
        {

        }

        public void setSzerzoJogdij(int szerzoJogdij)
        {
            SzerzoiJogdij = szerzoJogdij;

            onArvaltozas();
        }

        public void esemenyFeliratkozas(Action a)
        {
            arvaltozas = new ArvaltozasMetodus(a);
        }

        public override string ToString()
        {
            return string.Format($"{Cim} {SzerzoiJogdij} {Hossz} {Stilus.ToString()}");
        }

        protected virtual void onArvaltozas()
        {
            if (arvaltozas != null) //kéne egy vizsgálat, hogy ez az elem szerepel e a stíluselemek között
                arvaltozas();
        }
    }
}
