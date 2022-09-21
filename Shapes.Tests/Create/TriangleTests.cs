using Shapes.Create;

namespace Shapes.Tests.Create
{
    [TestClass]
    public class TriangleTests
    {
        [TestMethod]
        public void GetShape_1p2_1p2_1p2_0p6235returned()
        {
            var sideA = 1.2;
            var sideB = 1.2;
            var sideC = 1.2;
            var expected = 0.6235;

            var triangle = new Triangle(sideA, sideB, sideC);
            var actual = triangle.GetArea();

            Assert.AreEqual(expected, actual, 0.0001);
        }

        [TestMethod]
        public void GetShape_3_4_5_6returned()
        {
            var sideA = 3;
            var sideB = 4;
            var sideC = 5;
            var expected = 6;

            var triangle = new Triangle(sideA, sideB, sideC);
            var actual = triangle.GetArea();

            Assert.AreEqual(expected, actual, 0.0001);
        }

        [TestMethod]
        public void IsRectangular_3_4_5_true()
        {
            var sideA = 3;
            var sideB = 4;
            var sideC = 5;
            var expected = true;

            var triangle = new Triangle(sideA, sideB, sideC);
            var actual = triangle.IsRectangular;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void IsRectangular_7_4_9_false()
        {
            var sideA = 7;
            var sideB = 4;
            var sideC = 9;
            var expected = false;

            var triangle = new Triangle(sideA, sideB, sideC);
            var actual = triangle.IsRectangular;

            Assert.AreEqual(expected, actual);
        }
    }
}
