using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace golib
{
    public class Group
    {

        // Bounding Box
        private Tuple<int,int> d_lowerLeftBound,
            d_upperRightBound;
        private List<Tuple<int, int>> d_members,
            d_liberties;
        CellState d_color;
        private int[,] d_lattice;


        public Group( int row, int col, CellState cs )
        {
            d_lowerLeftBound  = Tuple.Create(row, col);
            d_upperRightBound = Tuple.Create(row, col);
            
            d_color = cs;
            d_members = new List<Tuple<int, int>>();
            AddCore(row, col);
        }

        private void AdjustBoundingBox(int row, int col)
        {
            int rowLow = Math.Min(d_lowerLeftBound.Item1, row),
                rowHi = Math.Max(d_upperRightBound.Item1, row),
                colLow = Math.Min(d_lowerLeftBound.Item2, col),
                colHi = Math.Max(d_upperRightBound.Item2, col);

            d_lowerLeftBound = Tuple.Create(rowLow, colLow);
            d_upperRightBound = Tuple.Create(rowHi, colHi);
        }

        private void AddCore(int row, int col)
        {
            AdjustBoundingBox(row, col);

            d_members.Add(Tuple.Create(row, col));

        }


        public void Add( int row, int col )
        {
            AddCore(row, col);
        }


        public void Add(List<Tuple<int,int>> stones )
        {
            foreach (var stone in stones)
            {
                AddCore(stone.Item1, stone.Item2);
            }
        }

        private bool CheckConnectedness()
        {
            throw new NotImplementedException("CheckConnectedness");
        }

        private void PlacePiecesOnLattice()
        {
            int width = d_upperRightBound.Item2 - d_lowerLeftBound.Item2 + 1,
                height = d_upperRightBound.Item1 - d_lowerLeftBound.Item1 + 1;

            d_lattice = new int[height, width];

            foreach (var stone in d_members)
            {

            }


        }
    }


    public class Groups
    {
    }
}
