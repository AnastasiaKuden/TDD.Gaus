using NUnit.Framework;
using Gaus;

namespace GausTest
{
    [TestFixture(1)]
    [TestFixture(2)]
    [TestFixture(3)]
    [TestFixture(4)]
    [TestFixture(5)]
    [TestFixture(6)]
    [TestFixture(7)]
    [TestFixture(8)]

    public class Tests
    {
        int a;
        public Tests(int q)
        {
            a = q;
        }

        double[,] matrixForTest;
        int rowForTest;
        double dividerForTest;
        double[,] expectedForDivideRow;        

        double[] expectedForCutResult;

        int firstRowForTest, secondRowForTest;
        double countForTest;
        double[,] expectedForSubtractRow;

        double[,] expectedForCreateDownOneZero;
        double[,] expectedForCreateUpOneZero;

        double[] expectedForSolve;


        [OneTimeSetUp]
        public void CreateMatrix()
        {
            switch (a)
            {
                case 1:
                    matrixForTest = new double[,] { { 2, -3, 1, -1}, { 5, 2, -1, 0 }, { 1, -1, 2, 3 } };
                    rowForTest = 0;
                    dividerForTest = 2;
                    expectedForDivideRow = new double[,] { { 1, -1.5, 0.5, -0.5 }, { 5, 2, -1, 0 }, { 1, -1, 2, 3 } };

                    expectedForCutResult = new double[] { -1, 0, 3 };

                    firstRowForTest = 0;
                    secondRowForTest = 1;
                    countForTest = 1;
                    expectedForSubtractRow = new double[,] { { 2, -3, 1, -1 }, { 3, 5, -2, 1 }, { 1, -1, 2, 3 } };

                    expectedForCreateDownOneZero = new double[,] { { 1, -1.5, 0.5, -0.5 }, { 0, 1, -0.36842105263157894, 0.26315789473684210 }, { 0, 0, 1, 2 } };
                    expectedForCreateUpOneZero = new double[,] { { 13, 0, 1, 2 }, { 6, 1, 1, 3 }, { 1, -1, 2, 3 } };

                    expectedForSolve = new double[] {0, 1, 2};
                    break;

                case 2:
                    matrixForTest = new double[,] { { 2, -4, -6}, { 2, 1, 4 } };
                    rowForTest = 1;
                    dividerForTest = 1;
                    expectedForDivideRow = new double[,] { { 2, -4, -6 }, { 2, 1, 4 } };

                    expectedForCutResult = new double[] { -6, 4};

                    firstRowForTest = 1;
                    secondRowForTest = 0;
                    countForTest = 2;
                    expectedForSubtractRow = new double[,] { { -2, -6, -14 }, { 2, 1, 4 } };

                    expectedForCreateDownOneZero = new double[,] { { 1, -2, -3 }, { 0, 1, 2 } };
                    expectedForCreateUpOneZero = new double[,] { { 10, 0, 10 }, { 2, 1, 4 } };

                    expectedForSolve = new double[] { 1, 2 };
                    break;

                case 3:
                    matrixForTest = new double[,] { { 3, 2, 0.5, 2 }, { 1, -1, 2, 1 }, { 3, 2, 1, 3 } };
                    rowForTest = 2;
                    dividerForTest = 3;
                    expectedForDivideRow = new double[,] { { 3, 2, 0.5, 2 }, { 1, -1, 2, 1 }, { 1, 0.66666666666666663, 0.33333333333333331, 1 } };

                    expectedForCutResult = new double[] { 2, 1, 3 };

                    firstRowForTest = 1;
                    secondRowForTest = 2;
                    countForTest = 1;
                    expectedForSubtractRow = new double[,] { { 3, 2, 0.5, 2 }, { 1, -1, 2, 1 }, { 2, 3, -1, 2 } };

                    expectedForCreateDownOneZero = new double[,] { { 1, 0.66666666666666663, 0.16666666666666667, 0.66666666666666663 }, { 0, 1, -1.09999999999999999, -0.20000000000000004 }, { 0, 0, 1, 2 } };
                    expectedForCreateUpOneZero = new double[,] { { 6.5, 6, 0, 5.5 }, { -5, -5, 0, -5 }, { 3, 2, 1, 3 } };

                    expectedForSolve = new double[] { -1, 2, 2 };
                    break;

                case 4:
                    matrixForTest = new double[,] { { 1, 2, 5, -9 }, { 1, -1, 3, 2 }, { 3, -6, -1, 25 } };
                    rowForTest = 0;
                    dividerForTest = 2;
                    expectedForDivideRow = new double[,] { { 0.5, 1, 2.5, -4.5 }, { 1, -1, 3, 2 }, { 3, -6, -1, 25 } };

                    expectedForCutResult = new double[] { -9, 2, 25 };

                    firstRowForTest = 0;
                    secondRowForTest = 1;
                    countForTest = -3;
                    expectedForSubtractRow = new double[,] { { 1, 2, 5, -9 }, { 4, 5, 18, -25 }, { 3, -6, -1, 25 } };

                    expectedForCreateDownOneZero = new double[,] { { 1, 2, 5, -9 }, { 0, 1, 0.66666666666666663, -3.6666666666666665 }, { 0, 0, 1, -1 } };
                    expectedForCreateUpOneZero = new double[,] { { 242, -512, -182, 2202 }, { -8, 17, 6, -73 }, { 3, -6, -1, 25 } };

                    expectedForSolve = new double[] { 2, -3, -1 };
                    break;

                case 5:
                    matrixForTest = new double[,] { { 1, 2, 3, -2, 1 }, { 2, -1, -2, -3, 2 }, { 3, 2, -1, 2, -5 }, {2, -3, 2, 1, 11 } };
                    rowForTest = 3;
                    dividerForTest = 2;
                    expectedForDivideRow = new double[,] { { 1, 2, 3, -2, 1 }, { 2, -1, -2, -3, 2 }, { 3, 2, -1, 2, -5 }, { 1, -1.5, 1, 0.5, 5.5 } };

                    expectedForCutResult = new double[] { 1, 2, -5, 11 };

                    firstRowForTest = 0;
                    secondRowForTest = 3;
                    countForTest = -1;
                    expectedForSubtractRow = new double[,] { { 1, 2, 3, -2, 1 }, { 2, -1, -2, -3, 2 }, { 3, 2, -1, 2, -5 }, { 3, -1, 5, -1, 12 } };

                    expectedForCreateDownOneZero = new double[,] { { 1, 2, 3, -2, 1 }, { 0, 1, 1.6, -0.2, 0 }, { 0, 0, 1, -2.0000000000000004d, 2.2222222222222223 }, { 0, 0, 0, 1, -0.38888888888888895 } };
                    expectedForCreateUpOneZero = new double[,] { { 732, -2580, 1482, 0, 8792 }, { 12, -42, 24, 0, 143 }, { -1, 8, -5, 0, -27 }, { 2, -3, 2, 1, 11 } };

                    expectedForSolve = new double[] { 0.66666666666666785, -2.38888888888888889, 1.4444444444444442, -0.38888888888888895 };
                    break;

                case 6:
                    matrixForTest = new double[,] { { -8, -7, -1, -5}, { 6, 1, -8, -79}, { -9, 3, 4, 68}};
                    rowForTest = 1;
                    dividerForTest = -8;
                    expectedForDivideRow = new double[,] { { -8, -7, -1, -5 }, { -0.75, -0.125, 1, 9.875 }, { -9, 3, 4, 68 } };

                    expectedForCutResult = new double[] { -5, -79, 68 };

                    firstRowForTest = 2;
                    secondRowForTest = 1;
                    countForTest = 0;
                    expectedForSubtractRow = new double[,] { { -8, -7, -1, -5 }, { 6, 1, -8, -79 }, { -9, 3, 4, 68 } };

                    expectedForCreateDownOneZero = new double[,] { { 1, 0.875, 0.125, 0.625 }, { 0, 1, 2.05882352941176471, 19.47058823529411765 }, { 0, 0, 1, 8 } }; ;
                    expectedForCreateUpOneZero = new double[,] { { -281, 96, 99, 1923 }, { -66, 25, 24, 465 }, { -9, 3, 4, 68 } };

                    expectedForSolve = new double[] { -3, 3, 8 };
                    break;

                case 7:
                    matrixForTest = new double[,] { { -5, 6, 8, 62 }, { 3, -9, -5, -27 }, { 1, -5, 0, 0 } };
                    rowForTest = 2;
                    dividerForTest = -5;
                    expectedForDivideRow = new double[,] { { -5, 6, 8, 62 }, { 3, -9, -5, -27 }, { -0.2, 1, 0, 0 } };

                    expectedForCutResult = new double[] { 62, -27, 0 };

                    firstRowForTest = 2;
                    secondRowForTest = 0;
                    countForTest = 2;
                    expectedForSubtractRow = new double[,] { { -7, 16, 8, 62 }, { 3, -9, -5, -27 }, { 1, -5, 0, 0 } };

                    expectedForCreateDownOneZero = new double[,] { { 1, -1.2, -1.6, -12.4 }, { 0, 1, 0.037037037037036903, -1.8888888888888893 }, { 0, 0, 1, 3.0000000000000004 } };
                    expectedForCreateUpOneZero = new double[,] { { -381, 1610, 238, 1304 }, { 8, -34, -5, -27 }, { 1, -5, 0, 0 } };

                    expectedForSolve = new double[] { -10, -2, 3.0000000000000004 };
                    break;

                case 8:
                    matrixForTest = new double[,] { { -2, -9, 8, 61 }, { -4, -3, 0, -21 }, { -10, 0, -2, -76 } };
                    rowForTest = 2;
                    dividerForTest = -5;
                    expectedForDivideRow = new double[,] { { -2, -9, 8, 61 }, { -4, -3, 0, -21 }, { 2, 0, 0.4, 15.2 } };

                    expectedForCutResult = new double[] { 61, -21, -76 };

                    firstRowForTest = 0;
                    secondRowForTest = 2;
                    countForTest = 1;
                    expectedForSubtractRow = new double[,] { { -2, -9, 8, 61 }, { -4, -3, 0, -21 }, { -8, 9, -10, -137 } };

                    expectedForCreateDownOneZero = new double[,] { { 1, 4.5, -4, -30.5 }, { 0, 1, -1.06666666666666667, -9.53333333333333333 }, { 0, 0, 1, 8 } };
                    expectedForCreateUpOneZero = new double[,] { { 42, -36, 24, 480 }, { -4, -3, 0, -21 }, { -10, 0, -2, -76 } };

                    expectedForSolve = new double[] { 6, -1, 8 };
                    break;                
            }
        }

