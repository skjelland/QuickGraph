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
        public void OutDegree01()
        {
            AdjacencyGraph<int, Edge<int>> adjacencyGraph;
            int i;
            adjacencyGraph = AdjacencyGraphFactory.Create(false, 0, 2);
            i = this.OutDegree<int, Edge<int>>(adjacencyGraph, 3);
        }

        [TestMethod]
        [Ignore]
        [Description("the test state was: path bounds exceeded")]
        public void OutDegree02()
        {
            AdjacencyGraph<int, Edge<int>> adjacencyGraph;
            int i;
            adjacencyGraph = AdjacencyGraphFactory.Create(false, 1073741824, 2);
            i = this.OutDegree<int, Edge<int>>(adjacencyGraph, 3);
        }

        [TestMethod]
        [PexRaisedException(typeof(TraceAssertionException))]
        [PexGeneratedBy(typeof(AdjacencyGraphTVertexTEdgeTest))]
        public void OutDegree03()
        {
            AdjacencyGraph<int, Edge<int>> adjacencyGraph;
            int i;
            adjacencyGraph = AdjacencyGraphFactory.Create(false, 2, 2);
            i = this.OutDegree<int, Edge<int>>(adjacencyGraph, 3);
        }

        [TestMethod]
        [PexRaisedException(typeof(TraceAssertionException))]
        [PexGeneratedBy(typeof(AdjacencyGraphTVertexTEdgeTest))]
        public void OutDegree04()
        {
            AdjacencyGraph<int, Edge<int>> adjacencyGraph;
            int i;
            adjacencyGraph = AdjacencyGraphFactory.Create(false, int.MinValue, 2);
            i = this.OutDegree<int, Edge<int>>(adjacencyGraph, 3);
        }

    }
}
