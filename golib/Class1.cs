using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace golib
{
    public enum CellState
    {
        EMPTY,
        WHITE,
        BLACK
    }


    public class BoardModel
    {
        private CellState[,] d_board;

        public BoardModel(int sz)
        {
            d_board = new CellState[sz, sz];
            for (int ii=0; ii < sz; ++ii )
            {
                for (int jj = 0; jj < sz; ++jj)
                {
                    d_board[ii, jj] = CellState.EMPTY;
                }
            }
        }
    }
}
