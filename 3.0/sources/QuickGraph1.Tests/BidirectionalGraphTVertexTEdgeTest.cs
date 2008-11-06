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
    /// This class contains parameterized unit tests for BidirectionalGraph`2
    /// </summary>
    [TestClass]
    [PexClass(typeof(BidirectionalGraph<, >))]
    [PexGenericArguments(typeof(int), typeof(Edge<int>))]
    public partial class BidirectionalGraphTVertexTEdgeTest
    {
        [PexMethod]
        public bool AddEdge<TVertex,TEdge>([PexAssumeUnderTest]BidirectionalGraph<TVertex, TEdge> target, TEdge e)
            where TEdge : IEdge<TVertex>
        {
            bool result = target.AddEdge(e);
            return result;
            // TODO: add assertions to method BidirectionalGraphTVertexTEdgeTest.AddEdge(BidirectionalGraph`2<!!0,!!1>, !!1)
        }
        
        [PexMethod]
        public void AddEdgeRange<TVertex,TEdge>(
            [PexAssumeUnderTest]BidirectionalGraph<TVertex, TEdge> target,
            IEnumerable<TEdge> edges
        )
            where TEdge : IEdge<TVertex>
        {
            target.AddEdgeRange(edges);
            // TODO: add assertions to method BidirectionalGraphTVertexTEdgeTest.AddEdgeRange(BidirectionalGraph`2<!!0,!!1>, IEnumerable`1<!!1>)
        }
        
        [PexMethod]
        public void AddVertex<TVertex,TEdge>([PexAssumeUnderTest]BidirectionalGraph<TVertex, TEdge> target, TVertex v)
            where TEdge : IEdge<TVertex>
        {
            target.AddVertex(v);
            // TODO: add assertions to method BidirectionalGraphTVertexTEdgeTest.AddVertex(BidirectionalGraph`2<!!0,!!1>, !!0)
        }
        
        [PexMethod]
        public void AddVertexRange<TVertex,TEdge>(
            [PexAssumeUnderTest]BidirectionalGraph<TVertex, TEdge> target,
            IEnumerable<TVertex> vertices
        )
            where TEdge : IEdge<TVertex>
        {
            target.AddVertexRange(vertices);
            // TODO: add assertions to method BidirectionalGraphTVertexTEdgeTest.AddVertexRange(BidirectionalGraph`2<!!0,!!1>, IEnumerable`1<!!0>)
        }
        
        [PexMethod]
        public bool AddVerticesAndEdge<TVertex,TEdge>([PexAssumeUnderTest]BidirectionalGraph<TVertex, TEdge> target, TEdge e)
            where TEdge : IEdge<TVertex>
        {
            bool result = target.AddVerticesAndEdge(e);
            return result;
            // TODO: add assertions to method BidirectionalGraphTVertexTEdgeTest.AddVerticesAndEdge(BidirectionalGraph`2<!!0,!!1>, !!1)
        }
        
        [PexMethod]
        public void AllowParallelEdgesGet<TVertex,TEdge>([PexAssumeUnderTest]BidirectionalGraph<TVertex, TEdge> target)
            where TEdge : IEdge<TVertex>
        {
            bool result = target.AllowParallelEdges;
            PexStore.ValueForValidation<bool>("result", result);
            // TODO: add assertions to method BidirectionalGraphTVertexTEdgeTest.AllowParallelEdgesGet(BidirectionalGraph`2<!!0,!!1>)
        }
        
        [PexMethod]
        public void Clear<TVertex,TEdge>([PexAssumeUnderTest]BidirectionalGraph<TVertex, TEdge> target)
            where TEdge : IEdge<TVertex>
        {
            target.Clear();
            // TODO: add assertions to method BidirectionalGraphTVertexTEdgeTest.Clear(BidirectionalGraph`2<!!0,!!1>)
        }
        
        [PexMethod]
        public void ClearEdges<TVertex,TEdge>([PexAssumeUnderTest]BidirectionalGraph<TVertex, TEdge> target, TVertex v)
            where TEdge : IEdge<TVertex>
        {
            target.ClearEdges(v);
            // TODO: add assertions to method BidirectionalGraphTVertexTEdgeTest.ClearEdges(BidirectionalGraph`2<!!0,!!1>, !!0)
        }
        
        [PexMethod]
        public void ClearInEdges<TVertex,TEdge>([PexAssumeUnderTest]BidirectionalGraph<TVertex, TEdge> target, TVertex v)
            where TEdge : IEdge<TVertex>
        {
            target.ClearInEdges(v);
            // TODO: add assertions to method BidirectionalGraphTVertexTEdgeTest.ClearInEdges(BidirectionalGraph`2<!!0,!!1>, !!0)
        }
        
        [PexMethod]
        public void ClearOutEdges<TVertex,TEdge>([PexAssumeUnderTest]BidirectionalGraph<TVertex, TEdge> target, TVertex v)
            where TEdge : IEdge<TVertex>
        {
            target.ClearOutEdges(v);
            // TODO: add assertions to method BidirectionalGraphTVertexTEdgeTest.ClearOutEdges(BidirectionalGraph`2<!!0,!!1>, !!0)
        }
        
        [PexMethod]
        public void Clone<TVertex,TEdge>([PexAssumeUnderTest]BidirectionalGraph<TVertex, TEdge> target)
            where TEdge : IEdge<TVertex>
        {
            BidirectionalGraph<TVertex, TEdge> result = target.Clone();
            PexStore.ValueForValidation<BidirectionalGraph<TVertex, TEdge>>
                ("result", result);
            // TODO: add assertions to method BidirectionalGraphTVertexTEdgeTest.Clone(BidirectionalGraph`2<!!0,!!1>)
        }
        
        [PexMethod]
        public BidirectionalGraph<TVertex, TEdge> Constructor<TVertex,TEdge>()
            where TEdge : IEdge<TVertex>
        {
            BidirectionalGraph<TVertex, TEdge> target
               = new BidirectionalGraph<TVertex, TEdge>();
            return target;
            // TODO: add assertions to method BidirectionalGraphTVertexTEdgeTest.Constructor()
        }
        
        [PexMethod]
        public BidirectionalGraph<TVertex, TEdge> Constructor01<TVertex,TEdge>(bool allowParallelEdges)
            where TEdge : IEdge<TVertex>
        {
            BidirectionalGraph<TVertex, TEdge> target
               = new BidirectionalGraph<TVertex, TEdge>(allowParallelEdges);
            return target;
            // TODO: add assertions to method BidirectionalGraphTVertexTEdgeTest.Constructor01(Boolean)
        }
        
        [PexMethod]
        public BidirectionalGraph<TVertex, TEdge> Constructor02<TVertex,TEdge>(bool allowParallelEdges, int vertexCapacity)
            where TEdge : IEdge<TVertex>
        {
            BidirectionalGraph<TVertex, TEdge> target
               = new BidirectionalGraph<TVertex, TEdge>(allowParallelEdges, vertexCapacity);
            return target;
            // TODO: add assertions to method BidirectionalGraphTVertexTEdgeTest.Constructor02(Boolean, Int32)
        }
        
        [PexMethod]
        public bool ContainsEdge<TVertex,TEdge>(
            [PexAssumeUnderTest]BidirectionalGraph<TVertex, TEdge> target01,
            TVertex source,
            TVertex target
        )
            where TEdge : IEdge<TVertex>
        {
            bool result = target01.ContainsEdge(source, target);
            return result;
            // TODO: add assertions to method BidirectionalGraphTVertexTEdgeTest.ContainsEdge(BidirectionalGraph`2<!!0,!!1>, !!0, !!0)
        }
        
        [PexMethod]
        public bool ContainsEdge01<TVertex,TEdge>(
            [PexAssumeUnderTest]BidirectionalGraph<TVertex, TEdge> target,
            TEdge edge
        )
            where TEdge : IEdge<TVertex>
        {
            bool result = target.ContainsEdge(edge);
            return result;
            // TODO: add assertions to method BidirectionalGraphTVertexTEdgeTest.ContainsEdge01(BidirectionalGraph`2<!!0,!!1>, !!1)
        }
        
        [PexMethod]
        public bool ContainsVertex<TVertex,TEdge>([PexAssumeUnderTest]BidirectionalGraph<TVertex, TEdge> target, TVertex v)
            where TEdge : IEdge<TVertex>
        {
            bool result = target.ContainsVertex(v);
            return result;
            // TODO: add assertions to method BidirectionalGraphTVertexTEdgeTest.ContainsVertex(BidirectionalGraph`2<!!0,!!1>, !!0)
        }
        
        [PexMethod]
        public int Degree<TVertex,TEdge>([PexAssumeUnderTest]BidirectionalGraph<TVertex, TEdge> target, TVertex v)
            where TEdge : IEdge<TVertex>
        {
            int result = target.Degree(v);
            return result;
            // TODO: add assertions to method BidirectionalGraphTVertexTEdgeTest.Degree(BidirectionalGraph`2<!!0,!!1>, !!0)
        }
        
        [PexMethod]
        public void EdgeCapacityGetSet<TVertex,TEdge>(
            [PexAssumeUnderTest]BidirectionalGraph<TVertex, TEdge> target,
            int value
        )
            where TEdge : IEdge<TVertex>
        {
            target.EdgeCapacity = value;
            int result = target.EdgeCapacity;
            PexStore.ValueForValidation<int>("result", result);
            PexAssert.AreEqual((object)value, (object)result);
            // TODO: add assertions to method BidirectionalGraphTVertexTEdgeTest.EdgeCapacityGetSet(BidirectionalGraph`2<!!0,!!1>, Int32)
        }
        
        [PexMethod]
        public void EdgeCountGet<TVertex,TEdge>([PexAssumeUnderTest]BidirectionalGraph<TVertex, TEdge> target)
            where TEdge : IEdge<TVertex>
        {
            int result = target.EdgeCount;
            PexStore.ValueForValidation<int>("result", result);
            // TODO: add assertions to method BidirectionalGraphTVertexTEdgeTest.EdgeCountGet(BidirectionalGraph`2<!!0,!!1>)
        }
        
        [PexMethod]
        public void EdgeTypeGet<TVertex,TEdge>()
            where TEdge : IEdge<TVertex>
        {
            Type result = BidirectionalGraph<TVertex, TEdge>.EdgeType;
            PexStore.ValueForValidation<Type>("result", result);
            // TODO: add assertions to method BidirectionalGraphTVertexTEdgeTest.EdgeTypeGet()
        }
        
        [PexMethod]
        public void EdgesGet<TVertex,TEdge>([PexAssumeUnderTest]BidirectionalGraph<TVertex, TEdge> target)
            where TEdge : IEdge<TVertex>
        {
            IEnumerable<TEdge> result = target.Edges;
            PexStore.ValueForValidation<IEnumerable<TEdge>>("result", result);
            // TODO: add assertions to method BidirectionalGraphTVertexTEdgeTest.EdgesGet(BidirectionalGraph`2<!!0,!!1>)
        }
        
        [PexMethod]
        public int InDegree<TVertex,TEdge>([PexAssumeUnderTest]BidirectionalGraph<TVertex, TEdge> target, TVertex v)
            where TEdge : IEdge<TVertex>
        {
            int result = target.InDegree(v);
            return result;
            // TODO: add assertions to method BidirectionalGraphTVertexTEdgeTest.InDegree(BidirectionalGraph`2<!!0,!!1>, !!0)
        }
        
        [PexMethod]
        public void InEdge<TVertex,TEdge>(
            [PexAssumeUnderTest]BidirectionalGraph<TVertex, TEdge> target,
            TVertex v,
            int index
        )
            where TEdge : IEdge<TVertex>
        {
            TEdge result = target.InEdge(v, index);
            PexStore.ValueForValidation<TEdge>("result", result);
            // TODO: add assertions to method BidirectionalGraphTVertexTEdgeTest.InEdge(BidirectionalGraph`2<!!0,!!1>, !!0, Int32)
        }
        
        [PexMethod]
        public void InEdges<TVertex,TEdge>([PexAssumeUnderTest]BidirectionalGraph<TVertex, TEdge> target, TVertex v)
            where TEdge : IEdge<TVertex>
        {
            IEnumerable<TEdge> result = target.InEdges(v);
            PexStore.ValueForValidation<IEnumerable<TEdge>>("result", result);
            PexEnumerablePatterns.ForEach<TEdge>(result);
            PexEnumerablePatterns.ForEach((IEnumerable)result);
            PexEnumerablePatterns.DoubleForEach<TEdge>(result);
            PexEnumerablePatterns.MoveNextAndReset<TEdge>(result);
            // TODO: add assertions to method BidirectionalGraphTVertexTEdgeTest.InEdges(BidirectionalGraph`2<!!0,!!1>, !!0)
        }
        
        [PexMethod]
        public void IsDirectedGet<TVertex,TEdge>([PexAssumeUnderTest]BidirectionalGraph<TVertex, TEdge> target)
            where TEdge : IEdge<TVertex>
        {
            bool result = target.IsDirected;
            PexStore.ValueForValidation<bool>("result", result);
            // TODO: add assertions to method BidirectionalGraphTVertexTEdgeTest.IsDirectedGet(BidirectionalGraph`2<!!0,!!1>)
        }
        
        [PexMethod]
        public void IsEdgesEmptyGet<TVertex,TEdge>([PexAssumeUnderTest]BidirectionalGraph<TVertex, TEdge> target)
            where TEdge : IEdge<TVertex>
        {
            bool result = target.IsEdgesEmpty;
            PexStore.ValueForValidation<bool>("result", result);
            // TODO: add assertions to method BidirectionalGraphTVertexTEdgeTest.IsEdgesEmptyGet(BidirectionalGraph`2<!!0,!!1>)
        }
        
        [PexMethod]
        public bool IsInEdgesEmpty<TVertex,TEdge>([PexAssumeUnderTest]BidirectionalGraph<TVertex, TEdge> target, TVertex v)
            where TEdge : IEdge<TVertex>
        {
            bool result = target.IsInEdgesEmpty(v);
            return result;
            // TODO: add assertions to method BidirectionalGraphTVertexTEdgeTest.IsInEdgesEmpty(BidirectionalGraph`2<!!0,!!1>, !!0)
        }
        
        [PexMethod]
        public bool IsOutEdgesEmpty<TVertex,TEdge>([PexAssumeUnderTest]BidirectionalGraph<TVertex, TEdge> target, TVertex v)
            where TEdge : IEdge<TVertex>
        {
            bool result = target.IsOutEdgesEmpty(v);
            return result;
            // TODO: add assertions to method BidirectionalGraphTVertexTEdgeTest.IsOutEdgesEmpty(BidirectionalGraph`2<!!0,!!1>, !!0)
        }
        
        [PexMethod]
        public void IsVerticesEmptyGet<TVertex,TEdge>([PexAssumeUnderTest]BidirectionalGraph<TVertex, TEdge> target)
            where TEdge : IEdge<TVertex>
        {
            bool result = target.IsVerticesEmpty;
            PexStore.ValueForValidation<bool>("result", result);
            // TODO: add assertions to method BidirectionalGraphTVertexTEdgeTest.IsVerticesEmptyGet(BidirectionalGraph`2<!!0,!!1>)
        }
        
        [PexMethod]
        public int OutDegree<TVertex,TEdge>([PexAssumeUnderTest]BidirectionalGraph<TVertex, TEdge> target, TVertex v)
            where TEdge : IEdge<TVertex>
        {
            int result = target.OutDegree(v);
            return result;
            // TODO: add assertions to method BidirectionalGraphTVertexTEdgeTest.OutDegree(BidirectionalGraph`2<!!0,!!1>, !!0)
        }
        
        [PexMethod]
        public void OutEdge<TVertex,TEdge>(
            [PexAssumeUnderTest]BidirectionalGraph<TVertex, TEdge> target,
            TVertex v,
            int index
        )
            where TEdge : IEdge<TVertex>
        {
            TEdge result = target.OutEdge(v, index);
            PexStore.ValueForValidation<TEdge>("result", result);
            // TODO: add assertions to method BidirectionalGraphTVertexTEdgeTest.OutEdge(BidirectionalGraph`2<!!0,!!1>, !!0, Int32)
        }
        
        [PexMethod]
        public void OutEdges<TVertex,TEdge>([PexAssumeUnderTest]BidirectionalGraph<TVertex, TEdge> target, TVertex v)
            where TEdge : IEdge<TVertex>
        {
            IEnumerable<TEdge> result = target.OutEdges(v);
            PexStore.ValueForValidation<IEnumerable<TEdge>>("result", result);
            PexEnumerablePatterns.ForEach<TEdge>(result);
            PexEnumerablePatterns.ForEach((IEnumerable)result);
            PexEnumerablePatterns.DoubleForEach<TEdge>(result);
            PexEnumerablePatterns.MoveNextAndReset<TEdge>(result);
            // TODO: add assertions to method BidirectionalGraphTVertexTEdgeTest.OutEdges(BidirectionalGraph`2<!!0,!!1>, !!0)
        }
        
        [PexMethod]
        public bool RemoveEdge<TVertex,TEdge>([PexAssumeUnderTest]BidirectionalGraph<TVertex, TEdge> target, TEdge e)
            where TEdge : IEdge<TVertex>
        {
            bool result = target.RemoveEdge(e);
            return result;
            // TODO: add assertions to method BidirectionalGraphTVertexTEdgeTest.RemoveEdge(BidirectionalGraph`2<!!0,!!1>, !!1)
        }
        
        [PexMethod]
        public bool RemoveVertex<TVertex,TEdge>([PexAssumeUnderTest]BidirectionalGraph<TVertex, TEdge> target, TVertex v)
            where TEdge : IEdge<TVertex>
        {
            bool result = target.RemoveVertex(v);
            return result;
            // TODO: add assertions to method BidirectionalGraphTVertexTEdgeTest.RemoveVertex(BidirectionalGraph`2<!!0,!!1>, !!0)
        }
        
        [PexMethod]
        public void TrimEdgeExcess<TVertex,TEdge>([PexAssumeUnderTest]BidirectionalGraph<TVertex, TEdge> target)
            where TEdge : IEdge<TVertex>
        {
            target.TrimEdgeExcess();
            // TODO: add assertions to method BidirectionalGraphTVertexTEdgeTest.TrimEdgeExcess(BidirectionalGraph`2<!!0,!!1>)
        }
        
        [PexMethod]
        public bool TryGetEdge<TVertex,TEdge>(
            [PexAssumeUnderTest]BidirectionalGraph<TVertex, TEdge> target01,
            TVertex source,
            TVertex target,
            out TEdge edge
        )
            where TEdge : IEdge<TVertex>
        {
            bool result = target01.TryGetEdge(source, target, out edge);
            return result;
            // TODO: add assertions to method BidirectionalGraphTVertexTEdgeTest.TryGetEdge(BidirectionalGraph`2<!!0,!!1>, !!0, !!0, !!1&)
        }
        
        [PexMethod]
        public bool TryGetEdges<TVertex,TEdge>(
            [PexAssumeUnderTest]BidirectionalGraph<TVertex, TEdge> target01,
            TVertex source,
            TVertex target,
            out IEnumerable<TEdge> edges
        )
            where TEdge : IEdge<TVertex>
        {
            bool result = target01.TryGetEdges(source, target, out edges);
            return result;
            // TODO: add assertions to method BidirectionalGraphTVertexTEdgeTest.TryGetEdges(BidirectionalGraph`2<!!0,!!1>, !!0, !!0, IEnumerable`1<!!1>&)
        }
        
        [PexMethod]
        public void VertexCountGet<TVertex,TEdge>([PexAssumeUnderTest]BidirectionalGraph<TVertex, TEdge> target)
            where TEdge : IEdge<TVertex>
        {
            int result = target.VertexCount;
            PexStore.ValueForValidation<int>("result", result);
            // TODO: add assertions to method BidirectionalGraphTVertexTEdgeTest.VertexCountGet(BidirectionalGraph`2<!!0,!!1>)
        }
        
        [PexMethod]
        public void VertexTypeGet<TVertex,TEdge>()
            where TEdge : IEdge<TVertex>
        {
            Type result = BidirectionalGraph<TVertex, TEdge>.VertexType;
            PexStore.ValueForValidation<Type>("result", result);
            // TODO: add assertions to method BidirectionalGraphTVertexTEdgeTest.VertexTypeGet()
        }
        
        [PexMethod]
        public void VerticesGet<TVertex,TEdge>([PexAssumeUnderTest]BidirectionalGraph<TVertex, TEdge> target)
            where TEdge : IEdge<TVertex>
        {
            IEnumerable<TVertex> result = target.Vertices;
            PexStore.ValueForValidation<IEnumerable<TVertex>>("result", result);
            // TODO: add assertions to method BidirectionalGraphTVertexTEdgeTest.VerticesGet(BidirectionalGraph`2<!!0,!!1>)
        }
        
    }
}
