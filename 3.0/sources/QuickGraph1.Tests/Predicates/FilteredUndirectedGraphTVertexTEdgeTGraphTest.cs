using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Wizard;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using QuickGraph;
using QuickGraph.Predicates;
using System.Collections;
using System.Collections.Generic;

namespace QuickGraph.Predicates
{
    /// <summary>
    /// This class contains parameterized unit tests for FilteredUndirectedGraph`3
    /// </summary>
    [TestClass]
    [PexClass(typeof(FilteredUndirectedGraph<, , >))]
    public partial class FilteredUndirectedGraphTVertexTEdgeTGraphTest
    {
        [PexMethod]
        public int AdjacentDegree<TVertex,TEdge,TGraph>(
            [PexAssumeUnderTest]FilteredUndirectedGraph<TVertex, TEdge, TGraph> target,
            TVertex v
        )
            where TEdge : IEdge<TVertex>
            where TGraph : IUndirectedGraph<TVertex, TEdge>
        {
            int result = target.AdjacentDegree(v);
            return result;
            // TODO: add assertions to method FilteredUndirectedGraphTVertexTEdgeTGraphTest.AdjacentDegree(FilteredUndirectedGraph`3<!!0,!!1,!!2>, !!0)
        }
        
        [PexMethod]
        public void AdjacentEdge<TVertex,TEdge,TGraph>(
            [PexAssumeUnderTest]FilteredUndirectedGraph<TVertex, TEdge, TGraph> target,
            TVertex v,
            int index
        )
            where TEdge : IEdge<TVertex>
            where TGraph : IUndirectedGraph<TVertex, TEdge>
        {
            TEdge result = target.AdjacentEdge(v, index);
            PexStore.ValueForValidation<TEdge>("result", result);
            // TODO: add assertions to method FilteredUndirectedGraphTVertexTEdgeTGraphTest.AdjacentEdge(FilteredUndirectedGraph`3<!!0,!!1,!!2>, !!0, Int32)
        }
        
        [PexMethod]
        public void AdjacentEdges<TVertex,TEdge,TGraph>(
            [PexAssumeUnderTest]FilteredUndirectedGraph<TVertex, TEdge, TGraph> target,
            TVertex v
        )
            where TEdge : IEdge<TVertex>
            where TGraph : IUndirectedGraph<TVertex, TEdge>
        {
            IEnumerable<TEdge> result = target.AdjacentEdges(v);
            PexStore.ValueForValidation<IEnumerable<TEdge>>("result", result);
            PexEnumerablePatterns.ForEach<TEdge>(result);
            PexEnumerablePatterns.ForEach((IEnumerable)result);
            PexEnumerablePatterns.DoubleForEach<TEdge>(result);
            PexEnumerablePatterns.MoveNextAndReset<TEdge>(result);
            // TODO: add assertions to method FilteredUndirectedGraphTVertexTEdgeTGraphTest.AdjacentEdges(FilteredUndirectedGraph`3<!!0,!!1,!!2>, !!0)
        }
        
        [PexMethod]
        public bool ContainsEdge<TVertex,TEdge,TGraph>(
            [PexAssumeUnderTest]FilteredUndirectedGraph<TVertex, TEdge, TGraph> target01,
            TVertex source,
            TVertex target
        )
            where TEdge : IEdge<TVertex>
            where TGraph : IUndirectedGraph<TVertex, TEdge>
        {
            bool result = target01.ContainsEdge(source, target);
            return result;
            // TODO: add assertions to method FilteredUndirectedGraphTVertexTEdgeTGraphTest.ContainsEdge(FilteredUndirectedGraph`3<!!0,!!1,!!2>, !!0, !!0)
        }
        
        [PexMethod]
        public bool ContainsEdge01<TVertex,TEdge,TGraph>(
            [PexAssumeUnderTest]FilteredUndirectedGraph<TVertex, TEdge, TGraph> target,
            TEdge edge
        )
            where TEdge : IEdge<TVertex>
            where TGraph : IUndirectedGraph<TVertex, TEdge>
        {
            bool result = target.ContainsEdge(edge);
            return result;
            // TODO: add assertions to method FilteredUndirectedGraphTVertexTEdgeTGraphTest.ContainsEdge01(FilteredUndirectedGraph`3<!!0,!!1,!!2>, !!1)
        }
        
        [PexMethod]
        public bool ContainsVertex<TVertex,TEdge,TGraph>(
            [PexAssumeUnderTest]FilteredUndirectedGraph<TVertex, TEdge, TGraph> target,
            TVertex vertex
        )
            where TEdge : IEdge<TVertex>
            where TGraph : IUndirectedGraph<TVertex, TEdge>
        {
            bool result = target.ContainsVertex(vertex);
            return result;
            // TODO: add assertions to method FilteredUndirectedGraphTVertexTEdgeTGraphTest.ContainsVertex(FilteredUndirectedGraph`3<!!0,!!1,!!2>, !!0)
        }
        
