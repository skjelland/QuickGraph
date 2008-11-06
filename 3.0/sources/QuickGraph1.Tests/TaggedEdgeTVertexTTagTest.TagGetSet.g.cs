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
    public partial class TaggedEdgeTVertexTTagTest
    {
        [TestMethod]
        [PexGeneratedBy(typeof(TaggedEdgeTVertexTTagTest))]
        public void TagGetSet01()
        {
            PexStore.Generated.Clear();
            TaggedEdge<int, int> taggedEdge;
            taggedEdge = new TaggedEdge<int, int>(0, 2, 3);
            this.TagGetSet<int, int>(taggedEdge, 4);
            PexStore.Generated.Validate("result", "4");
        }

        [TestMethod]
        [PexGeneratedBy(typeof(TaggedEdgeTVertexTTagTest))]
        public void TagGetSet02()
        {
            PexStore.Generated.Clear();
            TaggedEdge<int, int> taggedEdge;
            taggedEdge = new TaggedEdge<int, int>(0, 2, 0);
            this.TagGetSet<int, int>(taggedEdge, 0);
            PexStore.Generated.Validate("result", "0");
        }

    }
}
