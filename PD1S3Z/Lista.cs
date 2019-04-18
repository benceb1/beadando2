using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PD1S3Z
{
    class RendezettLista<T> where T : ILejatszhato
    {
        class ListaElem
        {
            public ListaElem kovetkezo;
            public T tartalom;
            public Kulcs kulcs;
        }
        private ListaElem ujElem(T tartalom)
        {
            return new ListaElem()
            { tartalom = tartalom,
                kulcs = new Kulcs(tartalom.Stilus)
            };
        }
    }
    class Kulcs
    {
        Stilus stilus { get; set; }
        public Kulcs(Stilus stilus)
        {
            this.stilus = stilus;
        }
        public static bool operator <(Kulcs kulcs1, Kulcs kulcs2)
        {
            if ((int)kulcs1.stilus < (int)kulcs2.stilus)
                return true;
            return false;
        }
        public static bool operator >(Kulcs kulcs1, Kulcs kulcs2)
        {
            if ((int)kulcs1.stilus > (int)kulcs2.stilus)
                return true;
            return false;
        }
    }
}
