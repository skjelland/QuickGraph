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
    public partial class IdentifiableVertexTest
    {
        [TestMethod]
        [PexRaisedException(typeof(TraceAssertionException))]
        [PexGeneratedBy(typeof(IdentifiableVertexTest))]
        public void Constructor01()
        {
            IdentifiableVertex identifiableVertex;
            identifiableVertex = this.Constructor((string)null);
            // validation of result values is supported for primitive types only
        }

        [TestMethod]
        [PexGeneratedBy(typeof(IdentifiableVertexTest))]
        public void Constructor02()
        {
            IdentifiableVertex identifiableVertex;
            identifiableVertex = this.Constructor("");
            // validation of result values is supported for primitive types only
        }

        [TestMethod]
        [ExpectedException(typeof(TraceAssertionException))]
        [PexGeneratedBy(typeof(IdentifiableVertexTest))]
        public void Constructor03()
        {
            IdentifiableVertex identifiableVertex;
            identifiableVertex = this.Constructor((string)null);
            // validation of result values is supported for primitive types only
        }

    }
}
