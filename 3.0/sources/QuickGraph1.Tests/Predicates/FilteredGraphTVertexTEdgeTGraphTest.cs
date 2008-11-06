using Microsoft.Pex.Framework;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using QuickGraph;
using QuickGraph.Predicates;

namespace QuickGraph.Predicates
{
    /// <summary>
    /// This class contains parameterized unit tests for FilteredGraph`3
    /// </summary>
    [TestClass]
    [PexClass(typeof(FilteredGraph<, , >))]
    public partial class FilteredGraphTVertexTEdgeTGraphTest
    {
        [PexMethod]
        public void AllowParallelEdgesGet<TVertex,TEdge,TGraph>([PexAssumeUnderTest]FilteredGraph<TVertex, TEdge, TGraph> target)
            where TEdge : IEdge<TVertex>
            where TGraph : IGraph<TVertex, TEdge>
        {
            bool result = target.AllowParallelEdges;
            PexStore.ValueForValidation<bool>("result", result);
            // TODO: add assertions to method FilteredGraphTVertexTEdgeTGraphTest.AllowParallelEdgesGet(FilteredGraph`3<!!0,!!1,!!2>)
        }
        
        [PexMethod]
        public void BaseGraphGet<TVertex,TEdge,TGraph>([PexAssumeUnderTest]FilteredGraph<TVertex, TEdge, TGraph> target)
            where TEdge : IEdge<TVertex>
            where TGraph : IGraph<TVertex, TEdge>
        {
            TGraph result = target.BaseGraph;
            PexStore.ValueForValidation<TGraph>("result", result);
            // TODO: add assertions to method FilteredGraphTVertexTEdgeTGraphTest.BaseGraphGet(FilteredGraph`3<!!0,!!1,!!2>)
        }
        
        [PexMethod]
        public void EdgePredicateGet<TVertex,TEdge,TGraph>([PexAssumeUnderTest]FilteredGraph<TVertex, TEdge, TGraph> target)
            where TEdge : IEdge<TVertex>
            where TGraph : IGraph<TVertex, TEdge>
        {
            EdgePredicate<TVertex, TEdge> result = target.EdgePredicate;
            PexStore.ValueForValidation<EdgePredicate<TVertex, TEdge>>("result", result);
            // TODO: add assertions to method FilteredGraphTVertexTEdgeTGraphTest.EdgePredicateGet(FilteredGraph`3<!!0,!!1,!!2>)
        }
        
        [PexMethod]
        public void IsDirectedGet<TVertex,TEdge,TGraph>([PexAssumeUnderTest]FilteredGraph<TVertex, TEdge, TGraph> target)
            where TEdge : IEdge<TVertex>
            where TGraph : IGraph<TVertex, TEdge>
        {
            bool result = target.IsDirected;
            PexStore.ValueForValidation<bool>("result", result);
            // TODO: add assertions to method FilteredGraphTVertexTEdgeTGraphTest.IsDirectedGet(FilteredGraph`3<!!0,!!1,!!2>)
        }
        
        [PexMethod]
        public void VertexPredicateGet<TVertex,TEdge,TGraph>([PexAssumeUnderTest]FilteredGraph<TVertex, TEdge, TGraph> target)
            where TEdge : IEdge<TVertex>
            where TGraph : IGraph<TVertex, TEdge>
        {
            VertexPredicate<TVertex> result = target.VertexPredicate;
            PexStore.ValueForValidation<VertexPredicate<TVertex>>("result", result);
            // TODO: add assertions to method FilteredGraphTVertexTEdgeTGraphTest.VertexPredicateGet(FilteredGraph`3<!!0,!!1,!!2>)
        }
        
    }
}
