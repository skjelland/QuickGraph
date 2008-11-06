using Microsoft.Pex.Framework;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using QuickGraph;
using System.Collections.Generic;

namespace QuickGraph
{
    /// <summary>
    /// This class contains parameterized unit tests for EdgeListGraph`2
    /// </summary>
    [TestClass]
    [PexClass(typeof(EdgeListGraph<, >))]
    [PexGenericArguments(typeof(int), typeof(Edge<int>))]
    public partial class EdgeListGraphTVertexTEdgeTest
    {
        [PexMethod]
        public bool AddEdge<TVertex,TEdge>([PexAssumeUnderTest]EdgeListGraph<TVertex, TEdge> target, TEdge edge)
            where TEdge : IEdge<TVertex>
        {
            bool result = target.AddEdge(edge);
            return result;
            // TODO: add assertions to method EdgeListGraphTVertexTEdgeTest.AddEdge(EdgeListGraph`2<!!0,!!1>, !!1)
        }
        
        [PexMethod]
        public void AddEdgeRange<TVertex,TEdge>(
            [PexAssumeUnderTest]EdgeListGraph<TVertex, TEdge> target,
            IEnumerable<TEdge> edges
        )
            where TEdge : IEdge<TVertex>
        {
            target.AddEdgeRange(edges);
            // TODO: add assertions to method EdgeListGraphTVertexTEdgeTest.AddEdgeRange(EdgeListGraph`2<!!0,!!1>, IEnumerable`1<!!1>)
        }
        
        [PexMethod]
        public bool AddVerticesAndEdge<TVertex,TEdge>([PexAssumeUnderTest]EdgeListGraph<TVertex, TEdge> target, TEdge edge)
            where TEdge : IEdge<TVertex>
        {
            bool result = target.AddVerticesAndEdge(edge);
            return result;
            // TODO: add assertions to method EdgeListGraphTVertexTEdgeTest.AddVerticesAndEdge(EdgeListGraph`2<!!0,!!1>, !!1)
        }
        
        [PexMethod]
        public void AllowParallelEdgesGet<TVertex,TEdge>([PexAssumeUnderTest]EdgeListGraph<TVertex, TEdge> target)
            where TEdge : IEdge<TVertex>
        {
            bool result = target.AllowParallelEdges;
            PexStore.ValueForValidation<bool>("result", result);
            // TODO: add assertions to method EdgeListGraphTVertexTEdgeTest.AllowParallelEdgesGet(EdgeListGraph`2<!!0,!!1>)
        }
        
        [PexMethod]
        public void Clear<TVertex,TEdge>([PexAssumeUnderTest]EdgeListGraph<TVertex, TEdge> target)
            where TEdge : IEdge<TVertex>
        {
            target.Clear();
            // TODO: add assertions to method EdgeListGraphTVertexTEdgeTest.Clear(EdgeListGraph`2<!!0,!!1>)
        }
        
        [PexMethod]
        public void Clone<TVertex,TEdge>([PexAssumeUnderTest]EdgeListGraph<TVertex, TEdge> target)
            where TEdge : IEdge<TVertex>
        {
            EdgeListGraph<TVertex, TEdge> result = target.Clone();
            PexStore.ValueForValidation<EdgeListGraph<TVertex, TEdge>>("result", result);
            // TODO: add assertions to method EdgeListGraphTVertexTEdgeTest.Clone(EdgeListGraph`2<!!0,!!1>)
        }
        
        [PexMethod]
        public EdgeListGraph<TVertex, TEdge> Constructor<TVertex,TEdge>()
            where TEdge : IEdge<TVertex>
        {
            EdgeListGraph<TVertex, TEdge> target = new EdgeListGraph<TVertex, TEdge>();
            return target;
            // TODO: add assertions to method EdgeListGraphTVertexTEdgeTest.Constructor()
        }
        
        [PexMethod]
        public EdgeListGraph<TVertex, TEdge> Constructor01<TVertex,TEdge>(bool isDirected, bool allowParralelEdges)
            where TEdge : IEdge<TVertex>
        {
            EdgeListGraph<TVertex, TEdge> target
               = new EdgeListGraph<TVertex, TEdge>(isDirected, allowParralelEdges);
            return target;
            // TODO: add assertions to method EdgeListGraphTVertexTEdgeTest.Constructor01(Boolean, Boolean)
        }
        
        [PexMethod]
        public bool ContainsEdge<TVertex,TEdge>([PexAssumeUnderTest]EdgeListGraph<TVertex, TEdge> target, TEdge edge)
            where TEdge : IEdge<TVertex>
        {
            bool result = target.ContainsEdge(edge);
            return result;
            // TODO: add assertions to method EdgeListGraphTVertexTEdgeTest.ContainsEdge(EdgeListGraph`2<!!0,!!1>, !!1)
        }
        
        [PexMethod]
        public void EdgeCountGet<TVertex,TEdge>([PexAssumeUnderTest]EdgeListGraph<TVertex, TEdge> target)
            where TEdge : IEdge<TVertex>
        {
            int result = target.EdgeCount;
            PexStore.ValueForValidation<int>("result", result);
            // TODO: add assertions to method EdgeListGraphTVertexTEdgeTest.EdgeCountGet(EdgeListGraph`2<!!0,!!1>)
        }
        
        [PexMethod]
        public void EdgesGet<TVertex,TEdge>([PexAssumeUnderTest]EdgeListGraph<TVertex, TEdge> target)
            where TEdge : IEdge<TVertex>
        {
            IEnumerable<TEdge> result = target.Edges;
            PexStore.ValueForValidation<IEnumerable<TEdge>>("result", result);
            // TODO: add assertions to method EdgeListGraphTVertexTEdgeTest.EdgesGet(EdgeListGraph`2<!!0,!!1>)
        }
        
        [PexMethod]
        public void IsDirectedGet<TVertex,TEdge>([PexAssumeUnderTest]EdgeListGraph<TVertex, TEdge> target)
            where TEdge : IEdge<TVertex>
        {
            bool result = target.IsDirected;
            PexStore.ValueForValidation<bool>("result", result);
            // TODO: add assertions to method EdgeListGraphTVertexTEdgeTest.IsDirectedGet(EdgeListGraph`2<!!0,!!1>)
        }
        
        [PexMethod]
        public void IsEdgesEmptyGet<TVertex,TEdge>([PexAssumeUnderTest]EdgeListGraph<TVertex, TEdge> target)
            where TEdge : IEdge<TVertex>
        {
            bool result = target.IsEdgesEmpty;
            PexStore.ValueForValidation<bool>("result", result);
            // TODO: add assertions to method EdgeListGraphTVertexTEdgeTest.IsEdgesEmptyGet(EdgeListGraph`2<!!0,!!1>)
        }
        
        [PexMethod]
        public bool RemoveEdge<TVertex,TEdge>([PexAssumeUnderTest]EdgeListGraph<TVertex, TEdge> target, TEdge edge)
            where TEdge : IEdge<TVertex>
        {
            bool result = target.RemoveEdge(edge);
            return result;
            // TODO: add assertions to method EdgeListGraphTVertexTEdgeTest.RemoveEdge(EdgeListGraph`2<!!0,!!1>, !!1)
        }
        
    }
}