        [TearDown]
        public void Restore()
        {
            switch (a)
            {
                case 1:
                    matrixForTest = new double[,] { { 2, -3, 1, -1 }, { 5, 2, -1, 0 }, { 1, -1, 2, 3 } };                    
                    break;
                case 2:
                    matrixForTest = new double[,] { { 2, -4, -6 }, { 2, 1, 4 } };                    
                    break;
                case 3:
                    matrixForTest = new double[,] { { 3, 2, 0.5, 2 }, { 1, -1, 2, 1 }, { 3, 2, 1, 3 } };
                    break;
                case 4:
                    matrixForTest = new double[,] { { 1, 2, 5, -9 }, { 1, -1, 3, 2 }, { 3, -6, -1, 25 } };                    
                    break;
                case 5:
                    matrixForTest = new double[,] { { 1, 2, 3, -2, 1 }, { 2, -1, -2, -3, 2 }, { 3, 2, -1, 2, -5 }, { 2, -3, 2, 1, 11 } };                    
                    break;
                case 6:
                    matrixForTest = new double[,] { { -8, -7, -1, -5 }, { 6, 1, -8, -79 }, { -9, 3, 4, 68 } };                    
                    break;
                case 7:
                    matrixForTest = new double[,] { { -5, 6, 8, 62 }, { 3, -9, -5, -27 }, { 1, -5, 0, 0 } };                    
                    break;
                case 8:
                    matrixForTest = new double[,] { { -2, -9, 8, 61 }, { -4, -3, 0, -21 }, { -10, 0, -2, -76 } };                    
                    break;
            }
        }

