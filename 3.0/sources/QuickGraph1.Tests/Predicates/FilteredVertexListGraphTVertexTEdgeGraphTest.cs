using Microsoft.Pex.Framework;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using QuickGraph;
using QuickGraph.Predicates;
using System.Collections.Generic;

namespace QuickGraph.Predicates
{
    /// <summary>
    /// This class contains parameterized unit tests for FilteredVertexListGraph`3
    /// </summary>
    [TestClass]
    [PexClass(typeof(FilteredVertexListGraph<, , >))]
    public partial class FilteredVertexListGraphTVertexTEdgeGraphTest
    {
        [PexMethod]
        public bool ContainsVertex<TVertex,TEdge,Graph>(
            [PexAssumeUnderTest]FilteredVertexListGraph<TVertex, TEdge, Graph> target,
            TVertex vertex
        )
            where TEdge : IEdge<TVertex>
            where Graph : IVertexListGraph<TVertex, TEdge>
        {
            bool result = target.ContainsVertex(vertex);
            return result;
            // TODO: add assertions to method FilteredVertexListGraphTVertexTEdgeGraphTest.ContainsVertex(FilteredVertexListGraph`3<!!0,!!1,!!2>, !!0)
        }
        
        [PexMethod]
        public void IsVerticesEmptyGet<TVertex,TEdge,Graph>(
            [PexAssumeUnderTest]FilteredVertexListGraph<TVertex, TEdge, Graph> target
        )
            where TEdge : IEdge<TVertex>
            where Graph : IVertexListGraph<TVertex, TEdge>
        {
            bool result = target.IsVerticesEmpty;
            PexStore.ValueForValidation<bool>("result", result);
            // TODO: add assertions to method FilteredVertexListGraphTVertexTEdgeGraphTest.IsVerticesEmptyGet(FilteredVertexListGraph`3<!!0,!!1,!!2>)
        }
        
        [PexMethod]
        public void VertexCountGet<TVertex,TEdge,Graph>(
            [PexAssumeUnderTest]FilteredVertexListGraph<TVertex, TEdge, Graph> target
        )
            where TEdge : IEdge<TVertex>
            where Graph : IVertexListGraph<TVertex, TEdge>
        {
            int result = target.VertexCount;
            PexStore.ValueForValidation<int>("result", result);
            // TODO: add assertions to method FilteredVertexListGraphTVertexTEdgeGraphTest.VertexCountGet(FilteredVertexListGraph`3<!!0,!!1,!!2>)
        }
        
        [PexMethod]
        public void VerticesGet<TVertex,TEdge,Graph>(
            [PexAssumeUnderTest]FilteredVertexListGraph<TVertex, TEdge, Graph> target
        )
            where TEdge : IEdge<TVertex>
            where Graph : IVertexListGraph<TVertex, TEdge>
        {
            IEnumerable<TVertex> result = target.Vertices;
            PexStore.ValueForValidation<IEnumerable<TVertex>>("result", result);
            // TODO: add assertions to method FilteredVertexListGraphTVertexTEdgeGraphTest.VerticesGet(FilteredVertexListGraph`3<!!0,!!1,!!2>)
        }
        
    }
}
