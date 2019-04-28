using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PD1S3Z
{
    class Kulcs
    {
        public Stilus stilus { get; set; }
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
        public static bool operator ==(Kulcs kulcs1, Kulcs kulcs2)
        {
            if ((int)kulcs1.stilus == (int)kulcs2.stilus)
                return true;
            return false;
        }

        public static bool operator !=(Kulcs kulcs1, Kulcs kulcs2)
        {
            if ((int)kulcs1.stilus != (int)kulcs2.stilus)
                return true;
            return false;
        }
    }
}
