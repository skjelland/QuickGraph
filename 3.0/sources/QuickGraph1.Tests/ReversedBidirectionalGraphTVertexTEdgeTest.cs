using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Wizard;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using QuickGraph;
using System;
using System.Collections;
using System.Collections.Generic;

namespace QuickGraph
{
    /// <summary>
    /// This class contains parameterized unit tests for ReversedBidirectionalGraph`2
    /// </summary>
    [TestClass]
    [PexClass(typeof(ReversedBidirectionalGraph<, >))]
    [PexGenericArguments(typeof(int), typeof(Edge<int>))]
    public partial class ReversedBidirectionalGraphTVertexTEdgeTest
    {
        [PexMethod]
        public void AllowParallelEdgesGet<TVertex,TEdge>(
            [PexAssumeUnderTest]ReversedBidirectionalGraph<TVertex, TEdge> target
        )
            where TEdge : IEdge<TVertex>
        {
            bool result = target.AllowParallelEdges;
            PexStore.ValueForValidation<bool>("result", result);
            // TODO: add assertions to method ReversedBidirectionalGraphTVertexTEdgeTest.AllowParallelEdgesGet(ReversedBidirectionalGraph`2<!!0,!!1>)
        }
        
        [PexMethod]
        public ReversedBidirectionalGraph<TVertex, TEdge> Constructor<TVertex,TEdge>(IBidirectionalGraph<TVertex, TEdge> originalGraph)
            where TEdge : IEdge<TVertex>
        {
            ReversedBidirectionalGraph<TVertex, TEdge> target
               = new ReversedBidirectionalGraph<TVertex, TEdge>(originalGraph);
            return target;
            // TODO: add assertions to method ReversedBidirectionalGraphTVertexTEdgeTest.Constructor(IBidirectionalGraph`2<!!0,!!1>)
        }
        
        [PexMethod]
        public bool ContainsEdge<TVertex,TEdge>(
            [PexAssumeUnderTest]ReversedBidirectionalGraph<TVertex, TEdge> target01,
            TVertex source,
            TVertex target
        )
            where TEdge : IEdge<TVertex>
        {
            bool result = target01.ContainsEdge(source, target);
            return result;
            // TODO: add assertions to method ReversedBidirectionalGraphTVertexTEdgeTest.ContainsEdge(ReversedBidirectionalGraph`2<!!0,!!1>, !!0, !!0)
        }
        
        [PexMethod]
        public bool ContainsEdge01<TVertex,TEdge>(
            [PexAssumeUnderTest]ReversedBidirectionalGraph<TVertex, TEdge> target,
            ReversedEdge<TVertex, TEdge> edge
        )
            where TEdge : IEdge<TVertex>
        {
            bool result = target.ContainsEdge(edge);
            return result;
            // TODO: add assertions to method ReversedBidirectionalGraphTVertexTEdgeTest.ContainsEdge01(ReversedBidirectionalGraph`2<!!0,!!1>, ReversedEdge`2<!!0,!!1>)
        }
        
        [PexMethod]
        public bool ContainsVertex<TVertex,TEdge>(
            [PexAssumeUnderTest]ReversedBidirectionalGraph<TVertex, TEdge> target,
            TVertex vertex
        )
            where TEdge : IEdge<TVertex>
        {
            bool result = target.ContainsVertex(vertex);
            return result;
            // TODO: add assertions to method ReversedBidirectionalGraphTVertexTEdgeTest.ContainsVertex(ReversedBidirectionalGraph`2<!!0,!!1>, !!0)
        }
        
        [PexMethod]
        public int Degree<TVertex,TEdge>(
            [PexAssumeUnderTest]ReversedBidirectionalGraph<TVertex, TEdge> target,
            TVertex v
        )
            where TEdge : IEdge<TVertex>
        {
            int result = target.Degree(v);
            return result;
            // TODO: add assertions to method ReversedBidirectionalGraphTVertexTEdgeTest.Degree(ReversedBidirectionalGraph`2<!!0,!!1>, !!0)
        }
        
