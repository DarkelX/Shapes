using Shapes.Create;

namespace Shapes.Tests.Create
{
    [TestClass]
    public class CircleTests
    {
        [TestMethod]
        public void GetShape_R5p4_91p6088returned()
        {
            var radius = 5.4;
            var expected = 91.6088;

            var circle = new Circle(radius);
            var actual = circle.GetArea();

            Assert.AreEqual(expected, actual, 0.0001);
        }

        [TestMethod]
        public void GetShape_R7p89_195p5707returned()
        {
            var radius = 7.89;
            var expected = 195.5707;

            var circle = new Circle(radius);
            var actual = circle.GetArea();

            Assert.AreEqual(expected, actual, 0.0001);
        }
    }
}