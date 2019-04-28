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
            }
            else//különben meg akárhol is van, beteszi az e és a p közé
            {
                uj.kovetkezo = p;
                e.kovetkezo = uj;
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
                && elso.SzerzoiJogij == masodik.SzerzoiJogij
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

        private void Feldolgoz(ListaElem elem)
        {
            Console.WriteLine(elem);
        }
    }
}
