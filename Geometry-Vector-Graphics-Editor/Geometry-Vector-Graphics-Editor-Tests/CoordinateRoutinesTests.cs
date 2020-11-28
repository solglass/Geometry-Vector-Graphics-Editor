using NUnit.Framework;
using System.Drawing;

namespace Geometry_Vector_Graphics_Editor_Tests
{
    public class CoordinateRoutinesTests
    {

        [TestCase(new Point[] { new Point(3, 0), new Point(3, 0) })]
        public void CalculateSquareCoordinatesByTwoPoints(Point[] actual, Point[] expected)
        {
            actual = new Point[] { new Point(3, 0), new Point(3, 0) };
            Assert.AreEqual(expected, actual);
        }

    }
}