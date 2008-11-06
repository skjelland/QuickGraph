using Microsoft.Pex.Framework;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using QuickGraph;
using QuickGraph.Algorithms.ShortestPath;
using System.Collections.Generic;

namespace QuickGraph.Algorithms.ShortestPath
{
    /// <summary>
    /// This class contains parameterized unit tests for BellmanFordShortestPathAlgorithm`2
    /// </summary>
    [TestClass]
    [PexClass(typeof(BellmanFordShortestPathAlgorithm<, >))]
    public partial class BellmanFordShortestPathAlgorithmTVertexTEdgeTest
    {
        [PexMethod]
        public void FoundNegativeCycleGet<TVertex,TEdge>(
            [PexAssumeUnderTest]BellmanFordShortestPathAlgorithm<TVertex, TEdge> target
        )
            where TEdge : IEdge<TVertex>
        {
            bool result = target.FoundNegativeCycle;
            PexStore.ValueForValidation<bool>("result", result);
            // TODO: add assertions to method BellmanFordShortestPathAlgorithmTVertexTEdgeTest.FoundNegativeCycleGet(BellmanFordShortestPathAlgorithm`2<!!0,!!1>)
        }
        
        [PexMethod]
        public void PredecessorsGet<TVertex,TEdge>(
            [PexAssumeUnderTest]BellmanFordShortestPathAlgorithm<TVertex, TEdge> target
        )
            where TEdge : IEdge<TVertex>
        {
            IDictionary<TVertex, TVertex> result = target.Predecessors;
            PexStore.ValueForValidation<IDictionary<TVertex, TVertex>>("result", result);
            // TODO: add assertions to method BellmanFordShortestPathAlgorithmTVertexTEdgeTest.PredecessorsGet(BellmanFordShortestPathAlgorithm`2<!!0,!!1>)
        }
        
    }
}
