using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Wizard;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using QuickGraph;
using System.Collections;
using System.Collections.Generic;

namespace QuickGraph
{
    /// <summary>
    /// This class contains parameterized unit tests for UndirectedBidirectionalGraph`2
    /// </summary>
    [TestClass]
    [PexClass(typeof(UndirectedBidirectionalGraph<, >))]
    [PexGenericArguments(typeof(int), typeof(Edge<int>))]
    public partial class UndirectedBidirectionalGraphTVertexTEdgeTest
    {
        [PexMethod]
        public int AdjacentDegree<TVertex,TEdge>(
            [PexAssumeUnderTest]UndirectedBidirectionalGraph<TVertex, TEdge> target,
            TVertex v
        )
            where TEdge : IEdge<TVertex>
        {
            int result = target.AdjacentDegree(v);
            return result;
            // TODO: add assertions to method UndirectedBidirectionalGraphTVertexTEdgeTest.AdjacentDegree(UndirectedBidirectionalGraph`2<!!0,!!1>, !!0)
        }
        
        [PexMethod]
        public void AdjacentEdge<TVertex,TEdge>(
            [PexAssumeUnderTest]UndirectedBidirectionalGraph<TVertex, TEdge> target,
            TVertex v,
            int index
        )
            where TEdge : IEdge<TVertex>
        {
            TEdge result = target.AdjacentEdge(v, index);
            PexStore.ValueForValidation<TEdge>("result", result);
            // TODO: add assertions to method UndirectedBidirectionalGraphTVertexTEdgeTest.AdjacentEdge(UndirectedBidirectionalGraph`2<!!0,!!1>, !!0, Int32)
        }
        
        [PexMethod]
        public void AdjacentEdges<TVertex,TEdge>(
            [PexAssumeUnderTest]UndirectedBidirectionalGraph<TVertex, TEdge> target,
            TVertex v
        )
            where TEdge : IEdge<TVertex>
        {
            IEnumerable<TEdge> result = target.AdjacentEdges(v);
            PexStore.ValueForValidation<IEnumerable<TEdge>>("result", result);
            PexEnumerablePatterns.ForEach<TEdge>(result);
            PexEnumerablePatterns.ForEach((IEnumerable)result);
            PexEnumerablePatterns.DoubleForEach<TEdge>(result);
            PexEnumerablePatterns.MoveNextAndReset<TEdge>(result);
            // TODO: add assertions to method UndirectedBidirectionalGraphTVertexTEdgeTest.AdjacentEdges(UndirectedBidirectionalGraph`2<!!0,!!1>, !!0)
        }
        
        [PexMethod]
        public void AllowParallelEdgesGet<TVertex,TEdge>(
            [PexAssumeUnderTest]UndirectedBidirectionalGraph<TVertex, TEdge> target
        )
            where TEdge : IEdge<TVertex>
        {
            bool result = target.AllowParallelEdges;
            PexStore.ValueForValidation<bool>("result", result);
            // TODO: add assertions to method UndirectedBidirectionalGraphTVertexTEdgeTest.AllowParallelEdgesGet(UndirectedBidirectionalGraph`2<!!0,!!1>)
        }
        
        [PexMethod]
        public UndirectedBidirectionalGraph<TVertex, TEdge> Constructor<TVertex,TEdge>(IBidirectionalGraph<TVertex, TEdge> visitedGraph)
            where TEdge : IEdge<TVertex>
        {
            UndirectedBidirectionalGraph<TVertex, TEdge> target
               = new UndirectedBidirectionalGraph<TVertex, TEdge>(visitedGraph);
            return target;
            // TODO: add assertions to method UndirectedBidirectionalGraphTVertexTEdgeTest.Constructor(IBidirectionalGraph`2<!!0,!!1>)
        }
        
        [PexMethod]
        public bool ContainsEdge<TVertex,TEdge>(
            [PexAssumeUnderTest]UndirectedBidirectionalGraph<TVertex, TEdge> target01,
            TVertex source,
            TVertex target
        )
            where TEdge : IEdge<TVertex>
        {
            bool result = target01.ContainsEdge(source, target);
            return result;
            // TODO: add assertions to method UndirectedBidirectionalGraphTVertexTEdgeTest.ContainsEdge(UndirectedBidirectionalGraph`2<!!0,!!1>, !!0, !!0)
        }
        
        [PexMethod]
        public bool ContainsEdge01<TVertex,TEdge>(
            [PexAssumeUnderTest]UndirectedBidirectionalGraph<TVertex, TEdge> target,
            TEdge edge
        )
            where TEdge : IEdge<TVertex>
        {
            bool result = target.ContainsEdge(edge);
            return result;
            // TODO: add assertions to method UndirectedBidirectionalGraphTVertexTEdgeTest.ContainsEdge01(UndirectedBidirectionalGraph`2<!!0,!!1>, !!1)
        }
        
        [PexMethod]
        public bool ContainsVertex<TVertex,TEdge>(
            [PexAssumeUnderTest]UndirectedBidirectionalGraph<TVertex, TEdge> target,
            TVertex vertex
        )
            where TEdge : IEdge<TVertex>
        {
            bool result = target.ContainsVertex(vertex);
            return result;
            // TODO: add assertions to method UndirectedBidirectionalGraphTVertexTEdgeTest.ContainsVertex(UndirectedBidirectionalGraph`2<!!0,!!1>, !!0)
        }
        
