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
    /// This class contains parameterized unit tests for AdjacencyGraph`2
    /// </summary>
    [TestClass]
    [PexClass(typeof(AdjacencyGraph<, >))]
    [PexGenericArguments(typeof(int), typeof(Edge<int>))]
    public partial class AdjacencyGraphTVertexTEdgeTest
    {
        [PexMethod]
        public bool AddEdge<TVertex,TEdge>([PexAssumeUnderTest]AdjacencyGraph<TVertex, TEdge> target, TEdge e)
            where TEdge : IEdge<TVertex>
        {
            bool result = target.AddEdge(e);
            return result;
            // TODO: add assertions to method AdjacencyGraphTVertexTEdgeTest.AddEdge(AdjacencyGraph`2<!!0,!!1>, !!1)
        }
        
        [PexMethod]
        public void AddEdgeRange<TVertex,TEdge>(
            [PexAssumeUnderTest]AdjacencyGraph<TVertex, TEdge> target,
            IEnumerable<TEdge> edges
        )
            where TEdge : IEdge<TVertex>
        {
            target.AddEdgeRange(edges);
            // TODO: add assertions to method AdjacencyGraphTVertexTEdgeTest.AddEdgeRange(AdjacencyGraph`2<!!0,!!1>, IEnumerable`1<!!1>)
        }

        [PexMethod(MaxConditions = 1000)]
        public void AddVertex<TVertex,TEdge>([PexAssumeUnderTest]AdjacencyGraph<TVertex, TEdge> target, TVertex v)
            where TEdge : IEdge<TVertex>
        {
            target.AddVertex(v);
            // TODO: add assertions to method AdjacencyGraphTVertexTEdgeTest.AddVertex(AdjacencyGraph`2<!!0,!!1>, !!0)
        }
        
        [PexMethod]
        public void AddVertexRange<TVertex,TEdge>(
            [PexAssumeUnderTest]AdjacencyGraph<TVertex, TEdge> target,
            IEnumerable<TVertex> vertices
        )
            where TEdge : IEdge<TVertex>
        {
            target.AddVertexRange(vertices);
            // TODO: add assertions to method AdjacencyGraphTVertexTEdgeTest.AddVertexRange(AdjacencyGraph`2<!!0,!!1>, IEnumerable`1<!!0>)
        }
        
        [PexMethod]
        public bool AddVerticesAndEdge<TVertex,TEdge>([PexAssumeUnderTest]AdjacencyGraph<TVertex, TEdge> target, TEdge e)
            where TEdge : IEdge<TVertex>
        {
            bool result = target.AddVerticesAndEdge(e);
            return result;
            // TODO: add assertions to method AdjacencyGraphTVertexTEdgeTest.AddVerticesAndEdge(AdjacencyGraph`2<!!0,!!1>, !!1)
        }
        
        [PexMethod]
        public void AllowParallelEdgesGet<TVertex,TEdge>([PexAssumeUnderTest]AdjacencyGraph<TVertex, TEdge> target)
            where TEdge : IEdge<TVertex>
        {
            bool result = target.AllowParallelEdges;
            PexStore.ValueForValidation<bool>("result", result);
            // TODO: add assertions to method AdjacencyGraphTVertexTEdgeTest.AllowParallelEdgesGet(AdjacencyGraph`2<!!0,!!1>)
        }
        
        [PexMethod]
        public void Clear<TVertex,TEdge>([PexAssumeUnderTest]AdjacencyGraph<TVertex, TEdge> target)
            where TEdge : IEdge<TVertex>
        {
            target.Clear();
            // TODO: add assertions to method AdjacencyGraphTVertexTEdgeTest.Clear(AdjacencyGraph`2<!!0,!!1>)
        }
        
        [PexMethod]
        public void ClearOutEdges<TVertex,TEdge>([PexAssumeUnderTest]AdjacencyGraph<TVertex, TEdge> target, TVertex v)
            where TEdge : IEdge<TVertex>
        {
            target.ClearOutEdges(v);
            // TODO: add assertions to method AdjacencyGraphTVertexTEdgeTest.ClearOutEdges(AdjacencyGraph`2<!!0,!!1>, !!0)
        }
        
        [PexMethod]
        public void Clone<TVertex,TEdge>([PexAssumeUnderTest]AdjacencyGraph<TVertex, TEdge> target)
            where TEdge : IEdge<TVertex>
        {
            AdjacencyGraph<TVertex, TEdge> result = target.Clone();
            PexStore.ValueForValidation<AdjacencyGraph<TVertex, TEdge>>("result", result);
            // TODO: add assertions to method AdjacencyGraphTVertexTEdgeTest.Clone(AdjacencyGraph`2<!!0,!!1>)
        }
        
        [PexMethod]
        public AdjacencyGraph<TVertex, TEdge> Constructor<TVertex,TEdge>()
            where TEdge : IEdge<TVertex>
        {
            AdjacencyGraph<TVertex, TEdge> target = new AdjacencyGraph<TVertex, TEdge>();
            return target;
            // TODO: add assertions to method AdjacencyGraphTVertexTEdgeTest.Constructor()
        }
        
        [PexMethod]
        public AdjacencyGraph<TVertex, TEdge> Constructor01<TVertex,TEdge>(bool allowParallelEdges)
            where TEdge : IEdge<TVertex>
        {
            AdjacencyGraph<TVertex, TEdge> target
               = new AdjacencyGraph<TVertex, TEdge>(allowParallelEdges);
            return target;
            // TODO: add assertions to method AdjacencyGraphTVertexTEdgeTest.Constructor01(Boolean)
        }
        
        [PexMethod]
        public AdjacencyGraph<TVertex, TEdge> Constructor02<TVertex,TEdge>(bool allowParallelEdges, int capacity)
            where TEdge : IEdge<TVertex>
        {
            AdjacencyGraph<TVertex, TEdge> target
               = new AdjacencyGraph<TVertex, TEdge>(allowParallelEdges, capacity);
            return target;
            // TODO: add assertions to method AdjacencyGraphTVertexTEdgeTest.Constructor02(Boolean, Int32)
        }
        
        [PexMethod]
        public bool ContainsEdge<TVertex,TEdge>(
            [PexAssumeUnderTest]AdjacencyGraph<TVertex, TEdge> target01,
            TVertex source,
            TVertex target
        )
            where TEdge : IEdge<TVertex>
        {
            bool result = target01.ContainsEdge(source, target);
            return result;
            // TODO: add assertions to method AdjacencyGraphTVertexTEdgeTest.ContainsEdge(AdjacencyGraph`2<!!0,!!1>, !!0, !!0)
        }
        
        [PexMethod]
        public bool ContainsEdge01<TVertex,TEdge>([PexAssumeUnderTest]AdjacencyGraph<TVertex, TEdge> target, TEdge edge)
            where TEdge : IEdge<TVertex>
        {
            bool result = target.ContainsEdge(edge);
            return result;
            // TODO: add assertions to method AdjacencyGraphTVertexTEdgeTest.ContainsEdge01(AdjacencyGraph`2<!!0,!!1>, !!1)
        }
        
        [PexMethod]
        public bool ContainsVertex<TVertex,TEdge>([PexAssumeUnderTest]AdjacencyGraph<TVertex, TEdge> target, TVertex v)
            where TEdge : IEdge<TVertex>
        {
            bool result = target.ContainsVertex(v);
            return result;
            // TODO: add assertions to method AdjacencyGraphTVertexTEdgeTest.ContainsVertex(AdjacencyGraph`2<!!0,!!1>, !!0)
        }
        
        [PexMethod]
        public void EdgeCapacityGetSet<TVertex,TEdge>(
            [PexAssumeUnderTest]AdjacencyGraph<TVertex, TEdge> target,
            int value
        )
            where TEdge : IEdge<TVertex>
        {
            target.EdgeCapacity = value;
            int result = target.EdgeCapacity;
            PexStore.ValueForValidation<int>("result", result);
            PexAssert.AreEqual((object)value, (object)result);
            // TODO: add assertions to method AdjacencyGraphTVertexTEdgeTest.EdgeCapacityGetSet(AdjacencyGraph`2<!!0,!!1>, Int32)
        }
        
        [PexMethod]
        public void EdgeCountGet<TVertex,TEdge>([PexAssumeUnderTest]AdjacencyGraph<TVertex, TEdge> target)
            where TEdge : IEdge<TVertex>
        {
            int result = target.EdgeCount;
            PexStore.ValueForValidation<int>("result", result);
            // TODO: add assertions to method AdjacencyGraphTVertexTEdgeTest.EdgeCountGet(AdjacencyGraph`2<!!0,!!1>)
        }
        
        [PexMethod]
        public void EdgeTypeGet<TVertex,TEdge>()
            where TEdge : IEdge<TVertex>
        {
            Type result = AdjacencyGraph<TVertex, TEdge>.EdgeType;
            PexStore.ValueForValidation<Type>("result", result);
            // TODO: add assertions to method AdjacencyGraphTVertexTEdgeTest.EdgeTypeGet()
        }
        
        [PexMethod]
        public void EdgesGet<TVertex,TEdge>([PexAssumeUnderTest]AdjacencyGraph<TVertex, TEdge> target)
            where TEdge : IEdge<TVertex>
        {
            IEnumerable<TEdge> result = target.Edges;
            PexStore.ValueForValidation<IEnumerable<TEdge>>("result", result);
            // TODO: add assertions to method AdjacencyGraphTVertexTEdgeTest.EdgesGet(AdjacencyGraph`2<!!0,!!1>)
        }
        
        [PexMethod]
        public void IsDirectedGet<TVertex,TEdge>([PexAssumeUnderTest]AdjacencyGraph<TVertex, TEdge> target)
            where TEdge : IEdge<TVertex>
        {
            bool result = target.IsDirected;
            PexStore.ValueForValidation<bool>("result", result);
            // TODO: add assertions to method AdjacencyGraphTVertexTEdgeTest.IsDirectedGet(AdjacencyGraph`2<!!0,!!1>)
        }
        
        [PexMethod]
        public void IsEdgesEmptyGet<TVertex,TEdge>([PexAssumeUnderTest]AdjacencyGraph<TVertex, TEdge> target)
            where TEdge : IEdge<TVertex>
        {
            bool result = target.IsEdgesEmpty;
            PexStore.ValueForValidation<bool>("result", result);
            // TODO: add assertions to method AdjacencyGraphTVertexTEdgeTest.IsEdgesEmptyGet(AdjacencyGraph`2<!!0,!!1>)
        }
        
        [PexMethod]
        public bool IsOutEdgesEmpty<TVertex,TEdge>([PexAssumeUnderTest]AdjacencyGraph<TVertex, TEdge> target, TVertex v)
            where TEdge : IEdge<TVertex>
        {
            bool result = target.IsOutEdgesEmpty(v);
            return result;
            // TODO: add assertions to method AdjacencyGraphTVertexTEdgeTest.IsOutEdgesEmpty(AdjacencyGraph`2<!!0,!!1>, !!0)
        }
        
        [PexMethod]
        public void IsVerticesEmptyGet<TVertex,TEdge>([PexAssumeUnderTest]AdjacencyGraph<TVertex, TEdge> target)
            where TEdge : IEdge<TVertex>
        {
            bool result = target.IsVerticesEmpty;
            PexStore.ValueForValidation<bool>("result", result);
            // TODO: add assertions to method AdjacencyGraphTVertexTEdgeTest.IsVerticesEmptyGet(AdjacencyGraph`2<!!0,!!1>)
        }
        
        [PexMethod]
        public int OutDegree<TVertex,TEdge>([PexAssumeUnderTest]AdjacencyGraph<TVertex, TEdge> target, TVertex v)
            where TEdge : IEdge<TVertex>
        {
            int result = target.OutDegree(v);
            return result;
            // TODO: add assertions to method AdjacencyGraphTVertexTEdgeTest.OutDegree(AdjacencyGraph`2<!!0,!!1>, !!0)
        }
        
        [PexMethod]
        public void OutEdge<TVertex,TEdge>(
            [PexAssumeUnderTest]AdjacencyGraph<TVertex, TEdge> target,
            TVertex v,
            int index
        )
            where TEdge : IEdge<TVertex>
        {
            TEdge result = target.OutEdge(v, index);
            PexStore.ValueForValidation<TEdge>("result", result);
            // TODO: add assertions to method AdjacencyGraphTVertexTEdgeTest.OutEdge(AdjacencyGraph`2<!!0,!!1>, !!0, Int32)
        }
        
        [PexMethod]
        public void OutEdges<TVertex,TEdge>([PexAssumeUnderTest]AdjacencyGraph<TVertex, TEdge> target, TVertex v)
            where TEdge : IEdge<TVertex>
        {
            IEnumerable<TEdge> result = target.OutEdges(v);
            PexStore.ValueForValidation<IEnumerable<TEdge>>("result", result);
            PexEnumerablePatterns.ForEach<TEdge>(result);
            PexEnumerablePatterns.ForEach((IEnumerable)result);
            PexEnumerablePatterns.DoubleForEach<TEdge>(result);
            PexEnumerablePatterns.MoveNextAndReset<TEdge>(result);
            // TODO: add assertions to method AdjacencyGraphTVertexTEdgeTest.OutEdges(AdjacencyGraph`2<!!0,!!1>, !!0)
        }
        
        [PexMethod]
        public bool RemoveEdge<TVertex,TEdge>([PexAssumeUnderTest]AdjacencyGraph<TVertex, TEdge> target, TEdge e)
            where TEdge : IEdge<TVertex>
        {
            bool result = target.RemoveEdge(e);
            return result;
            // TODO: add assertions to method AdjacencyGraphTVertexTEdgeTest.RemoveEdge(AdjacencyGraph`2<!!0,!!1>, !!1)
        }
        
        [PexMethod]
        public bool RemoveVertex<TVertex,TEdge>([PexAssumeUnderTest]AdjacencyGraph<TVertex, TEdge> target, TVertex v)
            where TEdge : IEdge<TVertex>
        {
            bool result = target.RemoveVertex(v);
            return result;
            // TODO: add assertions to method AdjacencyGraphTVertexTEdgeTest.RemoveVertex(AdjacencyGraph`2<!!0,!!1>, !!0)
        }
        
        [PexMethod]
        public void TrimEdgeExcess<TVertex,TEdge>([PexAssumeUnderTest]AdjacencyGraph<TVertex, TEdge> target)
            where TEdge : IEdge<TVertex>
        {
            target.TrimEdgeExcess();
            // TODO: add assertions to method AdjacencyGraphTVertexTEdgeTest.TrimEdgeExcess(AdjacencyGraph`2<!!0,!!1>)
        }
        
        [PexMethod]
        public bool TryGetEdge<TVertex,TEdge>(
            [PexAssumeUnderTest]AdjacencyGraph<TVertex, TEdge> target01,
            TVertex source,
            TVertex target,
            out TEdge edge
        )
            where TEdge : IEdge<TVertex>
        {
            bool result = target01.TryGetEdge(source, target, out edge);
            return result;
            // TODO: add assertions to method AdjacencyGraphTVertexTEdgeTest.TryGetEdge(AdjacencyGraph`2<!!0,!!1>, !!0, !!0, !!1&)
        }
        
        [PexMethod]
        public bool TryGetEdges<TVertex,TEdge>(
            [PexAssumeUnderTest]AdjacencyGraph<TVertex, TEdge> target01,
            TVertex source,
            TVertex target,
            out IEnumerable<TEdge> edges
        )
            where TEdge : IEdge<TVertex>
        {
            bool result = target01.TryGetEdges(source, target, out edges);
            return result;
            // TODO: add assertions to method AdjacencyGraphTVertexTEdgeTest.TryGetEdges(AdjacencyGraph`2<!!0,!!1>, !!0, !!0, IEnumerable`1<!!1>&)
        }
        
        [PexMethod]
        public void VertexCountGet<TVertex,TEdge>([PexAssumeUnderTest]AdjacencyGraph<TVertex, TEdge> target)
            where TEdge : IEdge<TVertex>
        {
            int result = target.VertexCount;
            PexStore.ValueForValidation<int>("result", result);
            // TODO: add assertions to method AdjacencyGraphTVertexTEdgeTest.VertexCountGet(AdjacencyGraph`2<!!0,!!1>)
        }
        
        [PexMethod]
        public void VertexTypeGet<TVertex,TEdge>()
            where TEdge : IEdge<TVertex>
        {
            Type result = AdjacencyGraph<TVertex, TEdge>.VertexType;
            PexStore.ValueForValidation<Type>("result", result);
            // TODO: add assertions to method AdjacencyGraphTVertexTEdgeTest.VertexTypeGet()
        }
        
        [PexMethod]
        public void VerticesGet<TVertex,TEdge>([PexAssumeUnderTest]AdjacencyGraph<TVertex, TEdge> target)
            where TEdge : IEdge<TVertex>
        {
            IEnumerable<TVertex> result = target.Vertices;
            PexStore.ValueForValidation<IEnumerable<TVertex>>("result", result);
            // TODO: add assertions to method AdjacencyGraphTVertexTEdgeTest.VerticesGet(AdjacencyGraph`2<!!0,!!1>)
        }
        
    }
}
