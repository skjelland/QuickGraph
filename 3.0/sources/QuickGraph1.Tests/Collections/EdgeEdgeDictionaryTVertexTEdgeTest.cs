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
    /// This class contains parameterized unit tests for EdgeEdgeDictionary`2
    /// </summary>
    [TestClass]
    [PexClass(typeof(EdgeEdgeDictionary<, >))]
    public partial class EdgeEdgeDictionaryTVertexTEdgeTest
    {
        [PexMethod]
        public void Clone<TVertex,TEdge>([PexAssumeUnderTest]EdgeEdgeDictionary<TVertex, TEdge> target)
            where TEdge : IEdge<TVertex>
        {
            EdgeEdgeDictionary<TVertex, TEdge> result = target.Clone();
            PexStore.ValueForValidation<EdgeEdgeDictionary<TVertex, TEdge>>
                ("result", result);
            PexEnumerablePatterns.ForEach<KeyValuePair<TEdge, TEdge>>
                ((IEnumerable<KeyValuePair<TEdge, TEdge>>)result);
            PexEnumerablePatterns.ForEach((IEnumerable)result);
            PexEnumerablePatterns.DoubleForEach<KeyValuePair<TEdge, TEdge>>
                ((IEnumerable<KeyValuePair<TEdge, TEdge>>)result);
            PexEnumerablePatterns.MoveNextAndReset<KeyValuePair<TEdge, TEdge>>
                ((IEnumerable<KeyValuePair<TEdge, TEdge>>)result);
            // TODO: add assertions to method EdgeEdgeDictionaryTVertexTEdgeTest.Clone(EdgeEdgeDictionary`2<!!0,!!1>)
        }
        
        [PexMethod]
        public EdgeEdgeDictionary<TVertex, TEdge> Constructor<TVertex,TEdge>()
            where TEdge : IEdge<TVertex>
        {
            EdgeEdgeDictionary<TVertex, TEdge> target
               = new EdgeEdgeDictionary<TVertex, TEdge>();
            PexEnumerablePatterns.ForEach<KeyValuePair<TEdge, TEdge>>
                ((IEnumerable<KeyValuePair<TEdge, TEdge>>)target);
            PexEnumerablePatterns.ForEach((IEnumerable)target);
            PexEnumerablePatterns.DoubleForEach<KeyValuePair<TEdge, TEdge>>
                ((IEnumerable<KeyValuePair<TEdge, TEdge>>)target);
            PexEnumerablePatterns.MoveNextAndReset<KeyValuePair<TEdge, TEdge>>
                ((IEnumerable<KeyValuePair<TEdge, TEdge>>)target);
            return target;
            // TODO: add assertions to method EdgeEdgeDictionaryTVertexTEdgeTest.Constructor()
        }
        
        [PexMethod]
        public EdgeEdgeDictionary<TVertex, TEdge> Constructor01<TVertex,TEdge>(int capacity)
            where TEdge : IEdge<TVertex>
        {
            EdgeEdgeDictionary<TVertex, TEdge> target
               = new EdgeEdgeDictionary<TVertex, TEdge>(capacity);
            PexEnumerablePatterns.ForEach<KeyValuePair<TEdge, TEdge>>
                ((IEnumerable<KeyValuePair<TEdge, TEdge>>)target);
            PexEnumerablePatterns.ForEach((IEnumerable)target);
            PexEnumerablePatterns.DoubleForEach<KeyValuePair<TEdge, TEdge>>
                ((IEnumerable<KeyValuePair<TEdge, TEdge>>)target);
            PexEnumerablePatterns.MoveNextAndReset<KeyValuePair<TEdge, TEdge>>
                ((IEnumerable<KeyValuePair<TEdge, TEdge>>)target);
            return target;
            // TODO: add assertions to method EdgeEdgeDictionaryTVertexTEdgeTest.Constructor01(Int32)
        }
        
    }
}
