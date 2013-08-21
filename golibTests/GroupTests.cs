using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using golib;

namespace golibTests
{
    [TestClass]
    public class GroupTests
    {
        static BoardModel ds_boardModel;
        static int ds_sz;

        [ClassInitialize()]
        public static void ClassInit(TestContext context)
        {
            ds_sz = 19;
            ds_boardModel = new BoardModel(ds_sz);
        }

        [TestMethod]
        public void GetGroups()
        {
            ds_boardModel.SetCell(CellState.WHITE, 1, 1);
            ds_boardModel.SetCell(CellState.WHITE, 1, 2);

            Group gr = null;

            gr = ds_boardModel.GroupThatContainsStone(2, 2);
            Assert.IsNull(gr);

            gr = ds_boardModel.GroupThatContainsStone(1, 1);

            Assert.IsNotNull(gr);
            Assert.IsTrue(gr.NumPieces() == 2);

        }
    }
}
