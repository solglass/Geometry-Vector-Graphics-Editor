using NUnit.Framework;
using System;
using System.Drawing;
using System.Collections;

namespace Geometry_Vector_Graphics_Editor_Tests
{
    public class CoordinateRoutinesTests
    {


        [TestCase(1, 1)]
        [TestCase(2, 2)]
        [TestCase(3, 3)]
        public void CalculateSquareCoordinatesByTwoAdjacentPoints(int actualMockNumber, int expectedMockNumber)
        {
            Point[] actual = GetActualMockSquareCoordinatesByTwoAdjacentPoints(actualMockNumber);
            Point[] expected = GetExpectedMockSquareCoordinatesByTwoAdjacentPoints(expectedMockNumber);
            Assert.AreEqual(expected, actual);

        }

        [TestCase(1, 1)]
        [TestCase(2, 2)]
        [TestCase(3, 3)]
        public void CalculateSquareCoordinatesByTwoOppositePoints(int actualMockNumber, int expectedMockNumber)
        {
            PointF[] actual = GetActualMockSquareCoordinatesByTwoOppositePoints(actualMockNumber);
            PointF[] expected = GetExpectedMockSquareCoordinatesByTwoOppositePoints(expectedMockNumber);
            Assert.AreEqual(expected, actual);

        }


        public Point[] GetExpectedMockSquareCoordinatesByTwoAdjacentPoints(int n)
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

