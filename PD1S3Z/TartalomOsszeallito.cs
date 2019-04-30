using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PD1S3Z
{
    class TartalomOsszeallito
    {
        public delegate void UjOptimalisEventHandler(object source, UjOptimalisEventArgs args);
        private event UjOptimalisEventHandler ujOptimalis;

        //rendezett lancolt
        public RendezettLancoltLista<ILejatszhato> stilusElemek { get; set; }

        public double ido { get; set; }
        //ido

        public TartalomOsszeallito()
        {
            
        }

        public void setKiinduloAdatok(double ido, RendezettLancoltLista<ILejatszhato> elemek)
        {
            stilusElemek = elemek;
            this.ido = ido;
        }

        public void Osszeallitas()
        {
            bool[] E = new bool[stilusElemek.listaMeret()];
            bool[] OPT = new bool[stilusElemek.listaMeret()];
            for (int i = 0; i < E.Length; i++)
            {
                E[i] = false;
                OPT[i] = true;
            }
            Console.WriteLine();

            int szam = 0;

            BackTrack(0, ref E, ref OPT, ref szam);

            /*for (int i = 0; i < OPT.Length; i++)
            {
                Console.WriteLine(OPT[i]);
            }*/
        }

        public void kiir(bool[] t)
        {
            for (int i = 0; i < t.Length; i++)
            {
                Console.WriteLine(t[i]);
            }
        }

        public void BackTrack(int szint, ref bool[] E, ref bool[] OPT, ref int szam)
        {
            for (int i = 0; i < 2; i++)
            {
                E[szint] = (i == 0);
                if(FK(szint, E))
                {
                    if(szint == E.Length-1)
                    {
                        if (Osszeg(E) < Osszeg(OPT)) 
                        {
                            if (szam == 0)
                            {
                                for (int j = 0; j < OPT.Length; j++)
                                {
                                    bool a = E[j];
                                    OPT[j] = a;
                                }
                                szam = Osszeg(E);
                            }
                            else if(OsszIdo(E) > ido - 5)
                            {
                                for (int j = 0; j < OPT.Length; j++)
                                {
                                    bool a = E[j];
                                    OPT[j] = a;
                                }
                                szam = Osszeg(E);
                                //Console.WriteLine("uj");
                                OnUjOptimalis(OsszIdo(OPT), szam, OPT);
                            }
                            /*Console.WriteLine("asdasdasdsad");
                            kiir(OPT);
                            Console.WriteLine(Osszeg(E));
                            Console.WriteLine();*/
                        }   
                    }
                    else
                    {
                        BackTrack(szint+1, ref E, ref OPT, ref szam);
                    }
                }
            }
        }

        public bool FK(int szint, bool[] E)
        {
            double ossz = 0;
            for (int i = 0; i < szint; i++)
            {
                if (E[i])
                    ossz += stilusElemek[i].Hossz;
            }
            if (ossz < ido+5)
                return true;
            return false;
        }

        public double OsszIdo(bool[] E)
        {
            double osszeg = 0;

            for (int i = 0; i < E.Length; i++)
            {
                if (E[i])
                {
                    osszeg += stilusElemek[i].Hossz;
                }
            }

            return osszeg;
        }

        public int Osszeg(bool[] E)
        {
            int osszeg = 0;
            for (int i = 0; i < E.Length; i++)
            {
                if (E[i])
                    osszeg += stilusElemek[i].SzerzoiJogdij;
            }
            return osszeg;
        }

        //eseményekhez
        protected virtual void OnUjOptimalis(double osszeallitasIdeje, int Ar, bool[] OPT)
        {
            if (ujOptimalis != null)
            {
                ujOptimalis(this, new UjOptimalisEventArgs()
                {
                    Ar = Ar,
                    Ido = osszeallitasIdeje,
                    OPT = OPT,
                    Osszeallitas = stilusElemek
                });
            }
        }

        public void esemenyFeliratkozas(UjOptimalisEventHandler method)
        {
            ujOptimalis += method;
        }
        public void esemenyLeiratkozas(UjOptimalisEventHandler method)
        {
            ujOptimalis -= method;
        }
    }
}
