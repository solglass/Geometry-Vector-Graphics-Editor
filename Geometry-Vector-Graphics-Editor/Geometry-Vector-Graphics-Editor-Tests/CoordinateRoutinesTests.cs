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
            Point[] actual = GetActualMockSquareCoordinatesByTwoOppositePoints(actualMockNumber);
            Point[] expected = GetExpectedMockSquareCoordinatesByTwoOppositePoints(expectedMockNumber);
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

                //TODO more tests
                //    case 4:
                //        return new Point[] { new Point(100, 100) };

                default:
                    throw new Exception();
            }
        }

        public Point[] GetExpectedMockSquareCoordinatesByTwoOppositePoints(int n)
        {
            switch (n)
            {
                case 1:
                    return
                        new Point[4] { new Point(100, 100), new Point(200, 100), new Point(200, 200), new Point(100, 200) };
                case 2:
                    return
                        new Point[4] { new Point(200, 200), new Point(100, 200), new Point(100, 100), new Point(200, 100) };
                case 3:
                    return
                        new Point[4] { new Point(0, 0), new Point(300, 0), new Point(300, 300), new Point(0, 300) };

                //TODO more tests
                //    case 4:
                //        return new Point[] { new Point(100, 100) };

                default:
                    throw new Exception();
            }
        }

        public Point[] GetExpectedMockSquareRectangleCoordinatesByTwoPoints(int n)
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

                //TODO more tests
                //    case 4:
                //        return new Point[] { new Point(100, 100) };

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
                //TODO more tests
                // case 4:
                //     return Geometry_Vector_Graphics_Editor.CoordinateRoutines.CalculateSquareCoordinatesByTwoPoints(new Point(800, 800), new Point(200, 200));

                default:
                    throw new Exception();
            }
        }

        public Point[] GetActualMockSquareCoordinatesByTwoOppositePoints(int n)
        {
            switch (n)
            {
                case 1:
                    return
                       Geometry_Vector_Graphics_Editor.CoordinateRoutines.CalculateSquareCoordinatesByTwoOppositePoints(new Point(100, 100), new Point(200, 200));
                case 2:
                    return
                       Geometry_Vector_Graphics_Editor.CoordinateRoutines.CalculateSquareCoordinatesByTwoOppositePoints(new Point(200, 200), new Point(100, 100));
                case 3:
                    return
                       Geometry_Vector_Graphics_Editor.CoordinateRoutines.CalculateSquareCoordinatesByTwoOppositePoints(new Point(0, 0), new Point(300, 300));
                //TODO more tests
                // case 4:
                //     return Geometry_Vector_Graphics_Editor.CoordinateRoutines.CalculateSquareCoordinatesByTwoPoints(new Point(800, 800), new Point(200, 200));

                default:
                    throw new Exception();
            }
        }

        public Point[] GetActualMockSquareRectangleCoordinatesByTwoPointsTopLeftBottomRight(int n)
        {
            switch (n)
            {
                case 1:
                    return
                       Geometry_Vector_Graphics_Editor.CoordinateRoutines.CalculateRectangleCoordinatesByTwoOppositePoints(new Point(100, 200), new Point(200, 100));
                case 2:
                    return
                       Geometry_Vector_Graphics_Editor.CoordinateRoutines.CalculateRectangleCoordinatesByTwoOppositePoints(new Point(200, 400), new Point(500, 100));
                case 3:
                    return
                       Geometry_Vector_Graphics_Editor.CoordinateRoutines.CalculateRectangleCoordinatesByTwoOppositePoints(new Point(0, 300), new Point(300, 0));
                //TODO more tests
                // case 4:
                //     return Geometry_Vector_Graphics_Editor.CoordinateRoutines.CalculateSquareCoordinatesByTwoPoints(new Point(800, 800), new Point(200, 200));

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

//TODO more tests + negative tests