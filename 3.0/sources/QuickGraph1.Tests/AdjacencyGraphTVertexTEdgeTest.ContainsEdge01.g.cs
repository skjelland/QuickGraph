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
    public partial class AdjacencyGraphTVertexTEdgeTest
    {
        [TestMethod]
        [PexRaisedException(typeof(TraceAssertionException))]
        [PexGeneratedBy(typeof(AdjacencyGraphTVertexTEdgeTest))]
        public void ContainsEdge0101()
        {
            AdjacencyGraph<int, Edge<int>> adjacencyGraph;
            bool b;
            adjacencyGraph = AdjacencyGraphFactory.Create(false, 2, 3);
            b = this.ContainsEdge01<int, Edge<int>>(adjacencyGraph, (Edge<int>)null);
        }

        [TestMethod]
        [PexRaisedException(typeof(TraceAssertionException))]
        [PexGeneratedBy(typeof(AdjacencyGraphTVertexTEdgeTest))]
        public void ContainsEdge0102()
        {
            AdjacencyGraph<int, Edge<int>> adjacencyGraph;
            bool b;
            adjacencyGraph = AdjacencyGraphFactory.Create(false, int.MinValue, 2);
            b = this.ContainsEdge01<int, Edge<int>>(adjacencyGraph, (Edge<int>)null);
        }

        [TestMethod]
        [Ignore]
        [Description("the test state was: path bounds exceeded")]
        public void ContainsEdge0103()
        {
            AdjacencyGraph<int, Edge<int>> adjacencyGraph;
            bool b;
            adjacencyGraph = AdjacencyGraphFactory.Create(false, 1073741824, 3);
            b = this.ContainsEdge01<int, Edge<int>>(adjacencyGraph, (Edge<int>)null);
        }

        [TestMethod]
        [PexRaisedException(typeof(TraceAssertionException))]
        [PexGeneratedBy(typeof(AdjacencyGraphTVertexTEdgeTest))]
        public void ContainsEdge0104()
        {
            AdjacencyGraph<int, Edge<int>> adjacencyGraph;
            Edge<int> edge;
            bool b;
            adjacencyGraph = AdjacencyGraphFactory.Create(false, 2, 3);
            edge = EdgeFactory.Create(5, 6);
            b = this.ContainsEdge01<int, Edge<int>>(adjacencyGraph, edge);
        }

        [TestMethod]
        [PexRaisedException(typeof(TraceAssertionException))]
        [PexGeneratedBy(typeof(AdjacencyGraphTVertexTEdgeTest))]
        public void ContainsEdge0105()
        {
            AdjacencyGraph<int, Edge<int>> adjacencyGraph;
            Edge<int> edge;
            bool b;
            adjacencyGraph = AdjacencyGraphFactory.Create(false, int.MinValue, 3);
            edge = EdgeFactory.Create(4, 5);
            b = this.ContainsEdge01<int, Edge<int>>(adjacencyGraph, edge);
        }

    }
}
