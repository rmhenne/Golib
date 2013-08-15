using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace golib
{
    class Util
    {
        public static bool RangeCheck(int val, int low, int high)
        {
            if (val <= high && val >= low)
            {
                return true;
            }
            else
            {
                throw new Exceptions.RangeError(val, low, high);
            }
        }

    }
}
