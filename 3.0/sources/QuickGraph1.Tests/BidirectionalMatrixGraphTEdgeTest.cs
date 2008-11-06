using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Wizard;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using QuickGraph;
using System.Collections;
using System.Collections.Generic;

namespace QuickGraph
{
    /// <summary>
    /// This class contains parameterized unit tests for BidirectionalMatrixGraph`1
    /// </summary>
    [TestClass]
    [PexClass(typeof(BidirectionalMatrixGraph<>))]
    [PexGenericArguments(typeof(Edge<int>))]
    public partial class BidirectionalMatrixGraphTEdgeTest
    {
        [PexMethod]
        public bool AddEdge<TEdge>(
            [PexAssumeUnderTest]BidirectionalMatrixGraph<TEdge> target,
            TEdge edge
        )
            where TEdge : IEdge<int>
        {
            bool result = target.AddEdge(edge);
            return result;
            // TODO: add assertions to method BidirectionalMatrixGraphTEdgeTest.AddEdge(BidirectionalMatrixGraph`1<!!0>, !!0)
        }
        
        [PexMethod]
        public void AddEdgeRange<TEdge>(
            [PexAssumeUnderTest]BidirectionalMatrixGraph<TEdge> target,
            IEnumerable<TEdge> edges
        )
            where TEdge : IEdge<int>
        {
            target.AddEdgeRange(edges);
            // TODO: add assertions to method BidirectionalMatrixGraphTEdgeTest.AddEdgeRange(BidirectionalMatrixGraph`1<!!0>, IEnumerable`1<!!0>)
        }
        
        [PexMethod]
        public void AllowParallelEdgesGet<TEdge>([PexAssumeUnderTest]BidirectionalMatrixGraph<TEdge> target)
            where TEdge : IEdge<int>
        {
            bool result = target.AllowParallelEdges;
            PexStore.ValueForValidation<bool>("result", result);
            // TODO: add assertions to method BidirectionalMatrixGraphTEdgeTest.AllowParallelEdgesGet(BidirectionalMatrixGraph`1<!!0>)
        }
        
        [PexMethod]
        public void Clear<TEdge>([PexAssumeUnderTest]BidirectionalMatrixGraph<TEdge> target)
            where TEdge : IEdge<int>
        {
            target.Clear();
            // TODO: add assertions to method BidirectionalMatrixGraphTEdgeTest.Clear(BidirectionalMatrixGraph`1<!!0>)
        }
        
        [PexMethod]
        public void ClearEdges<TEdge>(
            [PexAssumeUnderTest]BidirectionalMatrixGraph<TEdge> target,
            int v
        )
            where TEdge : IEdge<int>
        {
            target.ClearEdges(v);
            // TODO: add assertions to method BidirectionalMatrixGraphTEdgeTest.ClearEdges(BidirectionalMatrixGraph`1<!!0>, Int32)
        }
        
        [PexMethod]
        public void ClearInEdges<TEdge>(
            [PexAssumeUnderTest]BidirectionalMatrixGraph<TEdge> target,
            int v
        )
            where TEdge : IEdge<int>
        {
            target.ClearInEdges(v);
            // TODO: add assertions to method BidirectionalMatrixGraphTEdgeTest.ClearInEdges(BidirectionalMatrixGraph`1<!!0>, Int32)
        }
        
        [PexMethod]
        public void ClearOutEdges<TEdge>(
            [PexAssumeUnderTest]BidirectionalMatrixGraph<TEdge> target,
            int v
        )
            where TEdge : IEdge<int>
        {
            target.ClearOutEdges(v);
            // TODO: add assertions to method BidirectionalMatrixGraphTEdgeTest.ClearOutEdges(BidirectionalMatrixGraph`1<!!0>, Int32)
        }
        
        [PexMethod]
        public void Clone<TEdge>([PexAssumeUnderTest]BidirectionalMatrixGraph<TEdge> target)
            where TEdge : IEdge<int>
        {
            BidirectionalMatrixGraph<TEdge> result = target.Clone();
            PexStore.ValueForValidation<BidirectionalMatrixGraph<TEdge>>("result", result);
            // TODO: add assertions to method BidirectionalMatrixGraphTEdgeTest.Clone(BidirectionalMatrixGraph`1<!!0>)
        }
        
