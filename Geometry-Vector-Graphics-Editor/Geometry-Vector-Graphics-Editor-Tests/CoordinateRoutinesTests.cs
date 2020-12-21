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
            PointF[] actual = GetActualMockSquareCoordinatesByTwoAdjacentPoints(actualMockNumber);
            PointF[] expected = GetExpectedMockSquareCoordinatesByTwoAdjacentPoints(expectedMockNumber);
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


        public PointF[] GetExpectedMockSquareCoordinatesByTwoAdjacentPoints(int n)
        {
            switch (n)
            {
                case 1:
                    return
                        new PointF[] { new PointF(100, 100), new PointF(200, 200), new PointF(300, 100), new PointF(200, 0) };
                case 2:
                    return new PointF[4] { new PointF(200, 200), new PointF(100, 100), new PointF(0, 200), new PointF(100, 300) };
                case 3:
                    return new PointF[4] { new PointF(300, 0), new PointF(0, 300), new PointF(300, 600), new PointF(600, 300) };

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

        public PointF[] GetExpectedMockRectangleCoordinatesByTwoPoints(int n)
        {
            switch (n)
            {
                case 1:
                    return
                        new PointF[4] { new PointF(100, 100), new PointF(100, 200), new PointF(200, 200), new PointF(200, 100) };
                case 2:
                    return
                        new PointF[4] { new PointF(200, 100), new PointF(200, 400), new PointF(500, 400), new PointF(500, 100) };
                case 3:
                    return
                        new PointF[4] { new PointF(0, 0), new PointF(0, 300), new PointF(300, 300), new PointF(300, 0) };


                default:
                    throw new Exception();
            }
        }

        public PointF[] GetActualMockSquareCoordinatesByTwoAdjacentPoints(int n)
        {
            switch (n)
            {
                case 1:
                    return
                       Geometry_Vector_Graphics_Editor.CoordinateRoutines.CalculateSquareCoordinatesByTwoAdjacentPoints(new PointF(100, 100), new PointF(200, 200));
                case 2:
                    return
                       Geometry_Vector_Graphics_Editor.CoordinateRoutines.CalculateSquareCoordinatesByTwoAdjacentPoints(new PointF(200, 200), new PointF(100, 100));
                case 3:
                    return
                       Geometry_Vector_Graphics_Editor.CoordinateRoutines.CalculateSquareCoordinatesByTwoAdjacentPoints(new PointF(300, 0), new PointF(0, 300));

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

        public PointF[] GetActualMockSquareRectangleCoordinatesByTwoPointsTopLeftBottomRight(int n)
        {
            switch (n)
            {
                case 1:
                    return
                       Geometry_Vector_Graphics_Editor.CoordinateRoutines.CalculateRectangleCoordinatesByTwoOppositePoints(new PointF(100, 200), new PointF(200, 100));
                case 2:
                    return
                       Geometry_Vector_Graphics_Editor.CoordinateRoutines.CalculateRectangleCoordinatesByTwoOppositePoints(new PointF(200, 400), new PointF(500, 100));
                case 3:
                    return
                       Geometry_Vector_Graphics_Editor.CoordinateRoutines.CalculateRectangleCoordinatesByTwoOppositePoints(new PointF(0, 300), new PointF(300, 0));
               

                default:
                    throw new Exception();
            }
        }

        [Test, TestCaseSource(typeof(GetRectangularTriangleMock))]
        public void CalculateRectangularTriangleCoordinatesByTwoPoints(PointF p1, PointF p2, PointF[] expected)
        {
            PointF[] actual;
            actual = Geometry_Vector_Graphics_Editor.CoordinateRoutines.CalculateRectangularTriangleCoordinatesByTwoPoints(p1, p2);
            Assert.AreEqual(expected, actual);
        }

        [Test, TestCaseSource(typeof(GetIsoscelesTriangleMock))]
        public void CalculateIsoscelesTriangleCoordinatesByTwoPoints(PointF p1, PointF p2, PointF[] expected)
        {
            PointF[] actual;
            actual = Geometry_Vector_Graphics_Editor.CoordinateRoutines.CalculateIsoscelesTriangleCoordinatesByTwoPoints(p1, p2);
            Assert.AreEqual(expected, actual);
        }


        [Test, TestCaseSource(typeof(GetCicleBySquareMock))]

        public void CalculateCirclePointBySquareTest(PointF squareLUPoint, PointF squareOppositePoint, PointF[] expected)
        {
            PointF[] actual;
            actual = Geometry_Vector_Graphics_Editor.CoordinateRoutines.CalculateCicleBySquare(squareLUPoint, squareOppositePoint);
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
            yield return new object[] { new PointF(0, 0), new PointF(8, 10), 
                new PointF[] { new PointF(0, 0), new PointF(8, 10), new PointF(8, 0), new PointF(0, 10),
                new PointF(0, 5), new PointF(8, 5), new PointF(4, 5), new PointF(4, 10),new PointF(4, 0) } };
            yield return new object[] { new PointF(1, 1), new PointF(5, 11), 
                new PointF[] { new PointF(1, 1), new PointF(5,11), new PointF(5, 1), new PointF(1, 11),
               new PointF(1, 6), new PointF(5,6), new PointF(3, 6),new PointF(3, 11), new PointF(3,1),} };
            yield return new object[] { new PointF(0, 0), new PointF(6, 6), 
            new PointF[] { new PointF(0, 0), new PointF(6,6), new PointF(6, 0), new PointF( 0,6 ), 
                new PointF( 0, 3), new PointF ( 6, 3 ), new PointF(3, 3), new PointF(3, 6), new PointF(3, 0) } };
        }

    } 

    public class GetCicleBySquareMock : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            yield return new object[] { new PointF(5, 5), new PointF(9, 9), 
                new PointF[] { new PointF(5, 5), new PointF(9,9), new PointF(9, 5), new PointF(5,9),
                new PointF(5, 7),new PointF(9, 7),new PointF(7, 7),new PointF(7, 9),new PointF(7, 5),} };
            yield return new object[] { new PointF(2, 2), new PointF(0, 0), 
                new PointF[] { new PointF(2, 2), new PointF(0,0), new PointF(0, 2), new PointF(2,0),
                    new PointF(2, 1),new PointF(0, 1),new PointF(1, 1),new PointF(1, 0),new PointF(1, 2) } };


            yield return new object[] { new PointF(0, 0), new PointF(0, 0),
                new PointF[] { new PointF(0, 0), new PointF(0, 0),new PointF(0, 0), new PointF(0, 0), 
                    new PointF(0, 0),new PointF(0, 0),new PointF(0, 0),new PointF(0, 0),new PointF(0, 0) } };
        }

    }

    public class GetRectangularTriangleMock : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            yield return new object[] { new PointF(0, 10), new PointF(10, 0), new PointF[] { new PointF(0, 10), new PointF(10, 0), new PointF(0, 0) } };
            yield return new object[] { new PointF(0, 0), new PointF(10, 10), new PointF[] { new PointF(0, 0), new PointF(10, 10), new PointF(10, 0) } };
            yield return new object[] { new PointF(10, 20), new PointF(30, 10), new PointF[] { new PointF(10, 20), new PointF(30, 10), new PointF(10, 10) } };
      }
    }

    public class GetIsoscelesTriangleMock : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            yield return new object[] { new PointF(20, 10), new PointF(30, 0), new PointF[] { new PointF(20, 10), new PointF(30, 0), new PointF(10, 0) } };
            yield return new object[] { new PointF(20, 20), new PointF(30, 30), new PointF[] { new PointF(20, 20), new PointF(30, 30), new PointF(40, 20) } };
            yield return new object[] { new PointF(10, 20), new PointF(20, 10), new PointF[] { new PointF(10, 20), new PointF(20, 10), new PointF(0, 10) } };
        }
    }
}
