// This file contains automatically generated unit tests.
// Do NOT modify this file manually.
// 
// When Pex is invoked again,
// it might remove or update any previously generated unit tests.
// 
// If the contents of this file becomes outdated, e.g. if it does not
// compile anymore, you may delete this file and invoke Pex again.
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.Pex.Framework.Generated;

namespace QuickGraph
{
    public partial class BidirectionalMatrixGraphTEdgeTest
    {
        [TestMethod]
        [PexRaisedException(typeof(ArgumentOutOfRangeException))]
        [PexGeneratedBy(typeof(BidirectionalMatrixGraphTEdgeTest))]
        public void Constructor01()
        {
            BidirectionalMatrixGraph<Edge<int>> bidirectionalMatrixGraph;
            bidirectionalMatrixGraph = this.Constructor<Edge<int>>(0);
            // validation of result values is supported for primitive types only
        }

        [TestMethod]
        [PexRaisedException(typeof(OutOfMemoryException))]
        [PexGeneratedBy(typeof(BidirectionalMatrixGraphTEdgeTest))]
        public void Constructor02()
        {
            BidirectionalMatrixGraph<Edge<int>> bidirectionalMatrixGraph;
            bidirectionalMatrixGraph = this.Constructor<Edge<int>>(1073741824);
            // validation of result values is supported for primitive types only
        }

    }
}
