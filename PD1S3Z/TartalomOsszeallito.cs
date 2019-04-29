using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PD1S3Z
{
    class TartalomOsszeallito
    {
        //rendezett lancolt
        public RendezettLancoltLista<ILejatszhato> stilusElemek { get; set; }

        public double ido { get; set; }
        //ido

        public TartalomOsszeallito(double ido, RendezettLancoltLista<ILejatszhato>elemek)
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
            BackTrack(0, ref E, ref OPT);

            for (int i = 0; i < OPT.Length; i++)
            {
                Console.WriteLine(OPT[i]);
            }
        }

        public void kiir(bool[] t)
        {
            for (int i = 0; i < t.Length; i++)
            {
                Console.WriteLine(t[i]);
            }
        }

        public void BackTrack(int szint, ref bool[] E, ref bool[] OPT)
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
                            for (int j = 0; j < OPT.Length; j++)
                            {
                                OPT[i] = E[i];
                            }
                            Console.WriteLine("asdasdasdsad");
                            kiir(OPT);
                            Console.WriteLine();
                        }   
                    }
                    else
                    {
                        BackTrack(szint+1, ref E, ref OPT);
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
            if (ossz < ido)
                return true;
            return false;
        }

        public int Osszeg(bool[] E)
        {
            int osszeg = 0;
            for (int i = 0; i < E.Length; i++)
            {
                if (E[i])
                    osszeg += stilusElemek[i].SzerzoiJogij;
            }
            return osszeg;
        }
    }
}
