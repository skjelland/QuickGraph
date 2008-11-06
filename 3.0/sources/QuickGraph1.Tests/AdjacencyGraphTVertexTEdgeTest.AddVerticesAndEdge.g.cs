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
using Microsoft.Pex.Framework.Exceptions;
using Microsoft.Pex.Framework.Generated;

namespace QuickGraph
{
    public partial class AdjacencyGraphTVertexTEdgeTest
    {
        [TestMethod]
        [ExpectedException(typeof(TraceAssertionException))]
        [PexGeneratedBy(typeof(AdjacencyGraphTVertexTEdgeTest))]
        public void AddVerticesAndEdge01()
        {
            AdjacencyGraph<int, Edge<int>> adjacencyGraph;
            bool b;
            adjacencyGraph = AdjacencyGraphFactory.Create(false, 2, 3);
            b = this.AddVerticesAndEdge<int, Edge<int>>(adjacencyGraph, (Edge<int>)null);
        }

        [TestMethod]
        [ExpectedException(typeof(TraceAssertionException))]
        [PexGeneratedBy(typeof(AdjacencyGraphTVertexTEdgeTest))]
        public void AddVerticesAndEdge02()
        {
            AdjacencyGraph<int, Edge<int>> adjacencyGraph;
            bool b;
            adjacencyGraph = AdjacencyGraphFactory.Create(false, int.MinValue, 2);
            b = this.AddVerticesAndEdge<int, Edge<int>>(adjacencyGraph, (Edge<int>)null);
        }

        [TestMethod]
        [Ignore]
        [Description("the test state was: path bounds exceeded")]
        public void AddVerticesAndEdge03()
        {
            AdjacencyGraph<int, Edge<int>> adjacencyGraph;
            bool b;
            adjacencyGraph = AdjacencyGraphFactory.Create(false, 1073741824, 3);
            b = this.AddVerticesAndEdge<int, Edge<int>>(adjacencyGraph, (Edge<int>)null);
        }

        [TestMethod]
        [PexGeneratedBy(typeof(AdjacencyGraphTVertexTEdgeTest))]
        public void AddVerticesAndEdge04()
        {
            AdjacencyGraph<int, Edge<int>> adjacencyGraph;
            Edge<int> edge;
            bool b;
            adjacencyGraph = AdjacencyGraphFactory.Create(false, 2, 0);
            edge = EdgeFactory.Create(5, 6);
            b = this.AddVerticesAndEdge<int, Edge<int>>(adjacencyGraph, edge);
            Assert.AreEqual<bool>(true, b);
        }

        [TestMethod]
        [PexGeneratedBy(typeof(AdjacencyGraphTVertexTEdgeTest))]
        public void AddVerticesAndEdge05()
        {
            AdjacencyGraph<int, Edge<int>> adjacencyGraph;
            Edge<int> edge;
            bool b;
            adjacencyGraph = AdjacencyGraphFactory.Create(true, 2, 0);
            edge = EdgeFactory.Create(5, 6);
            b = this.AddVerticesAndEdge<int, Edge<int>>(adjacencyGraph, edge);
            Assert.AreEqual<bool>(true, b);
        }

        [TestMethod]
        [PexGeneratedBy(typeof(AdjacencyGraphTVertexTEdgeTest))]
        public void AddVerticesAndEdge06()
        {
            AdjacencyGraph<int, Edge<int>> adjacencyGraph;
            Edge<int> edge;
            bool b;
            adjacencyGraph = AdjacencyGraphFactory.Create(false, int.MinValue, -1860084428);
            edge = EdgeFactory.Create(0, 0);
            b = this.AddVerticesAndEdge<int, Edge<int>>(adjacencyGraph, edge);
            Assert.AreEqual<bool>(true, b);
        }

        [TestMethod]
        [PexGeneratedBy(typeof(AdjacencyGraphTVertexTEdgeTest))]
        public void AddVerticesAndEdge07()
        {
            AdjacencyGraph<int, Edge<int>> adjacencyGraph;
            Edge<int> edge;
            bool b;
            adjacencyGraph = AdjacencyGraphFactory.Create(false, int.MinValue, 1);
            edge = EdgeFactory.Create(0, 9217);
            b = this.AddVerticesAndEdge<int, Edge<int>>(adjacencyGraph, edge);
            Assert.AreEqual<bool>(true, b);
        }

    }
}
