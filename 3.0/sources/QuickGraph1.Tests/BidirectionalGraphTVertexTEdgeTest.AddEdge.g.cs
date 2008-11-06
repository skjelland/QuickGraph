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
using Microsoft.Pex.Framework.Exceptions;

namespace QuickGraph
{
    public partial class BidirectionalGraphTVertexTEdgeTest
    {
        [TestMethod]
        [PexRaisedException(typeof(TraceAssertionException))]
        [PexGeneratedBy(typeof(BidirectionalGraphTVertexTEdgeTest))]
        public void AddEdge01()
        {
            BidirectionalGraph<int, Edge<int>> bidirectionalGraph;
            bool b;
            bidirectionalGraph = new BidirectionalGraph<int, Edge<int>>(false, 2);
            bidirectionalGraph.EdgeCapacity = 3;
            b = this.AddEdge<int, Edge<int>>(bidirectionalGraph, (Edge<int>)null);
        }

        [TestMethod]
        [PexRaisedException(typeof(TraceAssertionException))]
        [PexGeneratedBy(typeof(BidirectionalGraphTVertexTEdgeTest))]
        public void AddEdge02()
        {
            BidirectionalGraph<int, Edge<int>> bidirectionalGraph;
            bool b;
            bidirectionalGraph = new BidirectionalGraph<int, Edge<int>>(false, int.MinValue);
            bidirectionalGraph.EdgeCapacity = 2;
            b = this.AddEdge<int, Edge<int>>(bidirectionalGraph, (Edge<int>)null);
        }

        [TestMethod]
        [Ignore]
        [Description("the test state was: path bounds exceeded")]
        public void AddEdge03()
        {
            BidirectionalGraph<int, Edge<int>> bidirectionalGraph;
            bool b;
            bidirectionalGraph = new BidirectionalGraph<int, Edge<int>>(false, 1073741824);
            bidirectionalGraph.EdgeCapacity = 3;
            b = this.AddEdge<int, Edge<int>>(bidirectionalGraph, (Edge<int>)null);
        }

        [TestMethod]
        [PexRaisedException(typeof(TraceAssertionException))]
        [PexGeneratedBy(typeof(BidirectionalGraphTVertexTEdgeTest))]
        public void AddEdge04()
        {
            BidirectionalGraph<int, Edge<int>> bidirectionalGraph;
            Edge<int> edge;
            bool b;
            bidirectionalGraph = new BidirectionalGraph<int, Edge<int>>(false, 2);
            bidirectionalGraph.EdgeCapacity = 3;
            edge = EdgeFactory.Create(5, 6);
            b = this.AddEdge<int, Edge<int>>(bidirectionalGraph, edge);
        }

        [TestMethod]
        [PexRaisedException(typeof(TraceAssertionException))]
        [PexGeneratedBy(typeof(BidirectionalGraphTVertexTEdgeTest))]
        public void AddEdge05()
        {
            BidirectionalGraph<int, Edge<int>> bidirectionalGraph;
            Edge<int> edge;
            bool b;
            bidirectionalGraph = new BidirectionalGraph<int, Edge<int>>(false, int.MinValue);
            bidirectionalGraph.EdgeCapacity = 3;
            edge = EdgeFactory.Create(4, 5);
            b = this.AddEdge<int, Edge<int>>(bidirectionalGraph, edge);
        }

    }
}