        [Test]
        public void DivideRowTest()
        {
            double[,] actual = Matrix.DivideRow(matrixForTest, rowForTest, dividerForTest);
            Assert.AreEqual(expectedForDivideRow, actual);
        }

        [Test]
        public void CutResultTest()
        {
            double[] actual = Matrix.CutResult(matrixForTest);
            Assert.AreEqual(expectedForCutResult, actual);
        }

        [Test]
        public void SubtractRowsTest()
        {
            double[,] actual = Matrix.SubtractRows(matrixForTest, firstRowForTest, secondRowForTest, countForTest);
            Assert.AreEqual(expectedForSubtractRow, actual);
        }

        [Test]
        public void CreateDownOneZeroTest()
        {
            double[,] actual = Matrix.CreateDownOneZero(matrixForTest);
            Assert.AreEqual(expectedForCreateDownOneZero, actual);
        }

        [Test]
        public void CreateUpOneZeroTest()
        {
            double[,] actual = Matrix.CreateUpOneZero(matrixForTest);
            Assert.AreEqual(expectedForCreateUpOneZero, actual);
        }

        [Test]
        public void SolveTest()
        {
            double[] actual = Matrix.Solve(matrixForTest);
            Assert.AreEqual(expectedForSolve, actual);
        }
    }
}