using Microsoft.Pex.Framework;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using QuickGraph;
using QuickGraph.Algorithms;
using System.Collections.Generic;

namespace QuickGraph.Algorithms
{
    /// <summary>
    /// This class contains parameterized unit tests for MaximumBipartiteMatchingAlgorithm`2
    /// </summary>
    [TestClass]
    [PexClass(typeof(MaximumBipartiteMatchingAlgorithm<, >))]
    public partial class MaximumBipartiteMatchingAlgorithmTVertexTEdgeTest
    {
        [PexMethod]
        public void EdgeFactoryGet<TVertex,TEdge>(
            [PexAssumeUnderTest]MaximumBipartiteMatchingAlgorithm<TVertex, TEdge> target
        )
            where TEdge : IEdge<TVertex>
        {
            EdgeFactory<TVertex, TEdge> result = target.EdgeFactory;
            PexStore.ValueForValidation<EdgeFactory<TVertex, TEdge>>("result", result);
            // TODO: add assertions to method MaximumBipartiteMatchingAlgorithmTVertexTEdgeTest.EdgeFactoryGet(MaximumBipartiteMatchingAlgorithm`2<!!0,!!1>)
        }
        
        [PexMethod]
        public void MatchedEdgesGet<TVertex,TEdge>(
            [PexAssumeUnderTest]MaximumBipartiteMatchingAlgorithm<TVertex, TEdge> target
        )
            where TEdge : IEdge<TVertex>
        {
            ICollection<TEdge> result = target.MatchedEdges;
            PexStore.ValueForValidation<ICollection<TEdge>>("result", result);
            // TODO: add assertions to method MaximumBipartiteMatchingAlgorithmTVertexTEdgeTest.MatchedEdgesGet(MaximumBipartiteMatchingAlgorithm`2<!!0,!!1>)
        }
        
        [PexMethod]
        public void VertexFactoryGet<TVertex,TEdge>(
            [PexAssumeUnderTest]MaximumBipartiteMatchingAlgorithm<TVertex, TEdge> target
        )
            where TEdge : IEdge<TVertex>
        {
            VertexFactory<TVertex> result = target.VertexFactory;
            PexStore.ValueForValidation<VertexFactory<TVertex>>("result", result);
            // TODO: add assertions to method MaximumBipartiteMatchingAlgorithmTVertexTEdgeTest.VertexFactoryGet(MaximumBipartiteMatchingAlgorithm`2<!!0,!!1>)
        }
        
    }
}