        [PexMethod]
        public void EdgeCountGet<TVertex,TEdge>(
            [PexAssumeUnderTest]ReversedBidirectionalGraph<TVertex, TEdge> target
        )
            where TEdge : IEdge<TVertex>
        {
            int result = target.EdgeCount;
            PexStore.ValueForValidation<int>("result", result);
            // TODO: add assertions to method ReversedBidirectionalGraphTVertexTEdgeTest.EdgeCountGet(ReversedBidirectionalGraph`2<!!0,!!1>)
        }
        
        [PexMethod]
        public void EdgesGet<TVertex,TEdge>(
            [PexAssumeUnderTest]ReversedBidirectionalGraph<TVertex, TEdge> target
        )
            where TEdge : IEdge<TVertex>
        {
            IEnumerable<ReversedEdge<TVertex, TEdge>> result = target.Edges;
            PexStore.ValueForValidation<IEnumerable<ReversedEdge<TVertex, TEdge>>>
                ("result", result);
            // TODO: add assertions to method ReversedBidirectionalGraphTVertexTEdgeTest.EdgesGet(ReversedBidirectionalGraph`2<!!0,!!1>)
        }
        
        [PexMethod]
        public int InDegree<TVertex,TEdge>(
            [PexAssumeUnderTest]ReversedBidirectionalGraph<TVertex, TEdge> target,
            TVertex v
        )
            where TEdge : IEdge<TVertex>
        {
            int result = target.InDegree(v);
            return result;
            // TODO: add assertions to method ReversedBidirectionalGraphTVertexTEdgeTest.InDegree(ReversedBidirectionalGraph`2<!!0,!!1>, !!0)
        }
        
        [PexMethod]
        public void InEdge<TVertex,TEdge>(
            [PexAssumeUnderTest]ReversedBidirectionalGraph<TVertex, TEdge> target,
            TVertex v,
            int index
        )
            where TEdge : IEdge<TVertex>
        {
            ReversedEdge<TVertex, TEdge> result = target.InEdge(v, index);
            PexStore.ValueForValidation<ReversedEdge<TVertex, TEdge>>("result", result);
            PexEquatablePatterns.EqualsItself<ReversedEdge<TVertex, TEdge>>
                ((IEquatable<ReversedEdge<TVertex, TEdge>>)result);
            // TODO: add assertions to method ReversedBidirectionalGraphTVertexTEdgeTest.InEdge(ReversedBidirectionalGraph`2<!!0,!!1>, !!0, Int32)
        }
        
        [PexMethod]
        public void InEdges<TVertex,TEdge>(
            [PexAssumeUnderTest]ReversedBidirectionalGraph<TVertex, TEdge> target,
            TVertex v
        )
            where TEdge : IEdge<TVertex>
        {
            IEnumerable<ReversedEdge<TVertex, TEdge>> result = target.InEdges(v);
            PexStore.ValueForValidation<IEnumerable<ReversedEdge<TVertex, TEdge>>>
                ("result", result);
            PexEnumerablePatterns.ForEach<ReversedEdge<TVertex, TEdge>>(result);
            PexEnumerablePatterns.ForEach((IEnumerable)result);
            PexEnumerablePatterns.DoubleForEach<ReversedEdge<TVertex, TEdge>>(result);
            PexEnumerablePatterns.MoveNextAndReset<ReversedEdge<TVertex, TEdge>>(result);
            // TODO: add assertions to method ReversedBidirectionalGraphTVertexTEdgeTest.InEdges(ReversedBidirectionalGraph`2<!!0,!!1>, !!0)
        }
        
        [PexMethod]
        public void IsDirectedGet<TVertex,TEdge>(
            [PexAssumeUnderTest]ReversedBidirectionalGraph<TVertex, TEdge> target
        )
            where TEdge : IEdge<TVertex>
        {
            bool result = target.IsDirected;
            PexStore.ValueForValidation<bool>("result", result);
            // TODO: add assertions to method ReversedBidirectionalGraphTVertexTEdgeTest.IsDirectedGet(ReversedBidirectionalGraph`2<!!0,!!1>)
        }
        