        [PexMethod]
        public BidirectionalMatrixGraph<TEdge> Constructor<TEdge>(int vertexCount)
            where TEdge : IEdge<int>
        {
            BidirectionalMatrixGraph<TEdge> target
               = new BidirectionalMatrixGraph<TEdge>(vertexCount);
            return target;
            // TODO: add assertions to method BidirectionalMatrixGraphTEdgeTest.Constructor(Int32)
        }
        
        [PexMethod]
        public bool ContainsEdge<TEdge>(
            [PexAssumeUnderTest]BidirectionalMatrixGraph<TEdge> target01,
            int source,
            int target
        )
            where TEdge : IEdge<int>
        {
            bool result = target01.ContainsEdge(source, target);
            return result;
            // TODO: add assertions to method BidirectionalMatrixGraphTEdgeTest.ContainsEdge(BidirectionalMatrixGraph`1<!!0>, Int32, Int32)
        }
        
        [PexMethod]
        public bool ContainsEdge01<TEdge>(
            [PexAssumeUnderTest]BidirectionalMatrixGraph<TEdge> target,
            TEdge edge
        )
            where TEdge : IEdge<int>
        {
            bool result = target.ContainsEdge(edge);
            return result;
            // TODO: add assertions to method BidirectionalMatrixGraphTEdgeTest.ContainsEdge01(BidirectionalMatrixGraph`1<!!0>, !!0)
        }
        
        [PexMethod]
        public bool ContainsVertex<TEdge>(
            [PexAssumeUnderTest]BidirectionalMatrixGraph<TEdge> target,
            int vertex
        )
            where TEdge : IEdge<int>
        {
            bool result = target.ContainsVertex(vertex);
            return result;
            // TODO: add assertions to method BidirectionalMatrixGraphTEdgeTest.ContainsVertex(BidirectionalMatrixGraph`1<!!0>, Int32)
        }
        
        [PexMethod]
        public int Degree<TEdge>(
            [PexAssumeUnderTest]BidirectionalMatrixGraph<TEdge> target,
            int v
        )
            where TEdge : IEdge<int>
        {
            int result = target.Degree(v);
            return result;
            // TODO: add assertions to method BidirectionalMatrixGraphTEdgeTest.Degree(BidirectionalMatrixGraph`1<!!0>, Int32)
        }
        
        [PexMethod]
        public void EdgeCountGet<TEdge>([PexAssumeUnderTest]BidirectionalMatrixGraph<TEdge> target)
            where TEdge : IEdge<int>
        {
            int result = target.EdgeCount;
            PexStore.ValueForValidation<int>("result", result);
            // TODO: add assertions to method BidirectionalMatrixGraphTEdgeTest.EdgeCountGet(BidirectionalMatrixGraph`1<!!0>)
        }
        
        [PexMethod]
        public void EdgesGet<TEdge>([PexAssumeUnderTest]BidirectionalMatrixGraph<TEdge> target)
            where TEdge : IEdge<int>
        {
            IEnumerable<TEdge> result = target.Edges;
            PexStore.ValueForValidation<IEnumerable<TEdge>>("result", result);
            // TODO: add assertions to method BidirectionalMatrixGraphTEdgeTest.EdgesGet(BidirectionalMatrixGraph`1<!!0>)
        }
        
        [PexMethod]
        public int InDegree<TEdge>(
            [PexAssumeUnderTest]BidirectionalMatrixGraph<TEdge> target,
            int v
        )
            where TEdge : IEdge<int>
        {
            int result = target.InDegree(v);
            return result;
            // TODO: add assertions to method BidirectionalMatrixGraphTEdgeTest.InDegree(BidirectionalMatrixGraph`1<!!0>, Int32)
        }
        
