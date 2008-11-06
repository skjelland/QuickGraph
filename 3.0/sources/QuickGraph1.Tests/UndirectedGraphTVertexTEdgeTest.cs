using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Wizard;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using QuickGraph;
using System.Collections;
using System.Collections.Generic;

namespace QuickGraph
{
    /// <summary>
    /// This class contains parameterized unit tests for UndirectedGraph`2
    /// </summary>
    [TestClass]
    [PexClass(typeof(UndirectedGraph<, >))]
    [PexGenericArguments(typeof(int), typeof(Edge<int>))]
    public partial class UndirectedGraphTVertexTEdgeTest
    {
        [PexMethod]
        public bool AddEdge<TVertex,TEdge>([PexAssumeUnderTest]UndirectedGraph<TVertex, TEdge> target, TEdge edge)
            where TEdge : IEdge<TVertex>
        {
            bool result = target.AddEdge(edge);
            return result;
            // TODO: add assertions to method UndirectedGraphTVertexTEdgeTest.AddEdge(UndirectedGraph`2<!!0,!!1>, !!1)
        }
        
        [PexMethod]
        public void AddEdgeRange<TVertex,TEdge>(
            [PexAssumeUnderTest]UndirectedGraph<TVertex, TEdge> target,
            IEnumerable<TEdge> edges
        )
            where TEdge : IEdge<TVertex>
        {
            target.AddEdgeRange(edges);
            // TODO: add assertions to method UndirectedGraphTVertexTEdgeTest.AddEdgeRange(UndirectedGraph`2<!!0,!!1>, IEnumerable`1<!!1>)
        }
        
        [PexMethod]
        public void AddVertex<TVertex,TEdge>([PexAssumeUnderTest]UndirectedGraph<TVertex, TEdge> target, TVertex v)
            where TEdge : IEdge<TVertex>
        {
            target.AddVertex(v);
            // TODO: add assertions to method UndirectedGraphTVertexTEdgeTest.AddVertex(UndirectedGraph`2<!!0,!!1>, !!0)
        }
        
        [PexMethod]
        public bool AddVerticesAndEdge<TVertex,TEdge>([PexAssumeUnderTest]UndirectedGraph<TVertex, TEdge> target, TEdge edge)
            where TEdge : IEdge<TVertex>
        {
            bool result = target.AddVerticesAndEdge(edge);
            return result;
            // TODO: add assertions to method UndirectedGraphTVertexTEdgeTest.AddVerticesAndEdge(UndirectedGraph`2<!!0,!!1>, !!1)
        }
        
        [PexMethod]
        public int AdjacentDegree<TVertex,TEdge>([PexAssumeUnderTest]UndirectedGraph<TVertex, TEdge> target, TVertex v)
            where TEdge : IEdge<TVertex>
        {
            int result = target.AdjacentDegree(v);
            return result;
            // TODO: add assertions to method UndirectedGraphTVertexTEdgeTest.AdjacentDegree(UndirectedGraph`2<!!0,!!1>, !!0)
        }
        
        [PexMethod]
        public void AdjacentEdge<TVertex,TEdge>(
            [PexAssumeUnderTest]UndirectedGraph<TVertex, TEdge> target,
            TVertex v,
            int index
        )
            where TEdge : IEdge<TVertex>
        {
            TEdge result = target.AdjacentEdge(v, index);
            PexStore.ValueForValidation<TEdge>("result", result);
            // TODO: add assertions to method UndirectedGraphTVertexTEdgeTest.AdjacentEdge(UndirectedGraph`2<!!0,!!1>, !!0, Int32)
        }
        
        [PexMethod]
        public void AdjacentEdges<TVertex,TEdge>([PexAssumeUnderTest]UndirectedGraph<TVertex, TEdge> target, TVertex v)
            where TEdge : IEdge<TVertex>
        {
            IEnumerable<TEdge> result = target.AdjacentEdges(v);
            PexStore.ValueForValidation<IEnumerable<TEdge>>("result", result);
            PexEnumerablePatterns.ForEach<TEdge>(result);
            PexEnumerablePatterns.ForEach((IEnumerable)result);
            PexEnumerablePatterns.DoubleForEach<TEdge>(result);
            PexEnumerablePatterns.MoveNextAndReset<TEdge>(result);
            // TODO: add assertions to method UndirectedGraphTVertexTEdgeTest.AdjacentEdges(UndirectedGraph`2<!!0,!!1>, !!0)
        }
        
        [PexMethod]
        public void AllowParallelEdgesGet<TVertex,TEdge>([PexAssumeUnderTest]UndirectedGraph<TVertex, TEdge> target)
            where TEdge : IEdge<TVertex>
        {
            bool result = target.AllowParallelEdges;
            PexStore.ValueForValidation<bool>("result", result);
            // TODO: add assertions to method UndirectedGraphTVertexTEdgeTest.AllowParallelEdgesGet(UndirectedGraph`2<!!0,!!1>)
        }
        
