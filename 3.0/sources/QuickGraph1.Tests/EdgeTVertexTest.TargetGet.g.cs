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
    public partial class EdgeTVertexTest
    {
        [TestMethod]
        [PexGeneratedBy(typeof(EdgeTVertexTest))]
        public void TargetGet01()
        {
            PexStore.Generated.Clear();
            Edge<int> edge;
            edge = new Edge<int>(0, 2);
            this.TargetGet<int>(edge);
            PexStore.Generated.Validate("result", "2");
        }

    }
}
