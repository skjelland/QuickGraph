using Microsoft.Pex.Framework;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using QuickGraph.Algorithms;
using QuickGraph.Algorithms.Matrix;
using System;

namespace QuickGraph.Algorithms
{
    /// <summary>
    /// This class contains parameterized unit tests for MatrixSizeMistmatchException
    /// </summary>
    [TestClass]
    [PexClass(typeof(MatrixSizeMistmatchException))]
    public partial class MatrixSizeMistmatchExceptionTest
    {
        [PexMethod]
        public MatrixSizeMistmatchException Constructor(DoubleDenseMatrix left, DoubleDenseMatrix right)
        {
            MatrixSizeMistmatchException target
               = new MatrixSizeMistmatchException(left, right);
            return target;
            // TODO: add assertions to method MatrixSizeMistmatchExceptionTest.Constructor(DoubleDenseMatrix, DoubleDenseMatrix)
        }
        
        [PexMethod]
        public MatrixSizeMistmatchException Constructor01()
        {
            MatrixSizeMistmatchException target = new MatrixSizeMistmatchException();
            return target;
            // TODO: add assertions to method MatrixSizeMistmatchExceptionTest.Constructor01()
        }
        
        [PexMethod]
        public MatrixSizeMistmatchException Constructor02(string message)
        {
            MatrixSizeMistmatchException target = new MatrixSizeMistmatchException(message);
            return target;
            // TODO: add assertions to method MatrixSizeMistmatchExceptionTest.Constructor02(String)
        }
        
        [PexMethod]
        public MatrixSizeMistmatchException Constructor03(string message, Exception inner)
        {
            MatrixSizeMistmatchException target
               = new MatrixSizeMistmatchException(message, inner);
            return target;
            // TODO: add assertions to method MatrixSizeMistmatchExceptionTest.Constructor03(String, Exception)
        }
        
    }
}
