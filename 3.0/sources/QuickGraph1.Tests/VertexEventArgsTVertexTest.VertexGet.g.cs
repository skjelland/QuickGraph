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
    public partial class VertexEventArgsTVertexTest
    {
        [TestMethod]
        [PexGeneratedBy(typeof(VertexEventArgsTVertexTest))]
        public void VertexGet01()
        {
            PexStore.Generated.Clear();
            VertexEventArgs<int> vertexEventArgs;
            vertexEventArgs = new VertexEventArgs<int>(0);
            this.VertexGet<int>(vertexEventArgs);
            PexStore.Generated.Validate("result", "0");
        }

    }
}
