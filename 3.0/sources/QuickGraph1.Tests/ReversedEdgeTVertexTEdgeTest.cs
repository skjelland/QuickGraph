using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Wizard;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using QuickGraph;
using System;

namespace QuickGraph
{
    /// <summary>
    /// This class contains parameterized unit tests for ReversedEdge`2
    /// </summary>
    [TestClass]
    [PexClass(typeof(ReversedEdge<, >))]
    [PexGenericArguments(typeof(int), typeof(Edge<int>))]
    public partial class ReversedEdgeTVertexTEdgeTest
    {
        [PexMethod]
        public ReversedEdge<TVertex, TEdge> Constructor<TVertex,TEdge>(TEdge originalEdge)
            where TEdge : IEdge<TVertex>
        {
            ReversedEdge<TVertex, TEdge> target
               = new ReversedEdge<TVertex, TEdge>(originalEdge);
            PexEquatablePatterns.EqualsItself<ReversedEdge<TVertex, TEdge>>
                ((IEquatable<ReversedEdge<TVertex, TEdge>>)target);
            return target;
            // TODO: add assertions to method ReversedEdgeTVertexTEdgeTest.Constructor(!!1)
        }
        
        [PexMethod]
        public bool Equals<TVertex,TEdge>([PexAssumeUnderTest]ReversedEdge<TVertex, TEdge> target, object obj)
            where TEdge : IEdge<TVertex>
        {
            bool result = target.Equals(obj);
            return result;
            // TODO: add assertions to method ReversedEdgeTVertexTEdgeTest.Equals(ReversedEdge`2<!!0,!!1>, Object)
        }
        
        [PexMethod]
        public bool Equals01<TVertex,TEdge>(
            [PexAssumeUnderTest]ReversedEdge<TVertex, TEdge> target,
            ReversedEdge<TVertex, TEdge> other
        )
            where TEdge : IEdge<TVertex>
        {
            bool result = target.Equals(other);
            return result;
            // TODO: add assertions to method ReversedEdgeTVertexTEdgeTest.Equals01(ReversedEdge`2<!!0,!!1>, ReversedEdge`2<!!0,!!1>)
        }
        
        [PexMethod]
        public int GetHashCode<TVertex,TEdge>([PexAssumeUnderTest]ReversedEdge<TVertex, TEdge> target)
            where TEdge : IEdge<TVertex>
        {
            int result = target.GetHashCode();
            return result;
            // TODO: add assertions to method ReversedEdgeTVertexTEdgeTest.GetHashCode(ReversedEdge`2<!!0,!!1>)
        }
        
        [PexMethod]
        public void OriginalEdgeGet<TVertex,TEdge>([PexAssumeUnderTest]ReversedEdge<TVertex, TEdge> target)
            where TEdge : IEdge<TVertex>
        {
            TEdge result = target.OriginalEdge;
            PexStore.ValueForValidation<TEdge>("result", result);
            // TODO: add assertions to method ReversedEdgeTVertexTEdgeTest.OriginalEdgeGet(ReversedEdge`2<!!0,!!1>)
        }
        
        [PexMethod]
        public void SourceGet<TVertex,TEdge>([PexAssumeUnderTest]ReversedEdge<TVertex, TEdge> target)
            where TEdge : IEdge<TVertex>
        {
            TVertex result = target.Source;
            PexStore.ValueForValidation<TVertex>("result", result);
            // TODO: add assertions to method ReversedEdgeTVertexTEdgeTest.SourceGet(ReversedEdge`2<!!0,!!1>)
        }
        
        [PexMethod]
        public void TargetGet<TVertex,TEdge>([PexAssumeUnderTest]ReversedEdge<TVertex, TEdge> target)
            where TEdge : IEdge<TVertex>
        {
            TVertex result = target.Target;
            PexStore.ValueForValidation<TVertex>("result", result);
            // TODO: add assertions to method ReversedEdgeTVertexTEdgeTest.TargetGet(ReversedEdge`2<!!0,!!1>)
        }
        
        [PexMethod]
        public string ToString<TVertex,TEdge>([PexAssumeUnderTest]ReversedEdge<TVertex, TEdge> target)
            where TEdge : IEdge<TVertex>
        {
            string result = target.ToString();
            return result;
            // TODO: add assertions to method ReversedEdgeTVertexTEdgeTest.ToString(ReversedEdge`2<!!0,!!1>)
        }
        
    }
}