        [PexMethod]
        public void IsEdgesEmptyGet<TVertex,TEdge>(
            [PexAssumeUnderTest]ReversedBidirectionalGraph<TVertex, TEdge> target
        )
            where TEdge : IEdge<TVertex>
        {
            bool result = target.IsEdgesEmpty;
            PexStore.ValueForValidation<bool>("result", result);
            // TODO: add assertions to method ReversedBidirectionalGraphTVertexTEdgeTest.IsEdgesEmptyGet(ReversedBidirectionalGraph`2<!!0,!!1>)
        }
        
        [PexMethod]
        public bool IsInEdgesEmpty<TVertex,TEdge>(
            [PexAssumeUnderTest]ReversedBidirectionalGraph<TVertex, TEdge> target,
            TVertex v
        )
            where TEdge : IEdge<TVertex>
        {
            bool result = target.IsInEdgesEmpty(v);
            return result;
            // TODO: add assertions to method ReversedBidirectionalGraphTVertexTEdgeTest.IsInEdgesEmpty(ReversedBidirectionalGraph`2<!!0,!!1>, !!0)
        }
        
        [PexMethod]
        public bool IsOutEdgesEmpty<TVertex,TEdge>(
            [PexAssumeUnderTest]ReversedBidirectionalGraph<TVertex, TEdge> target,
            TVertex v
        )
            where TEdge : IEdge<TVertex>
        {
            bool result = target.IsOutEdgesEmpty(v);
            return result;
            // TODO: add assertions to method ReversedBidirectionalGraphTVertexTEdgeTest.IsOutEdgesEmpty(ReversedBidirectionalGraph`2<!!0,!!1>, !!0)
        }
        
        [PexMethod]
        public void IsVerticesEmptyGet<TVertex,TEdge>(
            [PexAssumeUnderTest]ReversedBidirectionalGraph<TVertex, TEdge> target
        )
            where TEdge : IEdge<TVertex>
        {
            bool result = target.IsVerticesEmpty;
            PexStore.ValueForValidation<bool>("result", result);
            // TODO: add assertions to method ReversedBidirectionalGraphTVertexTEdgeTest.IsVerticesEmptyGet(ReversedBidirectionalGraph`2<!!0,!!1>)
        }
        
        [PexMethod]
        public void OriginalGraphGet<TVertex,TEdge>(
            [PexAssumeUnderTest]ReversedBidirectionalGraph<TVertex, TEdge> target
        )
            where TEdge : IEdge<TVertex>
        {
            IBidirectionalGraph<TVertex, TEdge> result = target.OriginalGraph;
            PexStore.ValueForValidation<IBidirectionalGraph<TVertex, TEdge>>
                ("result", result);
            // TODO: add assertions to method ReversedBidirectionalGraphTVertexTEdgeTest.OriginalGraphGet(ReversedBidirectionalGraph`2<!!0,!!1>)
        }
        
        [PexMethod]
        public int OutDegree<TVertex,TEdge>(
            [PexAssumeUnderTest]ReversedBidirectionalGraph<TVertex, TEdge> target,
            TVertex v
        )
            where TEdge : IEdge<TVertex>
        {
            int result = target.OutDegree(v);
            return result;
            // TODO: add assertions to method ReversedBidirectionalGraphTVertexTEdgeTest.OutDegree(ReversedBidirectionalGraph`2<!!0,!!1>, !!0)
        }
        
        [PexMethod]
        public void OutEdge<TVertex,TEdge>(
            [PexAssumeUnderTest]ReversedBidirectionalGraph<TVertex, TEdge> target,
            TVertex v,
            int index
        )
            where TEdge : IEdge<TVertex>
        {
            ReversedEdge<TVertex, TEdge> result = target.OutEdge(v, index);
            PexStore.ValueForValidation<ReversedEdge<TVertex, TEdge>>("result", result);
            PexEquatablePatterns.EqualsItself<ReversedEdge<TVertex, TEdge>>
                ((IEquatable<ReversedEdge<TVertex, TEdge>>)result);
            // TODO: add assertions to method ReversedBidirectionalGraphTVertexTEdgeTest.OutEdge(ReversedBidirectionalGraph`2<!!0,!!1>, !!0, Int32)
        }
        
