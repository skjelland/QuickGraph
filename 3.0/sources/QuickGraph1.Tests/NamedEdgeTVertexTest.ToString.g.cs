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
    public partial class NamedEdgeTVertexTest
    {
        [TestMethod]
        [PexGeneratedBy(typeof(NamedEdgeTVertexTest))]
        public void ToString01()
        {
            NamedEdge<int> namedEdge;
            string s;
            namedEdge = new NamedEdge<int>(2, 3, "");
            s = this.ToString<int>(namedEdge);
            Assert.AreEqual<string>("", s);
        }

    }
}
