using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace golib
{
    class Exceptions
    {
        public class GoLibException : ApplicationException
        {
            protected string d_msg;

            public GoLibException(string msg)
            {
                d_msg = msg;
            }


            public string GetMessage()
            {
                return d_msg;
            }
        }

        public class ArgError : GoLibException
        {
            public ArgError(string msg)
                : base(msg)
            {
            }
        }

        public class PosOffBoard : GoLibException
        {
            public PosOffBoard(string msg)
                : base("Position off of board: " + msg)
            {
            }
        }


        public class RangeError : GoLibException
        {
            public RangeError( int val, int low, int high )
                : base("Value " + val + "is outside of the range [" + low + "," + high + "]"  )
            {
            }
        }


    }
}