        [PexMethod]
        public void EdgeCountGet<TVertex,TEdge,TGraph>(
            [PexAssumeUnderTest]FilteredUndirectedGraph<TVertex, TEdge, TGraph> target
        )
            where TEdge : IEdge<TVertex>
            where TGraph : IUndirectedGraph<TVertex, TEdge>
        {
            int result = target.EdgeCount;
            PexStore.ValueForValidation<int>("result", result);
            // TODO: add assertions to method FilteredUndirectedGraphTVertexTEdgeTGraphTest.EdgeCountGet(FilteredUndirectedGraph`3<!!0,!!1,!!2>)
        }
        
        [PexMethod]
        public void EdgesGet<TVertex,TEdge,TGraph>(
            [PexAssumeUnderTest]FilteredUndirectedGraph<TVertex, TEdge, TGraph> target
        )
            where TEdge : IEdge<TVertex>
            where TGraph : IUndirectedGraph<TVertex, TEdge>
        {
            IEnumerable<TEdge> result = target.Edges;
            PexStore.ValueForValidation<IEnumerable<TEdge>>("result", result);
            // TODO: add assertions to method FilteredUndirectedGraphTVertexTEdgeTGraphTest.EdgesGet(FilteredUndirectedGraph`3<!!0,!!1,!!2>)
        }
        
        [PexMethod]
        public bool IsAdjacentEdgesEmpty<TVertex,TEdge,TGraph>(
            [PexAssumeUnderTest]FilteredUndirectedGraph<TVertex, TEdge, TGraph> target,
            TVertex v
        )
            where TEdge : IEdge<TVertex>
            where TGraph : IUndirectedGraph<TVertex, TEdge>
        {
            bool result = target.IsAdjacentEdgesEmpty(v);
            return result;
            // TODO: add assertions to method FilteredUndirectedGraphTVertexTEdgeTGraphTest.IsAdjacentEdgesEmpty(FilteredUndirectedGraph`3<!!0,!!1,!!2>, !!0)
        }
        
        [PexMethod]
        public void IsEdgesEmptyGet<TVertex,TEdge,TGraph>(
            [PexAssumeUnderTest]FilteredUndirectedGraph<TVertex, TEdge, TGraph> target
        )
            where TEdge : IEdge<TVertex>
            where TGraph : IUndirectedGraph<TVertex, TEdge>
        {
            bool result = target.IsEdgesEmpty;
            PexStore.ValueForValidation<bool>("result", result);
            // TODO: add assertions to method FilteredUndirectedGraphTVertexTEdgeTGraphTest.IsEdgesEmptyGet(FilteredUndirectedGraph`3<!!0,!!1,!!2>)
        }
        
        [PexMethod]
        public void IsVerticesEmptyGet<TVertex,TEdge,TGraph>(
            [PexAssumeUnderTest]FilteredUndirectedGraph<TVertex, TEdge, TGraph> target
        )
            where TEdge : IEdge<TVertex>
            where TGraph : IUndirectedGraph<TVertex, TEdge>
        {
            bool result = target.IsVerticesEmpty;
            PexStore.ValueForValidation<bool>("result", result);
            // TODO: add assertions to method FilteredUndirectedGraphTVertexTEdgeTGraphTest.IsVerticesEmptyGet(FilteredUndirectedGraph`3<!!0,!!1,!!2>)
        }
        
        [PexMethod]
        public void VertexCountGet<TVertex,TEdge,TGraph>(
            [PexAssumeUnderTest]FilteredUndirectedGraph<TVertex, TEdge, TGraph> target
        )
            where TEdge : IEdge<TVertex>
            where TGraph : IUndirectedGraph<TVertex, TEdge>
        {
            int result = target.VertexCount;
            PexStore.ValueForValidation<int>("result", result);
            // TODO: add assertions to method FilteredUndirectedGraphTVertexTEdgeTGraphTest.VertexCountGet(FilteredUndirectedGraph`3<!!0,!!1,!!2>)
        }
        
        [PexMethod]
        public void VerticesGet<TVertex,TEdge,TGraph>(
            [PexAssumeUnderTest]FilteredUndirectedGraph<TVertex, TEdge, TGraph> target
        )
            where TEdge : IEdge<TVertex>
            where TGraph : IUndirectedGraph<TVertex, TEdge>
        {
            IEnumerable<TVertex> result = target.Vertices;
            PexStore.ValueForValidation<IEnumerable<TVertex>>("result", result);
            // TODO: add assertions to method FilteredUndirectedGraphTVertexTEdgeTGraphTest.VerticesGet(FilteredUndirectedGraph`3<!!0,!!1,!!2>)
        }
        
    }
}
