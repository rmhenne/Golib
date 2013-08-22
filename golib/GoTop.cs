using System;
using System.Diagnostics.Contracts;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace golib
{
    class GoTop
    {
        private BoardModel d_boardModel;
        private Groups d_groups;

        public GoTop()
        {
            d_boardModel = new BoardModel(19);
            d_groups = new Groups();

            Contract.Ensures(d_groups.count == 0);
        }
    }
}
