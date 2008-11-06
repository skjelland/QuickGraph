using Microsoft.Pex.Framework;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using QuickGraph;
using QuickGraph.Algorithms.MinimumSpanningTree;
using QuickGraph.Algorithms.Services;
using System.Collections.Generic;

namespace QuickGraph.Algorithms.MinimumSpanningTree
{
    /// <summary>
    /// This class contains parameterized unit tests for PrimMinimumSpanningTreeAlgorithm`2
    /// </summary>
    [TestClass]
    [PexClass(typeof(PrimMinimumSpanningTreeAlgorithm<, >))]
    public partial class PrimMinimumSpanningTreeAlgorithmTVertexTEdgeTest
    {
        [PexMethod]
        public PrimMinimumSpanningTreeAlgorithm<TVertex, TEdge> Constructor<TVertex,TEdge>(
            IUndirectedGraph<TVertex, TEdge> visitedGraph,
            IDictionary<TEdge, double> edgeWeights
        )
            where TEdge : IEdge<TVertex>
        {
            PrimMinimumSpanningTreeAlgorithm<TVertex, TEdge> target
               = new PrimMinimumSpanningTreeAlgorithm<TVertex, TEdge>
                  (visitedGraph, edgeWeights);
            return target;
            // TODO: add assertions to method PrimMinimumSpanningTreeAlgorithmTVertexTEdgeTest.Constructor(IUndirectedGraph`2<!!0,!!1>, IDictionary`2<!!1,Double>)
        }
        
        [PexMethod]
        public PrimMinimumSpanningTreeAlgorithm<TVertex, TEdge> Constructor01<TVertex,TEdge>(
            IAlgorithmComponent host,
            IUndirectedGraph<TVertex, TEdge> visitedGraph,
            IDictionary<TEdge, double> edgeWeights
        )
            where TEdge : IEdge<TVertex>
        {
            PrimMinimumSpanningTreeAlgorithm<TVertex, TEdge> target
               = new PrimMinimumSpanningTreeAlgorithm<TVertex, TEdge>
                  (host, visitedGraph, edgeWeights);
            return target;
            // TODO: add assertions to method PrimMinimumSpanningTreeAlgorithmTVertexTEdgeTest.Constructor01(IAlgorithmComponent, IUndirectedGraph`2<!!0,!!1>, IDictionary`2<!!1,Double>)
        }
        
        [PexMethod]
        public void EdgeWeightsGet<TVertex,TEdge>(
            [PexAssumeUnderTest]PrimMinimumSpanningTreeAlgorithm<TVertex, TEdge> target
        )
            where TEdge : IEdge<TVertex>
        {
            IDictionary<TEdge, double> result = target.EdgeWeights;
            PexStore.ValueForValidation<IDictionary<TEdge, double>>("result", result);
            // TODO: add assertions to method PrimMinimumSpanningTreeAlgorithmTVertexTEdgeTest.EdgeWeightsGet(PrimMinimumSpanningTreeAlgorithm`2<!!0,!!1>)
        }
        
    }
}
