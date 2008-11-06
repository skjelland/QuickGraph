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
    public partial class EdgeEventArgsTVertexTEdgeTest
    {
        [TestMethod]
        [PexGeneratedBy(typeof(EdgeEventArgsTVertexTEdgeTest))]
        public void EdgeGet01()
        {
            PexStore.Generated.Clear();
            Edge<int> edge;
            EdgeEventArgs<int, Edge<int>> edgeEventArgs;
            edge = new Edge<int>(0, 3);
            edgeEventArgs = new EdgeEventArgs<int, Edge<int>>(edge);
            this.EdgeGet<int, Edge<int>>(edgeEventArgs);
            PexStore.Generated.Validate("result", "0->3");
        }

        [TestMethod]
        [PexGeneratedBy(typeof(EdgeEventArgsTVertexTEdgeTest))]
        public void EdgeGet02()
        {
            PexStore.Generated.Clear();
            Edge<int> edge;
            EdgeEventArgs<int, Edge<int>> edgeEventArgs;
            edge = EdgeFactory.Create(0, 3);
            edgeEventArgs = new EdgeEventArgs<int, Edge<int>>(edge);
            this.EdgeGet<int, Edge<int>>(edgeEventArgs);
            PexStore.Generated.Validate("result", "0->3");
        }

    }
}