        [PexMethod]
        public void InEdge<TEdge>(
            [PexAssumeUnderTest]BidirectionalMatrixGraph<TEdge> target,
            int v,
            int index
        )
            where TEdge : IEdge<int>
        {
            TEdge result = target.InEdge(v, index);
            PexStore.ValueForValidation<TEdge>("result", result);
            // TODO: add assertions to method BidirectionalMatrixGraphTEdgeTest.InEdge(BidirectionalMatrixGraph`1<!!0>, Int32, Int32)
        }
        
        [PexMethod]
        public void InEdges<TEdge>(
            [PexAssumeUnderTest]BidirectionalMatrixGraph<TEdge> target,
            int v
        )
            where TEdge : IEdge<int>
        {
            IEnumerable<TEdge> result = target.InEdges(v);
            PexStore.ValueForValidation<IEnumerable<TEdge>>("result", result);
            PexEnumerablePatterns.ForEach<TEdge>(result);
            PexEnumerablePatterns.ForEach((IEnumerable)result);
            PexEnumerablePatterns.DoubleForEach<TEdge>(result);
            PexEnumerablePatterns.MoveNextAndReset<TEdge>(result);
            // TODO: add assertions to method BidirectionalMatrixGraphTEdgeTest.InEdges(BidirectionalMatrixGraph`1<!!0>, Int32)
        }
        
        [PexMethod]
        public void IsDirectedGet<TEdge>([PexAssumeUnderTest]BidirectionalMatrixGraph<TEdge> target)
            where TEdge : IEdge<int>
        {
            bool result = target.IsDirected;
            PexStore.ValueForValidation<bool>("result", result);
            // TODO: add assertions to method BidirectionalMatrixGraphTEdgeTest.IsDirectedGet(BidirectionalMatrixGraph`1<!!0>)
        }
        
        [PexMethod]
        public void IsEdgesEmptyGet<TEdge>([PexAssumeUnderTest]BidirectionalMatrixGraph<TEdge> target)
            where TEdge : IEdge<int>
        {
            bool result = target.IsEdgesEmpty;
            PexStore.ValueForValidation<bool>("result", result);
            // TODO: add assertions to method BidirectionalMatrixGraphTEdgeTest.IsEdgesEmptyGet(BidirectionalMatrixGraph`1<!!0>)
        }
        
        [PexMethod]
        public bool IsInEdgesEmpty<TEdge>(
            [PexAssumeUnderTest]BidirectionalMatrixGraph<TEdge> target,
            int v
        )
            where TEdge : IEdge<int>
        {
            bool result = target.IsInEdgesEmpty(v);
            return result;
            // TODO: add assertions to method BidirectionalMatrixGraphTEdgeTest.IsInEdgesEmpty(BidirectionalMatrixGraph`1<!!0>, Int32)
        }
        
        [PexMethod]
        public bool IsOutEdgesEmpty<TEdge>(
            [PexAssumeUnderTest]BidirectionalMatrixGraph<TEdge> target,
            int v
        )
            where TEdge : IEdge<int>
        {
            bool result = target.IsOutEdgesEmpty(v);
            return result;
            // TODO: add assertions to method BidirectionalMatrixGraphTEdgeTest.IsOutEdgesEmpty(BidirectionalMatrixGraph`1<!!0>, Int32)
        }
        
        [PexMethod]
        public void IsVerticesEmptyGet<TEdge>([PexAssumeUnderTest]BidirectionalMatrixGraph<TEdge> target)
            where TEdge : IEdge<int>
        {
            bool result = target.IsVerticesEmpty;
            PexStore.ValueForValidation<bool>("result", result);
            // TODO: add assertions to method BidirectionalMatrixGraphTEdgeTest.IsVerticesEmptyGet(BidirectionalMatrixGraph`1<!!0>)
        }
        
        [PexMethod]
        public int OutDegree<TEdge>(
            [PexAssumeUnderTest]BidirectionalMatrixGraph<TEdge> target,
            int v
        )
            where TEdge : IEdge<int>
        {
            int result = target.OutDegree(v);
            return result;
            // TODO: add assertions to method BidirectionalMatrixGraphTEdgeTest.OutDegree(BidirectionalMatrixGraph`1<!!0>, Int32)
        }
        
