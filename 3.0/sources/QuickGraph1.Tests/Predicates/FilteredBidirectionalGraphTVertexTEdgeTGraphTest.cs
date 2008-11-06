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
    /// This class contains parameterized unit tests for FilteredBidirectionalGraph`3
    /// </summary>
    [TestClass]
    [PexClass(typeof(FilteredBidirectionalGraph<, , >))]
    public partial class FilteredBidirectionalGraphTVertexTEdgeTGraphTest
    {
        [PexMethod]
        public bool ContainsEdge<TVertex,TEdge,TGraph>(
            [PexAssumeUnderTest]FilteredBidirectionalGraph<TVertex, TEdge, TGraph> target,
            TEdge edge
        )
            where TEdge : IEdge<TVertex>
            where TGraph : IVertexAndEdgeListGraph<TVertex, TEdge>
        {
            bool result = target.ContainsEdge(edge);
            return result;
            // TODO: add assertions to method FilteredBidirectionalGraphTVertexTEdgeTGraphTest.ContainsEdge(FilteredBidirectionalGraph`3<!!0,!!1,!!2>, !!1)
        }
        
        [PexMethod]
        public int Degree<TVertex,TEdge,TGraph>(
            [PexAssumeUnderTest]FilteredBidirectionalGraph<TVertex, TEdge, TGraph> target,
            TVertex v
        )
            where TEdge : IEdge<TVertex>
            where TGraph : IVertexAndEdgeListGraph<TVertex, TEdge>
        {
            int result = target.Degree(v);
            return result;
            // TODO: add assertions to method FilteredBidirectionalGraphTVertexTEdgeTGraphTest.Degree(FilteredBidirectionalGraph`3<!!0,!!1,!!2>, !!0)
        }
        
        [PexMethod]
        public void EdgeCountGet<TVertex,TEdge,TGraph>(
            [PexAssumeUnderTest]FilteredBidirectionalGraph<TVertex, TEdge, TGraph> target
        )
            where TEdge : IEdge<TVertex>
            where TGraph : IVertexAndEdgeListGraph<TVertex, TEdge>
        {
            int result = target.EdgeCount;
            PexStore.ValueForValidation<int>("result", result);
            // TODO: add assertions to method FilteredBidirectionalGraphTVertexTEdgeTGraphTest.EdgeCountGet(FilteredBidirectionalGraph`3<!!0,!!1,!!2>)
        }
        
        [PexMethod]
        public void EdgesGet<TVertex,TEdge,TGraph>(
            [PexAssumeUnderTest]FilteredBidirectionalGraph<TVertex, TEdge, TGraph> target
        )
            where TEdge : IEdge<TVertex>
            where TGraph : IVertexAndEdgeListGraph<TVertex, TEdge>
        {
            IEnumerable<TEdge> result = target.Edges;
            PexStore.ValueForValidation<IEnumerable<TEdge>>("result", result);
            // TODO: add assertions to method FilteredBidirectionalGraphTVertexTEdgeTGraphTest.EdgesGet(FilteredBidirectionalGraph`3<!!0,!!1,!!2>)
        }
        
        [PexMethod]
        public int InDegree<TVertex,TEdge,TGraph>(
            [PexAssumeUnderTest]FilteredBidirectionalGraph<TVertex, TEdge, TGraph> target,
            TVertex v
        )
            where TEdge : IEdge<TVertex>
            where TGraph : IVertexAndEdgeListGraph<TVertex, TEdge>
        {
            int result = target.InDegree(v);
            return result;
            // TODO: add assertions to method FilteredBidirectionalGraphTVertexTEdgeTGraphTest.InDegree(FilteredBidirectionalGraph`3<!!0,!!1,!!2>, !!0)
        }
        
        [PexMethod]
        public void InEdge<TVertex,TEdge,TGraph>(
            [PexAssumeUnderTest]FilteredBidirectionalGraph<TVertex, TEdge, TGraph> target,
            TVertex v,
            int index
        )
            where TEdge : IEdge<TVertex>
            where TGraph : IVertexAndEdgeListGraph<TVertex, TEdge>
        {
            TEdge result = target.InEdge(v, index);
            PexStore.ValueForValidation<TEdge>("result", result);
            // TODO: add assertions to method FilteredBidirectionalGraphTVertexTEdgeTGraphTest.InEdge(FilteredBidirectionalGraph`3<!!0,!!1,!!2>, !!0, Int32)
        }
        
        [PexMethod]
        public void InEdges<TVertex,TEdge,TGraph>(
            [PexAssumeUnderTest]FilteredBidirectionalGraph<TVertex, TEdge, TGraph> target,
            TVertex v
        )
            where TEdge : IEdge<TVertex>
            where TGraph : IVertexAndEdgeListGraph<TVertex, TEdge>
        {
            IEnumerable<TEdge> result = target.InEdges(v);
            PexStore.ValueForValidation<IEnumerable<TEdge>>("result", result);
            PexEnumerablePatterns.ForEach<TEdge>(result);
            PexEnumerablePatterns.ForEach((IEnumerable)result);
            PexEnumerablePatterns.DoubleForEach<TEdge>(result);
            PexEnumerablePatterns.MoveNextAndReset<TEdge>(result);
            // TODO: add assertions to method FilteredBidirectionalGraphTVertexTEdgeTGraphTest.InEdges(FilteredBidirectionalGraph`3<!!0,!!1,!!2>, !!0)
        }
        
        [PexMethod]
        public void IsEdgesEmptyGet<TVertex,TEdge,TGraph>(
            [PexAssumeUnderTest]FilteredBidirectionalGraph<TVertex, TEdge, TGraph> target
        )
            where TEdge : IEdge<TVertex>
            where TGraph : IVertexAndEdgeListGraph<TVertex, TEdge>
        {
            bool result = target.IsEdgesEmpty;
            PexStore.ValueForValidation<bool>("result", result);
            // TODO: add assertions to method FilteredBidirectionalGraphTVertexTEdgeTGraphTest.IsEdgesEmptyGet(FilteredBidirectionalGraph`3<!!0,!!1,!!2>)
        }
        
        [PexMethod]
        public bool IsInEdgesEmpty<TVertex,TEdge,TGraph>(
            [PexAssumeUnderTest]FilteredBidirectionalGraph<TVertex, TEdge, TGraph> target,
            TVertex v
        )
            where TEdge : IEdge<TVertex>
            where TGraph : IVertexAndEdgeListGraph<TVertex, TEdge>
        {
            bool result = target.IsInEdgesEmpty(v);
            return result;
            // TODO: add assertions to method FilteredBidirectionalGraphTVertexTEdgeTGraphTest.IsInEdgesEmpty(FilteredBidirectionalGraph`3<!!0,!!1,!!2>, !!0)
        }
        
    }
}
