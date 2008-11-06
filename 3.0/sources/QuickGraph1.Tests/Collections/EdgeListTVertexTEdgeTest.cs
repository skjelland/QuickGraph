using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Wizard;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using QuickGraph;
using QuickGraph.Collections;
using System.Collections;
using System.Collections.Generic;

namespace QuickGraph.Collections
{
    /// <summary>
    /// This class contains parameterized unit tests for EdgeList`2
    /// </summary>
    [TestClass]
    [PexClass(typeof(EdgeList<, >))]
    public partial class EdgeListTVertexTEdgeTest
    {
        [PexMethod]
        public void Clone<TVertex,TEdge>([PexAssumeUnderTest]EdgeList<TVertex, TEdge> target)
            where TEdge : IEdge<TVertex>
        {
            EdgeList<TVertex, TEdge> result = target.Clone();
            PexStore.ValueForValidation<EdgeList<TVertex, TEdge>>("result", result);
            PexEnumerablePatterns.ForEach<TEdge>((IEnumerable<TEdge>)result);
            PexEnumerablePatterns.ForEach((IEnumerable)result);
            PexEnumerablePatterns.DoubleForEach<TEdge>((IEnumerable<TEdge>)result);
            PexEnumerablePatterns.MoveNextAndReset<TEdge>((IEnumerable<TEdge>)result);
            // TODO: add assertions to method EdgeListTVertexTEdgeTest.Clone(EdgeList`2<!!0,!!1>)
        }
        
        [PexMethod]
        public EdgeList<TVertex, TEdge> Constructor<TVertex,TEdge>()
            where TEdge : IEdge<TVertex>
        {
            EdgeList<TVertex, TEdge> target = new EdgeList<TVertex, TEdge>();
            PexEnumerablePatterns.ForEach<TEdge>((IEnumerable<TEdge>)target);
            PexEnumerablePatterns.ForEach((IEnumerable)target);
            PexEnumerablePatterns.DoubleForEach<TEdge>((IEnumerable<TEdge>)target);
            PexEnumerablePatterns.MoveNextAndReset<TEdge>((IEnumerable<TEdge>)target);
            return target;
            // TODO: add assertions to method EdgeListTVertexTEdgeTest.Constructor()
        }
        
        [PexMethod]
        public EdgeList<TVertex, TEdge> Constructor01<TVertex,TEdge>(int capacity)
            where TEdge : IEdge<TVertex>
        {
            EdgeList<TVertex, TEdge> target = new EdgeList<TVertex, TEdge>(capacity);
            PexEnumerablePatterns.ForEach<TEdge>((IEnumerable<TEdge>)target);
            PexEnumerablePatterns.ForEach((IEnumerable)target);
            PexEnumerablePatterns.DoubleForEach<TEdge>((IEnumerable<TEdge>)target);
            PexEnumerablePatterns.MoveNextAndReset<TEdge>((IEnumerable<TEdge>)target);
            return target;
            // TODO: add assertions to method EdgeListTVertexTEdgeTest.Constructor01(Int32)
        }
        
    }
}
