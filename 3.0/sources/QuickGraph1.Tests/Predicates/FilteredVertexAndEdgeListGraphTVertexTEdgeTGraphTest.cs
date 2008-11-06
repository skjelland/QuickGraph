using Microsoft.Pex.Framework;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using QuickGraph;
using QuickGraph.Predicates;
using System.Collections.Generic;

namespace QuickGraph.Predicates
{
    /// <summary>
    /// This class contains parameterized unit tests for FilteredVertexAndEdgeListGraph`3
    /// </summary>
    [TestClass]
    [PexClass(typeof(FilteredVertexAndEdgeListGraph<, , >))]
    public partial class FilteredVertexAndEdgeListGraphTVertexTEdgeTGraphTest
    {
        [PexMethod]
        public bool ContainsEdge<TVertex,TEdge,TGraph>(
            [PexAssumeUnderTest]FilteredVertexAndEdgeListGraph<TVertex, TEdge, TGraph> target,
            TEdge edge
        )
            where TEdge : IEdge<TVertex>
            where TGraph : IVertexAndEdgeListGraph<TVertex, TEdge>
        {
            bool result = target.ContainsEdge(edge);
            return result;
            // TODO: add assertions to method FilteredVertexAndEdgeListGraphTVertexTEdgeTGraphTest.ContainsEdge(FilteredVertexAndEdgeListGraph`3<!!0,!!1,!!2>, !!1)
        }
        
        [PexMethod]
        public void EdgeCountGet<TVertex,TEdge,TGraph>(
            [PexAssumeUnderTest]FilteredVertexAndEdgeListGraph<TVertex, TEdge, TGraph> target
        )
            where TEdge : IEdge<TVertex>
            where TGraph : IVertexAndEdgeListGraph<TVertex, TEdge>
        {
            int result = target.EdgeCount;
            PexStore.ValueForValidation<int>("result", result);
            // TODO: add assertions to method FilteredVertexAndEdgeListGraphTVertexTEdgeTGraphTest.EdgeCountGet(FilteredVertexAndEdgeListGraph`3<!!0,!!1,!!2>)
        }
        
        [PexMethod]
        public void EdgesGet<TVertex,TEdge,TGraph>(
            [PexAssumeUnderTest]FilteredVertexAndEdgeListGraph<TVertex, TEdge, TGraph> target
        )
            where TEdge : IEdge<TVertex>
            where TGraph : IVertexAndEdgeListGraph<TVertex, TEdge>
        {
            IEnumerable<TEdge> result = target.Edges;
            PexStore.ValueForValidation<IEnumerable<TEdge>>("result", result);
            // TODO: add assertions to method FilteredVertexAndEdgeListGraphTVertexTEdgeTGraphTest.EdgesGet(FilteredVertexAndEdgeListGraph`3<!!0,!!1,!!2>)
        }
        
        [PexMethod]
        public void IsEdgesEmptyGet<TVertex,TEdge,TGraph>(
            [PexAssumeUnderTest]FilteredVertexAndEdgeListGraph<TVertex, TEdge, TGraph> target
        )
            where TEdge : IEdge<TVertex>
            where TGraph : IVertexAndEdgeListGraph<TVertex, TEdge>
        {
            bool result = target.IsEdgesEmpty;
            PexStore.ValueForValidation<bool>("result", result);
            // TODO: add assertions to method FilteredVertexAndEdgeListGraphTVertexTEdgeTGraphTest.IsEdgesEmptyGet(FilteredVertexAndEdgeListGraph`3<!!0,!!1,!!2>)
        }
        
    }
}
