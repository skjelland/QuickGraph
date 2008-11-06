// This file contains automatically generated unit tests.
// Do NOT modify this file manually.
// 
// When Pex is invoked again,
// it might remove or update any previously generated unit tests.
// 
// If the contents of this file becomes outdated, e.g. if it does not
// compile anymore, you may delete this file and invoke Pex again.
using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.Pex.Framework.Exceptions;
using Microsoft.Pex.Framework.Generated;

namespace QuickGraph
{
    public partial class BidirectionalMatrixGraphTEdgeTest
    {
        [TestMethod]
        [ExpectedException(typeof(TraceAssertionException))]
        [PexGeneratedBy(typeof(BidirectionalMatrixGraphTEdgeTest))]
        public void AddEdgeRange01()
        {
            BidirectionalMatrixGraph<Edge<int>> bidirectionalMatrixGraph;
            bidirectionalMatrixGraph = new BidirectionalMatrixGraph<Edge<int>>(2);
            this.AddEdgeRange<Edge<int>>
                (bidirectionalMatrixGraph, (IEnumerable<Edge<int>>)null);
        }

    }
}
