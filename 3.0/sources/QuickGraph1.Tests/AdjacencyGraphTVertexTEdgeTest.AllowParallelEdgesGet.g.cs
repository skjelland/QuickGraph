// This file contains automatically generated unit tests.
// Do NOT modify this file manually.
// 
// When Pex is invoked again,
// it might remove or update any previously generated unit tests.
// 
// If the contents of this file becomes outdated, e.g. if it does not
// compile anymore, you may delete this file and invoke Pex again.
using System;
using Microsoft.Pex.Framework;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.Pex.Framework.Generated;

namespace QuickGraph
{
    public partial class AdjacencyGraphTVertexTEdgeTest
    {
        [TestMethod]
        [PexGeneratedBy(typeof(AdjacencyGraphTVertexTEdgeTest))]
        public void AllowParallelEdgesGet01()
        {
            PexStore.Generated.Clear();
            AdjacencyGraph<int, Edge<int>> adjacencyGraph;
            adjacencyGraph = AdjacencyGraphFactory.Create(false, 0, 2);
            this.AllowParallelEdgesGet<int, Edge<int>>(adjacencyGraph);
            PexStore.Generated.Validate("result", "false");
        }

        [TestMethod]
        [PexGeneratedBy(typeof(AdjacencyGraphTVertexTEdgeTest))]
        public void AllowParallelEdgesGet02()
        {
            PexStore.Generated.Clear();
            AdjacencyGraph<int, Edge<int>> adjacencyGraph;
            adjacencyGraph = AdjacencyGraphFactory.Create(false, int.MinValue, 2);
            this.AllowParallelEdgesGet<int, Edge<int>>(adjacencyGraph);
            PexStore.Generated.Validate("result", "false");
        }

        [TestMethod]
        [Ignore]
        [Description("the test state was: path bounds exceeded")]
        public void AllowParallelEdgesGet03()
        {
            AdjacencyGraph<int, Edge<int>> adjacencyGraph;
            adjacencyGraph = AdjacencyGraphFactory.Create(false, 1073741824, 2);
            this.AllowParallelEdgesGet<int, Edge<int>>(adjacencyGraph);
        }

    }
}