                default:
                    throw new Exception();
            }
        }

        public PointF[] GetExpectedMockSquareCoordinatesByTwoOppositePoints(int n)
        {
            switch (n)
            {
                case 1:
                    return
                        new PointF[4] { new PointF(100, 100), new PointF(200, 100), new PointF(200, 200), new PointF(100, 200) };
                case 2:
                    return
                        new PointF[4] { new PointF(200, 200), new PointF(100, 200), new PointF(100, 100), new PointF(200, 100) };
                case 3:
                    return
                        new PointF[4] { new PointF(0, 0), new PointF(300, 0), new PointF(300, 300), new PointF(0, 300) };

                default:
                    throw new Exception();
            }
        }

        public Point[] GetExpectedMockRectangleCoordinatesByTwoPoints(int n)
        {
            switch (n)
            {
                case 1:
                    return
                        new Point[4] { new Point(100, 100), new Point(100, 200), new Point(200, 200), new Point(200, 100) };
                case 2:
                    return
                        new Point[4] { new Point(200, 100), new Point(200, 400), new Point(500, 400), new Point(500, 100) };
                case 3:
                    return
                        new Point[4] { new Point(0, 0), new Point(0, 300), new Point(300, 300), new Point(300, 0) };


                default:
                    throw new Exception();
            }
        }

        public Point[] GetActualMockSquareCoordinatesByTwoAdjacentPoints(int n)
        {
            switch (n)
            {
                case 1:
                    return
                       Geometry_Vector_Graphics_Editor.CoordinateRoutines.CalculateSquareCoordinatesByTwoAdjacentPoints(new Point(100, 100), new Point(200, 200));
                case 2:
                    return
                       Geometry_Vector_Graphics_Editor.CoordinateRoutines.CalculateSquareCoordinatesByTwoAdjacentPoints(new Point(200, 200), new Point(100, 100));
                case 3:
                    return
                       Geometry_Vector_Graphics_Editor.CoordinateRoutines.CalculateSquareCoordinatesByTwoAdjacentPoints(new Point(300, 0), new Point(0, 300));

                default:
                    throw new Exception();
            }
        }

        public PointF[] GetActualMockSquareCoordinatesByTwoOppositePoints(int n)
        {
            switch (n)
            {
                case 1:
                    return
                       Geometry_Vector_Graphics_Editor.CoordinateRoutines.CalculateSquareCoordinatesByTwoOppositePoints(new PointF(100, 100), new PointF(200, 200));
                case 2:
                    return
                       Geometry_Vector_Graphics_Editor.CoordinateRoutines.CalculateSquareCoordinatesByTwoOppositePoints(new PointF(200, 200), new PointF(100, 100));
                case 3:
                    return
                       Geometry_Vector_Graphics_Editor.CoordinateRoutines.CalculateSquareCoordinatesByTwoOppositePoints(new PointF(0, 0), new PointF(300, 300));

                default:
                    throw new Exception();
            }
        }

        public Point[] GetActualMockSquareRectangleCoordinatesByTwoPointsTopLeftBottomRight(int n)
        {
            switch (n)
            {
               /* case 1:
                    return
                       Geometry_Vector_Graphics_Editor.CoordinateRoutines.CalculateRectangleCoordinatesByTwoOppositePoints(new PointF(100, 200), new PointF(200, 100));
                case 2:
                    return
                       Geometry_Vector_Graphics_Editor.CoordinateRoutines.CalculateRectangleCoordinatesByTwoOppositePoints(new PointF(200, 400), new PointF(500, 100));
                case 3:
                    return
                       Geometry_Vector_Graphics_Editor.CoordinateRoutines.CalculateRectangleCoordinatesByTwoOppositePoints(new PointF(0, 300), new PointF(300, 0));
               */

                default:
                    throw new Exception();
            }
        }

        [Test, TestCaseSource(typeof(GetRectangularTriangleMock))]
        public void CalculateRectangularTriangleCoordinatesByTwoPoints(Point p1, Point p2, Point[] expected)
        {
            Point[] actual;
            actual = Geometry_Vector_Graphics_Editor.CoordinateRoutines.CalculateRectangularTriangleCoordinatesByTwoPoints(p1, p2);
            Assert.AreEqual(expected, actual);
        }

        [Test, TestCaseSource(typeof(GetIsoscelesTriangleMock))]
        public void CalculateIsoscelesTriangleCoordinatesByTwoPoints(Point p1, Point p2, Point[] expected)
        {
            Point[] actual;
            actual = Geometry_Vector_Graphics_Editor.CoordinateRoutines.CalculateIsoscelesTriangleCoordinatesByTwoPoints(p1, p2);
            Assert.AreEqual(expected, actual);
        }


        [Test, TestCaseSource(typeof(GetCicleBySquareMock))]

        public void CalculateCirclePointBySquareTest(PointF squareLUPoint, PointF squareOppositePoint, PointF[] expected)
        {
            PointF[] actual;
            actual = Geometry_Vector_Graphics_Editor.CoordinateRoutines.CalculateCirclePointBySquare(squareLUPoint, squareOppositePoint);
            Assert.AreEqual(expected, actual);
        }

        [Test, TestCaseSource(typeof(GetEllipseByRectangle))]

        public void CalculateEllipsePointByRectangleTest(PointF squareLUPoint, PointF squareOppositePoint, PointF[] expected)
        {
            PointF[] actual;
            actual = Geometry_Vector_Graphics_Editor.CoordinateRoutines.CalculateEllipseByRectangle(squareLUPoint, squareOppositePoint);
            Assert.AreEqual(expected, actual);
        }



    }

    public class GetEllipseByRectangle : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            yield return new object[] { new Point(0, 0), new Point(8, 10), new Point[] { new Point(4, 5), new Point(0, 5), new Point(4, 0) } };
            yield return new object[] { new Point(1, 1), new Point(5, 11), new Point[] { new Point(3, 6), new Point(1, 6), new Point(3, 1) } };
            yield return new object[] { new Point(0, 0), new Point(6, 6), new Point[] { new Point(3, 3), new Point(0, 3), new Point(3, 0) } };
        }

    } 

    public class GetCicleBySquareMock : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            yield return new object[] { new Point(5, 5), new Point(9, 9), new Point[] { new Point(7, 7), new Point(7, 5) } };
            yield return new object[] { new Point(2, 2), new Point(0, 0), new Point[] { new Point(1, 1), new Point(1, 2) } };
            yield return new object[] { new Point(0, 0), new Point(0, 0), new Point[] { new Point(0, 0), new Point(0, 0) } };
        }

    }

    public class GetRectangularTriangleMock : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            yield return new object[] { new Point(0, 10), new Point(10, 0), new Point[] { new Point(0, 10), new Point(10, 0), new Point(0, 0) } };
            yield return new object[] { new Point(0, 0), new Point(10, 10), new Point[] { new Point(0, 0), new Point(10, 10), new Point(10, 0) } };
            yield return new object[] { new Point(10, 20), new Point(30, 10), new Point[] { new Point(10, 20), new Point(30, 10), new Point(10, 10) } };
      }
    }

    public class GetIsoscelesTriangleMock : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            yield return new object[] { new Point(20, 10), new Point(30, 0), new Point[] { new Point(20, 10), new Point(30, 0), new Point(10, 0) } };
            yield return new object[] { new Point(20, 20), new Point(30, 30), new Point[] { new Point(20, 20), new Point(30, 30), new Point(40, 20) } };
            yield return new object[] { new Point(10, 20), new Point(20, 10), new Point[] { new Point(10, 20), new Point(20, 10), new Point(0, 10) } };
        }
    }
}
