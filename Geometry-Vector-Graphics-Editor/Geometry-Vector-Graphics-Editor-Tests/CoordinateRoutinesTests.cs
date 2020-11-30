using NUnit.Framework;
using System;
using System.Drawing;

namespace Geometry_Vector_Graphics_Editor_Tests
{
    public class CoordinateRoutinesTests
    {

        [TestCase(1, 1)]
        [TestCase(2, 2)]
        [TestCase(3, 3)]
        public void CalculateSquareCoordinatesByTwoPoints(int actualMockNumber, int expectedMockNumber)
        {
            Point[] actual = GetActualSquareCoordinatesByTwoPoints(actualMockNumber);
            Point[] expected = GetExpectedMockSquareCoordinatesByTwoPoints(expectedMockNumber);
            Assert.AreEqual(expected, actual);

        }

        public Point[] GetExpectedMockSquareCoordinatesByTwoPoints(int n)
        {
            switch (n)
            {
                case 1:
                    return
                        new Point[] { new Point(100, 100), new Point(200, 200), new Point(300, 100), new Point(200, 0) };
                case 2:
                    return new Point[4] { new Point(200, 200), new Point(100, 100), new Point(0, 200), new Point(100, 300) };
                case 3:
                    return new Point[4] { new Point(300, 0), new Point(0, 300), new Point(300, 600), new Point(600, 300) };

                //TODO more tests
                //    case 4:
                //        return new Point[] { new Point(100, 100) };

                default:
                    throw new Exception();
            }
        }

        public Point[] GetActualSquareCoordinatesByTwoPoints(int n)
        {
            switch (n)
            {
                case 1:
                    return
                       Geometry_Vector_Graphics_Editor.CoordinateRoutines.CalculateSquareCoordinatesByTwoPoints(new Point(100, 100), new Point(200, 200));
                case 2:
                    return
                     Geometry_Vector_Graphics_Editor.CoordinateRoutines.CalculateSquareCoordinatesByTwoPoints(new Point(200, 200), new Point(100, 100));
                case 3:
                    return
                        Geometry_Vector_Graphics_Editor.CoordinateRoutines.CalculateSquareCoordinatesByTwoPoints(new Point(300, 0), new Point(0, 300));
                //TODO more tests
                // case 4:
                //     return Geometry_Vector_Graphics_Editor.CoordinateRoutines.CalculateSquareCoordinatesByTwoPoints(new Point(800, 800), new Point(200, 200));

                default:
                    throw new Exception();
            }
        }

    }
}