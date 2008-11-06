using Microsoft.Pex.Framework;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using QuickGraph;
using QuickGraph.Algorithms.Condensation;

namespace QuickGraph.Algorithms.Condensation
{
    /// <summary>
    /// This class contains parameterized unit tests for EdgeMergeCondensationGraphAlgorithm`2
    /// </summary>
    [TestClass]
    [PexClass(typeof(EdgeMergeCondensationGraphAlgorithm<, >))]
    public partial class EdgeMergeCondensationGraphAlgorithmTVertexTEdgeTest
    {
        [PexMethod]
        public void CondensatedGraphGet<TVertex,TEdge>(
            [PexAssumeUnderTest]EdgeMergeCondensationGraphAlgorithm<TVertex, TEdge> target
        )
            where TEdge : IEdge<TVertex>
        {
            IMutableBidirectionalGraph<TVertex, MergedEdge<TVertex, TEdge>> result
               = target.CondensatedGraph;
            PexStore.ValueForValidation
                <IMutableBidirectionalGraph<TVertex, MergedEdge<TVertex, TEdge>>>
                ("result", result);
            // TODO: add assertions to method EdgeMergeCondensationGraphAlgorithmTVertexTEdgeTest.CondensatedGraphGet(EdgeMergeCondensationGraphAlgorithm`2<!!0,!!1>)
        }
        
        [PexMethod]
        public void VertexPredicateGet<TVertex,TEdge>(
            [PexAssumeUnderTest]EdgeMergeCondensationGraphAlgorithm<TVertex, TEdge> target
        )
            where TEdge : IEdge<TVertex>
        {
            VertexPredicate<TVertex> result = target.VertexPredicate;
            PexStore.ValueForValidation<VertexPredicate<TVertex>>("result", result);
            // TODO: add assertions to method EdgeMergeCondensationGraphAlgorithmTVertexTEdgeTest.VertexPredicateGet(EdgeMergeCondensationGraphAlgorithm`2<!!0,!!1>)
        }
        
    }
}
