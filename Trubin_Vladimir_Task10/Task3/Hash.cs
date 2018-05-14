using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Hash : TwoDPointWithHash
    {
        public Hash(int x, int y) : base(x, y)
        {
        }

        public override int GetHashCode()
        {
            //int hashMaker = (x ^ y) & (x | y);
            int hash = x.GetHashCode() * 13 + y.GetHashCode(); 
            return hash;
        }
    }
}
