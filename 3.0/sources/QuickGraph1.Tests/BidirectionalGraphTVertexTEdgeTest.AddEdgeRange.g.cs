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
    public partial class BidirectionalGraphTVertexTEdgeTest
    {
        [TestMethod]
        [ExpectedException(typeof(TraceAssertionException))]
        [PexGeneratedBy(typeof(BidirectionalGraphTVertexTEdgeTest))]
        public void AddEdgeRange01()
        {
            BidirectionalGraph<int, Edge<int>> bidirectionalGraph;
            bidirectionalGraph = new BidirectionalGraph<int, Edge<int>>(false, 2);
            bidirectionalGraph.EdgeCapacity = 3;
            this.AddEdgeRange<int, Edge<int>>
                (bidirectionalGraph, (IEnumerable<Edge<int>>)null);
        }

        [TestMethod]
        [ExpectedException(typeof(TraceAssertionException))]
        [PexGeneratedBy(typeof(BidirectionalGraphTVertexTEdgeTest))]
        public void AddEdgeRange02()
        {
            BidirectionalGraph<int, Edge<int>> bidirectionalGraph;
            bidirectionalGraph = new BidirectionalGraph<int, Edge<int>>(false, int.MinValue);
            bidirectionalGraph.EdgeCapacity = 2;
            this.AddEdgeRange<int, Edge<int>>
                (bidirectionalGraph, (IEnumerable<Edge<int>>)null);
        }

        [TestMethod]
        [Ignore]
        [Description("the test state was: path bounds exceeded")]
        public void AddEdgeRange03()
        {
            BidirectionalGraph<int, Edge<int>> bidirectionalGraph;
            bidirectionalGraph = new BidirectionalGraph<int, Edge<int>>(false, 1073741824);
            bidirectionalGraph.EdgeCapacity = 3;
            this.AddEdgeRange<int, Edge<int>>
                (bidirectionalGraph, (IEnumerable<Edge<int>>)null);
        }

    }
}
