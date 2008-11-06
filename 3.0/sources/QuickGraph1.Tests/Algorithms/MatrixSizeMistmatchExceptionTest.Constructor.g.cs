// This file contains automatically generated unit tests.
// Do NOT modify this file manually.
// 
// When Pex is invoked again,
// it might remove or update any previously generated unit tests.
// 
// If the contents of this file becomes outdated, e.g. if it does not
// compile anymore, you may delete this file and invoke Pex again.
using System;
using QuickGraph.Algorithms.Matrix;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.Pex.Framework.Generated;

namespace QuickGraph.Algorithms
{
    public partial class MatrixSizeMistmatchExceptionTest
    {
        [TestMethod]
        [PexRaisedException(typeof(NullReferenceException))]
        [PexGeneratedBy(typeof(MatrixSizeMistmatchExceptionTest))]
        public void Constructor04()
        {
            MatrixSizeMistmatchException matrixSizeMistmatchException;
            matrixSizeMistmatchException =
              this.Constructor((DoubleDenseMatrix)null, (DoubleDenseMatrix)null);
            // validation of result values is supported for primitive types only
        }

        [TestMethod]
        [PexGeneratedBy(typeof(MatrixSizeMistmatchExceptionTest))]
        public void Constructor05()
        {
            DoubleDenseMatrix doubleDenseMatrix;
            MatrixSizeMistmatchException matrixSizeMistmatchException;
            doubleDenseMatrix = new DoubleDenseMatrix(0, 0);
            matrixSizeMistmatchException =
              this.Constructor(doubleDenseMatrix, doubleDenseMatrix);
            // validation of result values is supported for primitive types only
        }

    }
}
