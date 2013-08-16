using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics.Contracts;

namespace golib
{
    public enum CellState
    {
        EMPTY,
        WHITE,
        BLACK
    }


    public class BoardModelUtil
    {
        public static CellState IndexToState(int ii)
        {
            Util.RangeCheck(ii, 0, 2);

            switch (ii)
            {
                case 0:
                    return CellState.EMPTY;

                case 1:
                    return CellState.WHITE;

                case 2:
                    return CellState.BLACK;
            }

            Contract.Assert(false);
            return CellState.EMPTY;
        }

        public static void GenerateRandomConfiguration(int numPoints, BoardModel bm)
        {
            Random rnd = new Random();

            for (int ii = 0; ii < numPoints; ii++)
            {
                int row = rnd.Next() % bm.width + 1;
                int col = rnd.Next() % bm.width + 1;
                golib.CellState st = IndexToState(rnd.Next() % 3);

                bm.SetCell(st, row, col);
            }
        }

        public static bool IsEmpty(BoardModel bm)
        {
            for (int row = 1; row <= bm.width; row++)
            {
                for (int col = 1; col <= bm.width; col++)
                {
                    if (bm.GetCell(row, col) != CellState.EMPTY)
                    {
                        return false;
                    }
                }
            }
            return true;

        }

        public static void ClearBoard( BoardModel bm )
        {
            for (int ii = 1; ii <= bm.width; ++ii)
            {
                for (int jj = 1; jj <= bm.width; ++jj)
                {
                    bm.ClearCell(ii, jj);
                }
            }
        }


    }

    public class BoardModel
    {
        private CellState[,] d_board;
        private int d_size;

        public BoardModel(int sz)
        {
            d_size = sz;
            d_board = new CellState[sz, sz];
            BoardModelUtil.ClearBoard( this );
        }


        private int ToIndex( int ii )
        {
            return ii - 1;
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
