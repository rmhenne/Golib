using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace golib
{
    public class Group
    {
        private int d_row, d_col;
        private List<Tuple<int, int>> d_members,
            d_liberties;
        CellState d_color;

        public Group( int row, int col, CellState cs )
        {
            d_row = row;
            d_col = col;
            d_color = cs;
        }

        public void Add( int row, int col )
        {
            if (row <= d_row && col <= d_col)
            {
                d_row = row;
                d_col = col;
            }

            d_members.Add(Tuple.Create(row, col));
      
        }


        public void Add(List<Tuple<int,int>> stones )
        {
        }



    }


    public class Groups
    {
    }
}