        [PexMethod]
        public void Clear<TVertex,TEdge>([PexAssumeUnderTest]UndirectedGraph<TVertex, TEdge> target)
            where TEdge : IEdge<TVertex>
        {
            target.Clear();
            // TODO: add assertions to method UndirectedGraphTVertexTEdgeTest.Clear(UndirectedGraph`2<!!0,!!1>)
        }
        
        [PexMethod]
        public void ClearAdjacentEdges<TVertex,TEdge>([PexAssumeUnderTest]UndirectedGraph<TVertex, TEdge> target, TVertex v)
            where TEdge : IEdge<TVertex>
        {
            target.ClearAdjacentEdges(v);
            // TODO: add assertions to method UndirectedGraphTVertexTEdgeTest.ClearAdjacentEdges(UndirectedGraph`2<!!0,!!1>, !!0)
        }
        
        [PexMethod]
        public UndirectedGraph<TVertex, TEdge> Constructor<TVertex,TEdge>()
            where TEdge : IEdge<TVertex>
        {
            UndirectedGraph<TVertex, TEdge> target = new UndirectedGraph<TVertex, TEdge>();
            return target;
            // TODO: add assertions to method UndirectedGraphTVertexTEdgeTest.Constructor()
        }
        
        [PexMethod]
        public UndirectedGraph<TVertex, TEdge> Constructor01<TVertex,TEdge>(bool allowParallelEdges)
            where TEdge : IEdge<TVertex>
        {
            UndirectedGraph<TVertex, TEdge> target
               = new UndirectedGraph<TVertex, TEdge>(allowParallelEdges);
            return target;
            // TODO: add assertions to method UndirectedGraphTVertexTEdgeTest.Constructor01(Boolean)
        }
        
        [PexMethod]
        public bool ContainsEdge<TVertex,TEdge>(
            [PexAssumeUnderTest]UndirectedGraph<TVertex, TEdge> target01,
            TVertex source,
            TVertex target
        )
            where TEdge : IEdge<TVertex>
        {
            bool result = target01.ContainsEdge(source, target);
            return result;
            // TODO: add assertions to method UndirectedGraphTVertexTEdgeTest.ContainsEdge(UndirectedGraph`2<!!0,!!1>, !!0, !!0)
        }
        
        [PexMethod]
        public bool ContainsEdge01<TVertex,TEdge>([PexAssumeUnderTest]UndirectedGraph<TVertex, TEdge> target, TEdge edge)
            where TEdge : IEdge<TVertex>
        {
            bool result = target.ContainsEdge(edge);
            return result;
            // TODO: add assertions to method UndirectedGraphTVertexTEdgeTest.ContainsEdge01(UndirectedGraph`2<!!0,!!1>, !!1)
        }
        
        [PexMethod]
        public bool ContainsVertex<TVertex,TEdge>(
            [PexAssumeUnderTest]UndirectedGraph<TVertex, TEdge> target,
            TVertex vertex
        )
            where TEdge : IEdge<TVertex>
        {
            bool result = target.ContainsVertex(vertex);
            return result;
            // TODO: add assertions to method UndirectedGraphTVertexTEdgeTest.ContainsVertex(UndirectedGraph`2<!!0,!!1>, !!0)
        }
        
        [PexMethod]
        public void EdgeCountGet<TVertex,TEdge>([PexAssumeUnderTest]UndirectedGraph<TVertex, TEdge> target)
            where TEdge : IEdge<TVertex>
        {
            int result = target.EdgeCount;
            PexStore.ValueForValidation<int>("result", result);
            // TODO: add assertions to method UndirectedGraphTVertexTEdgeTest.EdgeCountGet(UndirectedGraph`2<!!0,!!1>)
        }
        
        [PexMethod]
        public void EdgesGet<TVertex,TEdge>([PexAssumeUnderTest]UndirectedGraph<TVertex, TEdge> target)
            where TEdge : IEdge<TVertex>
        {
            IEnumerable<TEdge> result = target.Edges;
            PexStore.ValueForValidation<IEnumerable<TEdge>>("result", result);
            // TODO: add assertions to method UndirectedGraphTVertexTEdgeTest.EdgesGet(UndirectedGraph`2<!!0,!!1>)
        }
        
