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
        public void TestMethod1()
        {
        }
    }
}
