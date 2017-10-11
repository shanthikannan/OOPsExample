using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using InheritanceShape;

namespace InheritenceShapeTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestSquareGetSides()
        {
            //Arange
            int expected = 1;
            Square sq = new Square();
            ISides sides = sq;
            Shape sh = sq;
            sides.GetSides();
            sh.FindArea();

            //Act
            int actual = sq.GetSides();

            //Assert
            Assert.AreEqual(expected, actual);

        }
    }
}
