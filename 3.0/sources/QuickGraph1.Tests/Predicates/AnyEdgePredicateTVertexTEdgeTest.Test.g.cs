// This file contains automatically generated unit tests.
// Do NOT modify this file manually.
// 
// When Pex is invoked again,
// it might remove or update any previously generated unit tests.
// 
// If the contents of this file becomes outdated, e.g. if it does not
// compile anymore, you may delete this file and invoke Pex again.
using System;
using QuickGraph;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.Pex.Framework.Generated;

namespace QuickGraph.Predicates
{
    public partial class AnyEdgePredicateTVertexTEdgeTest
    {
        [TestMethod]
        [PexGeneratedBy(typeof(AnyEdgePredicateTVertexTEdgeTest))]
        public void Test01()
        {
            bool b;
            AnyEdgePredicate<int, Edge<int>> anyEdgePredicate
               = new AnyEdgePredicate<int, Edge<int>>();
            b = this.Test<int, Edge<int>>(anyEdgePredicate, (Edge<int>)null);
            Assert.AreEqual<bool>(true, b);
        }

    }
}
