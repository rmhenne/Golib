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
        private int d_size;

        public BoardModel(int sz)
        {
            d_size = sz;
            d_board = new CellState[sz, sz];
            ClearBoard();
        }


        private int ToIndex( int ii )
        {
            return ii - 1;
        }


        public void ClearBoard()
        {
            for (int ii = 1; ii <= d_size; ++ii)
            {
                for (int jj = 1; jj <= d_size; ++jj)
                {
                    ClearCell(ii, jj);
                }
            }
        }


        public void ClearCell(int row, int col)
        {
            SetCell(CellState.EMPTY, row, col);
        }

        public void SetCell( CellState cs, int row, int col )
        {
            Util.RangeCheck(row, 1, width);
            Util.RangeCheck(col, 1, width);

            d_board[ToIndex(row), ToIndex(col)] = cs;
        }

        public CellState GetCell(int row, int col)
        {
            Util.RangeCheck(row, 1, width);
            Util.RangeCheck(col, 1, width);

            return d_board[ToIndex(row),ToIndex(col)];
        }

        public int width { get { return d_size; } }

    }
}
