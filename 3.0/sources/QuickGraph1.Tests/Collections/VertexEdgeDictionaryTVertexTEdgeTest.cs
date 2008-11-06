using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Wizard;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using QuickGraph;
using QuickGraph.Collections;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace QuickGraph.Collections
{
    /// <summary>
    /// This class contains parameterized unit tests for VertexEdgeDictionary`2
    /// </summary>
    [TestClass]
    [PexClass(typeof(VertexEdgeDictionary<, >))]
    public partial class VertexEdgeDictionaryTVertexTEdgeTest
    {
        [PexMethod]
        public void Clone<TVertex,TEdge>([PexAssumeUnderTest]VertexEdgeDictionary<TVertex, TEdge> target)
            where TEdge : IEdge<TVertex>
        {
            VertexEdgeDictionary<TVertex, TEdge> result = target.Clone();
            PexStore.ValueForValidation<VertexEdgeDictionary<TVertex, TEdge>>
                ("result", result);
            PexEnumerablePatterns.ForEach<KeyValuePair<TVertex, EdgeList<TVertex, TEdge>>>
                ((IEnumerable<KeyValuePair<TVertex, EdgeList<TVertex, TEdge>>>)result);
            PexEnumerablePatterns.ForEach((IEnumerable)result);
            PexEnumerablePatterns
              .DoubleForEach<KeyValuePair<TVertex, EdgeList<TVertex, TEdge>>>
                ((IEnumerable<KeyValuePair<TVertex, EdgeList<TVertex, TEdge>>>)result);
            PexEnumerablePatterns
              .MoveNextAndReset<KeyValuePair<TVertex, EdgeList<TVertex, TEdge>>>
                ((IEnumerable<KeyValuePair<TVertex, EdgeList<TVertex, TEdge>>>)result);
            // TODO: add assertions to method VertexEdgeDictionaryTVertexTEdgeTest.Clone(VertexEdgeDictionary`2<!!0,!!1>)
        }
        
        [PexMethod]
        public VertexEdgeDictionary<TVertex, TEdge> Constructor<TVertex,TEdge>()
            where TEdge : IEdge<TVertex>
        {
            VertexEdgeDictionary<TVertex, TEdge> target
               = new VertexEdgeDictionary<TVertex, TEdge>();
            PexEnumerablePatterns.ForEach<KeyValuePair<TVertex, EdgeList<TVertex, TEdge>>>
                ((IEnumerable<KeyValuePair<TVertex, EdgeList<TVertex, TEdge>>>)target);
            PexEnumerablePatterns.ForEach((IEnumerable)target);
            PexEnumerablePatterns
              .DoubleForEach<KeyValuePair<TVertex, EdgeList<TVertex, TEdge>>>
                ((IEnumerable<KeyValuePair<TVertex, EdgeList<TVertex, TEdge>>>)target);
            PexEnumerablePatterns
              .MoveNextAndReset<KeyValuePair<TVertex, EdgeList<TVertex, TEdge>>>
                ((IEnumerable<KeyValuePair<TVertex, EdgeList<TVertex, TEdge>>>)target);
            return target;
            // TODO: add assertions to method VertexEdgeDictionaryTVertexTEdgeTest.Constructor()
        }
        
        [PexMethod]
        public VertexEdgeDictionary<TVertex, TEdge> Constructor01<TVertex,TEdge>(int capacity)
            where TEdge : IEdge<TVertex>
        {
            VertexEdgeDictionary<TVertex, TEdge> target
               = new VertexEdgeDictionary<TVertex, TEdge>(capacity);
            PexEnumerablePatterns.ForEach<KeyValuePair<TVertex, EdgeList<TVertex, TEdge>>>
                ((IEnumerable<KeyValuePair<TVertex, EdgeList<TVertex, TEdge>>>)target);
            PexEnumerablePatterns.ForEach((IEnumerable)target);
            PexEnumerablePatterns
              .DoubleForEach<KeyValuePair<TVertex, EdgeList<TVertex, TEdge>>>
                ((IEnumerable<KeyValuePair<TVertex, EdgeList<TVertex, TEdge>>>)target);
            PexEnumerablePatterns
              .MoveNextAndReset<KeyValuePair<TVertex, EdgeList<TVertex, TEdge>>>
                ((IEnumerable<KeyValuePair<TVertex, EdgeList<TVertex, TEdge>>>)target);
            return target;
            // TODO: add assertions to method VertexEdgeDictionaryTVertexTEdgeTest.Constructor01(Int32)
        }
        
        [PexMethod]
        public VertexEdgeDictionary<TVertex, TEdge> Constructor02<TVertex,TEdge>(SerializationInfo info, StreamingContext context)
            where TEdge : IEdge<TVertex>
        {
            VertexEdgeDictionary<TVertex, TEdge> target
               = new VertexEdgeDictionary<TVertex, TEdge>(info, context);
            PexEnumerablePatterns.ForEach<KeyValuePair<TVertex, EdgeList<TVertex, TEdge>>>
                ((IEnumerable<KeyValuePair<TVertex, EdgeList<TVertex, TEdge>>>)target);
            PexEnumerablePatterns.ForEach((IEnumerable)target);
            PexEnumerablePatterns
              .DoubleForEach<KeyValuePair<TVertex, EdgeList<TVertex, TEdge>>>
                ((IEnumerable<KeyValuePair<TVertex, EdgeList<TVertex, TEdge>>>)target);
            PexEnumerablePatterns
              .MoveNextAndReset<KeyValuePair<TVertex, EdgeList<TVertex, TEdge>>>
                ((IEnumerable<KeyValuePair<TVertex, EdgeList<TVertex, TEdge>>>)target);
            return target;
            // TODO: add assertions to method VertexEdgeDictionaryTVertexTEdgeTest.Constructor02(SerializationInfo, StreamingContext)
        }
        
    }
}
