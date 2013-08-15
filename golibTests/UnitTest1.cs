using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using golib;

namespace golibTests
{
    [TestClass]
    public class BoardTests
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
        public void CheckRandomSets()
        {
            Random rnd = new Random();
            CellState[] vals = new CellState[3];


            for (int ii = 0; ii < 10000; ii++)
            {
                int row = rnd.Next() % ds_sz + 1;
                int col = rnd.Next() % ds_sz + 1;
                golib.CellState st = vals[rnd.Next() % 3];

                ds_boardModel.SetCell(st, row, col);

                Assert.AreEqual(ds_boardModel.GetCell(row, col), st);

                ds_boardModel.ClearCell(row, col);
                Assert.AreEqual(ds_boardModel.GetCell(row, col), CellState.EMPTY);

            }

        }



        [TestMethod]
        public void CheckSize()
        {
            Assert.AreEqual(ds_boardModel.width, ds_sz);
        }
    }
}
