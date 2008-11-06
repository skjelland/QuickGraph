using Microsoft.Pex.Framework;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using QuickGraph;
using System;

namespace QuickGraph
{
    /// <summary>
    /// This class contains parameterized unit tests for TaggedEdge`2
    /// </summary>
    [TestClass]
    [PexClass(typeof(TaggedEdge<, >))]
    public partial class TaggedEdgeTVertexTTagTest
    {
        [PexMethod]
        [PexGenericArguments(new Type[]{typeof(int), typeof(int)})]
        public TaggedEdge<TVertex, TTag> Constructor<TVertex,TTag>(
            TVertex source,
            TVertex target,
            TTag tag
        )
        {
            TaggedEdge<TVertex, TTag> target01
               = new TaggedEdge<TVertex, TTag>(source, target, tag);
            return target01;
            // TODO: add assertions to method TaggedEdgeTVertexTTagTest.Constructor(!!0, !!0, !!1)
        }
        
        [PexMethod]
        [PexGenericArguments(new Type[]{typeof(int), typeof(int)})]
        public void TagGetSet<TVertex,TTag>([PexAssumeUnderTest]TaggedEdge<TVertex, TTag> target, TTag value)
        {
            target.Tag = value;
            TTag result = target.Tag;
            PexStore.ValueForValidation<TTag>("result", result);
            // TODO: add assertions to method TaggedEdgeTVertexTTagTest.TagGetSet(TaggedEdge`2<!!0,!!1>, !!1)
        }
        
    }
}
