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
    public partial class EdgeListGraphTVertexTEdgeTest
    {
        [TestMethod]
        [PexRaisedException(typeof(ArgumentNullException))]
        [PexGeneratedBy(typeof(EdgeListGraphTVertexTEdgeTest))]
        public void ContainsEdge01()
        {
            EdgeListGraph<int, Edge<int>> edgeListGraph;
            bool b;
            edgeListGraph = new EdgeListGraph<int, Edge<int>>(false, false);
            b = this.ContainsEdge<int, Edge<int>>(edgeListGraph, (Edge<int>)null);
        }

        [TestMethod]
        [PexGeneratedBy(typeof(EdgeListGraphTVertexTEdgeTest))]
        public void ContainsEdge02()
        {
            EdgeListGraph<int, Edge<int>> edgeListGraph;
            Edge<int> edge;
            bool b;
            edgeListGraph = new EdgeListGraph<int, Edge<int>>(false, false);
            edge = EdgeFactory.Create(0, 3);
            b = this.ContainsEdge<int, Edge<int>>(edgeListGraph, edge);
            Assert.AreEqual<bool>(false, b);
        }

    }
}
