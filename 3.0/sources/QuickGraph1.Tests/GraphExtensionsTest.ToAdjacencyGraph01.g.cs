// This file contains automatically generated unit tests.
// Do NOT modify this file manually.
// 
// When Pex is invoked again,
// it might remove or update any previously generated unit tests.
// 
// If the contents of this file becomes outdated, e.g. if it does not
// compile anymore, you may delete this file and invoke Pex again.
using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.Pex.Framework.Exceptions;
using Microsoft.Pex.Framework.Generated;

namespace QuickGraph
{
    public partial class GraphExtensionsTest
    {
        [TestMethod]
        [ExpectedException(typeof(TraceAssertionException))]
        [PexGeneratedBy(typeof(GraphExtensionsTest))]
        public void ToAdjacencyGraph0101()
        {
            this.ToAdjacencyGraph01<int, Edge<int>>((IEnumerable<Edge<int>>)null);
        }

    }
}