        [PexMethod]
        public void OutEdge<TEdge>(
            [PexAssumeUnderTest]BidirectionalMatrixGraph<TEdge> target,
            int v,
            int index
        )
            where TEdge : IEdge<int>
        {
            TEdge result = target.OutEdge(v, index);
            PexStore.ValueForValidation<TEdge>("result", result);
            // TODO: add assertions to method BidirectionalMatrixGraphTEdgeTest.OutEdge(BidirectionalMatrixGraph`1<!!0>, Int32, Int32)
        }
        
        [PexMethod]
        public void OutEdges<TEdge>(
            [PexAssumeUnderTest]BidirectionalMatrixGraph<TEdge> target,
            int v
        )
            where TEdge : IEdge<int>
        {
            IEnumerable<TEdge> result = target.OutEdges(v);
            PexStore.ValueForValidation<IEnumerable<TEdge>>("result", result);
            PexEnumerablePatterns.ForEach<TEdge>(result);
            PexEnumerablePatterns.ForEach((IEnumerable)result);
            PexEnumerablePatterns.DoubleForEach<TEdge>(result);
            PexEnumerablePatterns.MoveNextAndReset<TEdge>(result);
            // TODO: add assertions to method BidirectionalMatrixGraphTEdgeTest.OutEdges(BidirectionalMatrixGraph`1<!!0>, Int32)
        }
        
        [PexMethod]
        public bool RemoveEdge<TEdge>(
            [PexAssumeUnderTest]BidirectionalMatrixGraph<TEdge> target,
            TEdge edge
        )
            where TEdge : IEdge<int>
        {
            bool result = target.RemoveEdge(edge);
            return result;
            // TODO: add assertions to method BidirectionalMatrixGraphTEdgeTest.RemoveEdge(BidirectionalMatrixGraph`1<!!0>, !!0)
        }
        
        [PexMethod]
        public bool TryGetEdge<TEdge>(
            [PexAssumeUnderTest]BidirectionalMatrixGraph<TEdge> target01,
            int source,
            int target,
            out TEdge edge
        )
            where TEdge : IEdge<int>
        {
            bool result = target01.TryGetEdge(source, target, out edge);
            return result;
            // TODO: add assertions to method BidirectionalMatrixGraphTEdgeTest.TryGetEdge(BidirectionalMatrixGraph`1<!!0>, Int32, Int32, !!0&)
        }
        
        [PexMethod]
        public bool TryGetEdges<TEdge>(
            [PexAssumeUnderTest]BidirectionalMatrixGraph<TEdge> target01,
            int source,
            int target,
            out IEnumerable<TEdge> edges
        )
            where TEdge : IEdge<int>
        {
            bool result = target01.TryGetEdges(source, target, out edges);
            return result;
            // TODO: add assertions to method BidirectionalMatrixGraphTEdgeTest.TryGetEdges(BidirectionalMatrixGraph`1<!!0>, Int32, Int32, IEnumerable`1<!!0>&)
        }
        
        [PexMethod]
        public void VertexCountGet<TEdge>([PexAssumeUnderTest]BidirectionalMatrixGraph<TEdge> target)
            where TEdge : IEdge<int>
        {
            int result = target.VertexCount;
            PexStore.ValueForValidation<int>("result", result);
            // TODO: add assertions to method BidirectionalMatrixGraphTEdgeTest.VertexCountGet(BidirectionalMatrixGraph`1<!!0>)
        }
        
        [PexMethod]
        public void VerticesGet<TEdge>([PexAssumeUnderTest]BidirectionalMatrixGraph<TEdge> target)
            where TEdge : IEdge<int>
        {
            IEnumerable<int> result = target.Vertices;
            PexStore.ValueForValidation<IEnumerable<int>>("result", result);
            // TODO: add assertions to method BidirectionalMatrixGraphTEdgeTest.VerticesGet(BidirectionalMatrixGraph`1<!!0>)
        }
        
    }
}
