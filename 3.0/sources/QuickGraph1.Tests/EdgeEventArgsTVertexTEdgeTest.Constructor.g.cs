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
    public partial class EdgeEventArgsTVertexTEdgeTest
    {
        [TestMethod]
        [PexRaisedException(typeof(TraceAssertionException))]
        [PexGeneratedBy(typeof(EdgeEventArgsTVertexTEdgeTest))]
        public void Constructor01()
        {
            EdgeEventArgs<int, Edge<int>> edgeEventArgs;
            edgeEventArgs = this.Constructor<int, Edge<int>>((Edge<int>)null);
            // validation of result values is supported for primitive types only
        }

        [TestMethod]
        [PexGeneratedBy(typeof(EdgeEventArgsTVertexTEdgeTest))]
        public void Constructor02()
        {
            Edge<int> edge;
            EdgeEventArgs<int, Edge<int>> edgeEventArgs;
            edge = new Edge<int>(0, 2);
            edgeEventArgs = this.Constructor<int, Edge<int>>(edge);
            // validation of result values is supported for primitive types only
        }

        [TestMethod]
        [ExpectedException(typeof(TraceAssertionException))]
        [PexGeneratedBy(typeof(EdgeEventArgsTVertexTEdgeTest))]
        public void Constructor03()
        {
            EdgeEventArgs<int, Edge<int>> edgeEventArgs;
            edgeEventArgs = this.Constructor<int, Edge<int>>((Edge<int>)null);
            // validation of result values is supported for primitive types only
        }

        [TestMethod]
        [PexGeneratedBy(typeof(EdgeEventArgsTVertexTEdgeTest))]
        public void Constructor04()
        {
            Edge<int> edge;
            EdgeEventArgs<int, Edge<int>> edgeEventArgs;
            edge = EdgeFactory.Create(0, 2);
            edgeEventArgs = this.Constructor<int, Edge<int>>(edge);
            // validation of result values is supported for primitive types only
        }

    }
}