        [PexMethod]
        public bool IsAdjacentEdgesEmpty<TVertex,TEdge>([PexAssumeUnderTest]UndirectedGraph<TVertex, TEdge> target, TVertex v)
            where TEdge : IEdge<TVertex>
        {
            bool result = target.IsAdjacentEdgesEmpty(v);
            return result;
            // TODO: add assertions to method UndirectedGraphTVertexTEdgeTest.IsAdjacentEdgesEmpty(UndirectedGraph`2<!!0,!!1>, !!0)
        }
        
        [PexMethod]
        public void IsDirectedGet<TVertex,TEdge>([PexAssumeUnderTest]UndirectedGraph<TVertex, TEdge> target)
            where TEdge : IEdge<TVertex>
        {
            bool result = target.IsDirected;
            PexStore.ValueForValidation<bool>("result", result);
            // TODO: add assertions to method UndirectedGraphTVertexTEdgeTest.IsDirectedGet(UndirectedGraph`2<!!0,!!1>)
        }
        
        [PexMethod]
        public void IsEdgesEmptyGet<TVertex,TEdge>([PexAssumeUnderTest]UndirectedGraph<TVertex, TEdge> target)
            where TEdge : IEdge<TVertex>
        {
            bool result = target.IsEdgesEmpty;
            PexStore.ValueForValidation<bool>("result", result);
            // TODO: add assertions to method UndirectedGraphTVertexTEdgeTest.IsEdgesEmptyGet(UndirectedGraph`2<!!0,!!1>)
        }
        
        [PexMethod]
        public void IsVerticesEmptyGet<TVertex,TEdge>([PexAssumeUnderTest]UndirectedGraph<TVertex, TEdge> target)
            where TEdge : IEdge<TVertex>
        {
            bool result = target.IsVerticesEmpty;
            PexStore.ValueForValidation<bool>("result", result);
            // TODO: add assertions to method UndirectedGraphTVertexTEdgeTest.IsVerticesEmptyGet(UndirectedGraph`2<!!0,!!1>)
        }
        
        [PexMethod]
        public bool RemoveEdge<TVertex,TEdge>([PexAssumeUnderTest]UndirectedGraph<TVertex, TEdge> target, TEdge edge)
            where TEdge : IEdge<TVertex>
        {
            bool result = target.RemoveEdge(edge);
            return result;
            // TODO: add assertions to method UndirectedGraphTVertexTEdgeTest.RemoveEdge(UndirectedGraph`2<!!0,!!1>, !!1)
        }
        
        [PexMethod]
        public int RemoveEdges<TVertex,TEdge>(
            [PexAssumeUnderTest]UndirectedGraph<TVertex, TEdge> target,
            IEnumerable<TEdge> edges
        )
            where TEdge : IEdge<TVertex>
        {
            int result = target.RemoveEdges(edges);
            return result;
            // TODO: add assertions to method UndirectedGraphTVertexTEdgeTest.RemoveEdges(UndirectedGraph`2<!!0,!!1>, IEnumerable`1<!!1>)
        }
        
        [PexMethod]
        public bool RemoveVertex<TVertex,TEdge>([PexAssumeUnderTest]UndirectedGraph<TVertex, TEdge> target, TVertex v)
            where TEdge : IEdge<TVertex>
        {
            bool result = target.RemoveVertex(v);
            return result;
            // TODO: add assertions to method UndirectedGraphTVertexTEdgeTest.RemoveVertex(UndirectedGraph`2<!!0,!!1>, !!0)
        }
        
        [PexMethod]
        public void TrimEdgeExcess<TVertex,TEdge>([PexAssumeUnderTest]UndirectedGraph<TVertex, TEdge> target)
            where TEdge : IEdge<TVertex>
        {
            target.TrimEdgeExcess();
            // TODO: add assertions to method UndirectedGraphTVertexTEdgeTest.TrimEdgeExcess(UndirectedGraph`2<!!0,!!1>)
        }
        
        [PexMethod]
        public void VertexCountGet<TVertex,TEdge>([PexAssumeUnderTest]UndirectedGraph<TVertex, TEdge> target)
            where TEdge : IEdge<TVertex>
        {
            int result = target.VertexCount;
            PexStore.ValueForValidation<int>("result", result);
            // TODO: add assertions to method UndirectedGraphTVertexTEdgeTest.VertexCountGet(UndirectedGraph`2<!!0,!!1>)
        }
        
        [PexMethod]
        public void VerticesGet<TVertex,TEdge>([PexAssumeUnderTest]UndirectedGraph<TVertex, TEdge> target)
            where TEdge : IEdge<TVertex>
        {
            IEnumerable<TVertex> result = target.Vertices;
            PexStore.ValueForValidation<IEnumerable<TVertex>>("result", result);
            // TODO: add assertions to method UndirectedGraphTVertexTEdgeTest.VerticesGet(UndirectedGraph`2<!!0,!!1>)
        }
        
    }
}
