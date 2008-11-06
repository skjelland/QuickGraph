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
        public void ContainsEdge02()
        {
            AdjacencyGraph<int, Edge<int>> adjacencyGraph;
            bool b;
            adjacencyGraph = AdjacencyGraphFactory.Create(false, 0, 2);
            b = this.ContainsEdge<int, Edge<int>>(adjacencyGraph, 3, 4);
        }

        [TestMethod]
        [Ignore]
        [Description("the test state was: path bounds exceeded")]
        public void ContainsEdge03()
        {
            AdjacencyGraph<int, Edge<int>> adjacencyGraph;
            bool b;
            adjacencyGraph = AdjacencyGraphFactory.Create(false, 1073741824, 2);
            b = this.ContainsEdge<int, Edge<int>>(adjacencyGraph, 3, 4);
        }

        [TestMethod]
        [PexRaisedException(typeof(TraceAssertionException))]
        [PexGeneratedBy(typeof(AdjacencyGraphTVertexTEdgeTest))]
        public void ContainsEdge04()
        {
            AdjacencyGraph<int, Edge<int>> adjacencyGraph;
            bool b;
            adjacencyGraph = AdjacencyGraphFactory.Create(false, 2, 2);
            b = this.ContainsEdge<int, Edge<int>>(adjacencyGraph, 3, 4);
        }

        [TestMethod]
        [PexRaisedException(typeof(TraceAssertionException))]
        [PexGeneratedBy(typeof(AdjacencyGraphTVertexTEdgeTest))]
        public void ContainsEdge05()
        {
            AdjacencyGraph<int, Edge<int>> adjacencyGraph;
            bool b;
            adjacencyGraph = AdjacencyGraphFactory.Create(false, int.MinValue, 2);
            b = this.ContainsEdge<int, Edge<int>>(adjacencyGraph, 3, 4);
        }

    }
}