        [PexMethod]
        public void EdgeCountGet<TVertex,TEdge>(
            [PexAssumeUnderTest]UndirectedBidirectionalGraph<TVertex, TEdge> target
        )
            where TEdge : IEdge<TVertex>
        {
            int result = target.EdgeCount;
            PexStore.ValueForValidation<int>("result", result);
            // TODO: add assertions to method UndirectedBidirectionalGraphTVertexTEdgeTest.EdgeCountGet(UndirectedBidirectionalGraph`2<!!0,!!1>)
        }
        
        [PexMethod]
        public void EdgesGet<TVertex,TEdge>(
            [PexAssumeUnderTest]UndirectedBidirectionalGraph<TVertex, TEdge> target
        )
            where TEdge : IEdge<TVertex>
        {
            IEnumerable<TEdge> result = target.Edges;
            PexStore.ValueForValidation<IEnumerable<TEdge>>("result", result);
            // TODO: add assertions to method UndirectedBidirectionalGraphTVertexTEdgeTest.EdgesGet(UndirectedBidirectionalGraph`2<!!0,!!1>)
        }
        
        [PexMethod]
        public bool IsAdjacentEdgesEmpty<TVertex,TEdge>(
            [PexAssumeUnderTest]UndirectedBidirectionalGraph<TVertex, TEdge> target,
            TVertex v
        )
            where TEdge : IEdge<TVertex>
        {
            bool result = target.IsAdjacentEdgesEmpty(v);
            return result;
            // TODO: add assertions to method UndirectedBidirectionalGraphTVertexTEdgeTest.IsAdjacentEdgesEmpty(UndirectedBidirectionalGraph`2<!!0,!!1>, !!0)
        }
        
        [PexMethod]
        public void IsDirectedGet<TVertex,TEdge>(
            [PexAssumeUnderTest]UndirectedBidirectionalGraph<TVertex, TEdge> target
        )
            where TEdge : IEdge<TVertex>
        {
            bool result = target.IsDirected;
            PexStore.ValueForValidation<bool>("result", result);
            // TODO: add assertions to method UndirectedBidirectionalGraphTVertexTEdgeTest.IsDirectedGet(UndirectedBidirectionalGraph`2<!!0,!!1>)
        }
        
        [PexMethod]
        public void IsEdgesEmptyGet<TVertex,TEdge>(
            [PexAssumeUnderTest]UndirectedBidirectionalGraph<TVertex, TEdge> target
        )
            where TEdge : IEdge<TVertex>
        {
            bool result = target.IsEdgesEmpty;
            PexStore.ValueForValidation<bool>("result", result);
            // TODO: add assertions to method UndirectedBidirectionalGraphTVertexTEdgeTest.IsEdgesEmptyGet(UndirectedBidirectionalGraph`2<!!0,!!1>)
        }
        
        [PexMethod]
        public void IsVerticesEmptyGet<TVertex,TEdge>(
            [PexAssumeUnderTest]UndirectedBidirectionalGraph<TVertex, TEdge> target
        )
            where TEdge : IEdge<TVertex>
        {
            bool result = target.IsVerticesEmpty;
            PexStore.ValueForValidation<bool>("result", result);
            // TODO: add assertions to method UndirectedBidirectionalGraphTVertexTEdgeTest.IsVerticesEmptyGet(UndirectedBidirectionalGraph`2<!!0,!!1>)
        }
        
        [PexMethod]
        public void VertexCountGet<TVertex,TEdge>(
            [PexAssumeUnderTest]UndirectedBidirectionalGraph<TVertex, TEdge> target
        )
            where TEdge : IEdge<TVertex>
        {
            int result = target.VertexCount;
            PexStore.ValueForValidation<int>("result", result);
            // TODO: add assertions to method UndirectedBidirectionalGraphTVertexTEdgeTest.VertexCountGet(UndirectedBidirectionalGraph`2<!!0,!!1>)
        }
        
        [PexMethod]
        public void VerticesGet<TVertex,TEdge>(
            [PexAssumeUnderTest]UndirectedBidirectionalGraph<TVertex, TEdge> target
        )
            where TEdge : IEdge<TVertex>
        {
            IEnumerable<TVertex> result = target.Vertices;
            PexStore.ValueForValidation<IEnumerable<TVertex>>("result", result);
            // TODO: add assertions to method UndirectedBidirectionalGraphTVertexTEdgeTest.VerticesGet(UndirectedBidirectionalGraph`2<!!0,!!1>)
        }
        
        [PexMethod]
        public void VisitedGraphGet<TVertex,TEdge>(
            [PexAssumeUnderTest]UndirectedBidirectionalGraph<TVertex, TEdge> target
        )
            where TEdge : IEdge<TVertex>
        {
            IBidirectionalGraph<TVertex, TEdge> result = target.VisitedGraph;
            PexStore.ValueForValidation<IBidirectionalGraph<TVertex, TEdge>>
                ("result", result);
            // TODO: add assertions to method UndirectedBidirectionalGraphTVertexTEdgeTest.VisitedGraphGet(UndirectedBidirectionalGraph`2<!!0,!!1>)
        }
        
    }
}
