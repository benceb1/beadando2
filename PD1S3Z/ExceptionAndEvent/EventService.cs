using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PD1S3Z
{
    
    class EventService
    {
        public void ujOptimalis(object source, UjOptimalisEventArgs args)
        {
            Console.WriteLine("Új összeállítás!");
            for (int i = 0; i < args.OPT.Length; i++)
            {
                if (args.OPT[i])
                {
                    Console.Write(args.Osszeallitas[i].Cim+"    ");
                }
            }
            Console.WriteLine("\nÁr: {0}\nHossz: {1}\n",args.Ar,args.Ido);
        }
    }
}
