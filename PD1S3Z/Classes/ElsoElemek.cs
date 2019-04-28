using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PD1S3Z
{
    class ElsoElemek
    {
        private ILejatszhato[] elsoElemek;
        public ElsoElemek()
        {
            elsoElemek = new ILejatszhato[6];
        }

        public void beszuras(ILejatszhato elem)
        {
            elsoElemek[(int)elem.Stilus-1] = elem;
        }

        public void torlesHa(ILejatszhato elem)
        {
            if(elsoElemek[(int)elem.Stilus-1] != null)
            {
                if(elsoElemek[(int)elem.Stilus - 1].Cim == elem.Cim)
                {
                    elsoElemek[(int)elem.Stilus - 1] = null;
                    //esemény, hogy törölve
                }
            }//exception, ha üres a hely
        }

        public ILejatszhato silusSzerintKeresettElem(Stilus stilus)
        {
            if(elsoElemek[(int)stilus-1] != null)
            {
                return elsoElemek[(int)stilus - 1];
            }
            else
            {
                //exception, ha nincs ilyen elem
                throw new Exception();
            }
            
        }
    }
}
