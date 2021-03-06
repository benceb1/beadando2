﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PD1S3Z
{
    class RendezettLancoltLista<T> where T : ILejatszhato
    {
        //külső táblázat
        private ListaElem[] elsoElemek = new ListaElem[6];
        

        private ListaElem fej;
        class ListaElem
        {
            public ListaElem kovetkezo;
            public T tartalom;
            public Kulcs kulcs;

            public override string ToString()
            {
                return string.Format(tartalom.ToString());
                //return string.Format("" + tartalom);
            }

        }

        public ILejatszhato this[int index]
        {
            get
            {
                int belsoIndex = 0;
                ListaElem p = fej;
                while (p != null && belsoIndex!=index)
                {
                    p = p.kovetkezo;
                    belsoIndex++;
                }
                return p.tartalom;
            }
        }

        private ListaElem ujElem(T tartalom)
        {
            return new ListaElem()
            {
                tartalom = tartalom,
                kulcs = new Kulcs(tartalom.Stilus)
            };
        }

        //beillesztes
        public void Beszuras(T tartalom)
        {
            ListaElem uj = ujElem(tartalom);
            ListaElem p = fej;
            ListaElem e = null;

            while (p != null && uj.kulcs > p.kulcs)
            {
                e = p;
                p = p.kovetkezo;
            }
            if (e == null) // ha az e null akkor a p is null szóval a fej lesz az új
            {
                uj.kovetkezo = fej;
                fej = uj;
                elsoElemek[(int)fej.tartalom.Stilus] = fej;
            }
            else//különben meg akárhol is van, beteszi az e és a p közé
            {
                uj.kovetkezo = p;
                e.kovetkezo = uj;
                elsoElemek[(int)uj.tartalom.Stilus] = uj;
            }
        }
        //torles
        public void Torles(T torlendo)
        {
            ListaElem p = fej;
            ListaElem e = null;
            while (p != null && osszehasonlit(torlendo, p.tartalom) != true)
            {
                e = p;
                p = p.kovetkezo;
            }
            if (p != null)
            {
                if (e != null)
                {
                    fej = p.kovetkezo;
                }
                else
                {
                    e.kovetkezo = p.kovetkezo;
                }

                p = null;
            }
            else
            {
                Console.WriteLine("Nincs ilyen elem!!!  (Exception)");
            }
        }

        private bool osszehasonlit(T elso, T masodik)
        {
            if (elso.Hossz == masodik.Hossz
                && elso.Stilus == masodik.Stilus
                && elso.SzerzoiJogdij == masodik.SzerzoiJogdij
                && elso.Cim == masodik.Cim)
                return true;
            return false;
        }

        public RendezettLancoltLista<T> listaStilusSzerint(Stilus stilus)
        {
            Kulcs kulcs = new Kulcs(stilus);
            RendezettLancoltLista<T> stilusElemek = new RendezettLancoltLista<T>();
            //---
            ListaElem p = elsoElemek[(int)stilus];
            
            while (p != null && p.kulcs == kulcs)
            {
                stilusElemek.Beszuras(p.tartalom);
                
                p = p.kovetkezo;
              
            }
            //---
            return stilusElemek;
        }

        public void Bejaras()
        {
            ListaElem p = fej;
            while (p != null)
            {
                Feldolgoz(p);
                p = p.kovetkezo;
            }
        }
        //ebben fel kéne iratkoztatni ezt a vizsgálatot ami alatta van, hogy ha lefut az event, akkor a vizsgálat szerint fusson le benne a többi
        public void EsemenyekFelvitele(ArvaltozasEventHandler h)
        {
            ListaElem p = fej;
            while (p != null)
            {
                p.tartalom.esemenyFeliratkozas(h);
                p = p.kovetkezo;
            }
        }

        public bool szerepelE(ILejatszhato lejatszhato)
        {
            ListaElem p = fej;
            while (p != null)
            {
                if (p.tartalom.Cim == lejatszhato.Cim) return true;
                p = p.kovetkezo;
            }
            return false;
        }

        private void Feldolgoz(ListaElem elem)
        {
            Console.WriteLine(elem);
        }

        public double osszegzettIdo()
        {
            double ossz = 0;
            ListaElem p = fej;
            while (p != null)
            {
                ossz += p.tartalom.Hossz;
                p = p.kovetkezo;
            }
            return ossz;
        }

        public int listaMeret()
        {
            int ossz = 0;
            ListaElem p = fej;
            while (p != null)
            {
                ossz++;
                p = p.kovetkezo;
            }
            return ossz;
        }
    }
}