        [PexMethod]
        public void OutEdges<TVertex,TEdge>(
            [PexAssumeUnderTest]ReversedBidirectionalGraph<TVertex, TEdge> target,
            TVertex v
        )
            where TEdge : IEdge<TVertex>
        {
            IEnumerable<ReversedEdge<TVertex, TEdge>> result = target.OutEdges(v);
            PexStore.ValueForValidation<IEnumerable<ReversedEdge<TVertex, TEdge>>>
                ("result", result);
            PexEnumerablePatterns.ForEach<ReversedEdge<TVertex, TEdge>>(result);
            PexEnumerablePatterns.ForEach((IEnumerable)result);
            PexEnumerablePatterns.DoubleForEach<ReversedEdge<TVertex, TEdge>>(result);
            PexEnumerablePatterns.MoveNextAndReset<ReversedEdge<TVertex, TEdge>>(result);
            // TODO: add assertions to method ReversedBidirectionalGraphTVertexTEdgeTest.OutEdges(ReversedBidirectionalGraph`2<!!0,!!1>, !!0)
        }
        
        [PexMethod]
        public bool TryGetEdge<TVertex,TEdge>(
            [PexAssumeUnderTest]ReversedBidirectionalGraph<TVertex, TEdge> target01,
            TVertex source,
            TVertex target,
            out ReversedEdge<TVertex, TEdge> edge
        )
            where TEdge : IEdge<TVertex>
        {
            bool result = target01.TryGetEdge(source, target, out edge);
            return result;
            // TODO: add assertions to method ReversedBidirectionalGraphTVertexTEdgeTest.TryGetEdge(ReversedBidirectionalGraph`2<!!0,!!1>, !!0, !!0, ReversedEdge`2<!!0,!!1>&)
        }
        
        [PexMethod]
        public bool TryGetEdges<TVertex,TEdge>(
            [PexAssumeUnderTest]ReversedBidirectionalGraph<TVertex, TEdge> target01,
            TVertex source,
            TVertex target,
            out IEnumerable<ReversedEdge<TVertex, TEdge>> edges
        )
            where TEdge : IEdge<TVertex>
        {
            bool result = target01.TryGetEdges(source, target, out edges);
            return result;
            // TODO: add assertions to method ReversedBidirectionalGraphTVertexTEdgeTest.TryGetEdges(ReversedBidirectionalGraph`2<!!0,!!1>, !!0, !!0, IEnumerable`1<ReversedEdge`2<!!0,!!1>>&)
        }
        
        [PexMethod]
        public void VertexCountGet<TVertex,TEdge>(
            [PexAssumeUnderTest]ReversedBidirectionalGraph<TVertex, TEdge> target
        )
            where TEdge : IEdge<TVertex>
        {
            int result = target.VertexCount;
            PexStore.ValueForValidation<int>("result", result);
            // TODO: add assertions to method ReversedBidirectionalGraphTVertexTEdgeTest.VertexCountGet(ReversedBidirectionalGraph`2<!!0,!!1>)
        }
        
        [PexMethod]
        public void VerticesGet<TVertex,TEdge>(
            [PexAssumeUnderTest]ReversedBidirectionalGraph<TVertex, TEdge> target
        )
            where TEdge : IEdge<TVertex>
        {
            IEnumerable<TVertex> result = target.Vertices;
            PexStore.ValueForValidation<IEnumerable<TVertex>>("result", result);
            // TODO: add assertions to method ReversedBidirectionalGraphTVertexTEdgeTest.VerticesGet(ReversedBidirectionalGraph`2<!!0,!!1>)
        }
        
    }
}
