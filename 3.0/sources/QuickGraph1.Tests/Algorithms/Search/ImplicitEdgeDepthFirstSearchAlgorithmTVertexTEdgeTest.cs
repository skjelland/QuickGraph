using Microsoft.Pex.Framework;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using QuickGraph;
using QuickGraph.Algorithms.Search;
using QuickGraph.Algorithms.Services;
using System.Collections.Generic;

namespace QuickGraph.Algorithms.Search
{
    /// <summary>
    /// This class contains parameterized unit tests for ImplicitEdgeDepthFirstSearchAlgorithm`2
    /// </summary>
    [TestClass]
    [PexClass(typeof(ImplicitEdgeDepthFirstSearchAlgorithm<, >))]
    public partial class ImplicitEdgeDepthFirstSearchAlgorithmTVertexTEdgeTest
    {
        [PexMethod]
        public ImplicitEdgeDepthFirstSearchAlgorithm<TVertex, TEdge> Constructor<TVertex,TEdge>(IIncidenceGraph<TVertex, TEdge> visitedGraph)
            where TEdge : IEdge<TVertex>
        {
            ImplicitEdgeDepthFirstSearchAlgorithm<TVertex, TEdge> target
               = new ImplicitEdgeDepthFirstSearchAlgorithm<TVertex, TEdge>(visitedGraph);
            return target;
            // TODO: add assertions to method ImplicitEdgeDepthFirstSearchAlgorithmTVertexTEdgeTest.Constructor(IIncidenceGraph`2<!!0,!!1>)
        }
        
        [PexMethod]
        public ImplicitEdgeDepthFirstSearchAlgorithm<TVertex, TEdge> Constructor01<TVertex,TEdge>(IAlgorithmComponent host, IIncidenceGraph<TVertex, TEdge> visitedGraph)
            where TEdge : IEdge<TVertex>
        {
            ImplicitEdgeDepthFirstSearchAlgorithm<TVertex, TEdge> target
               = new ImplicitEdgeDepthFirstSearchAlgorithm<TVertex, TEdge>
                  (host, visitedGraph);
            return target;
            // TODO: add assertions to method ImplicitEdgeDepthFirstSearchAlgorithmTVertexTEdgeTest.Constructor01(IAlgorithmComponent, IIncidenceGraph`2<!!0,!!1>)
        }
        
        [PexMethod]
        public void EdgeColorsGet<TVertex,TEdge>(
            [PexAssumeUnderTest]ImplicitEdgeDepthFirstSearchAlgorithm<TVertex, TEdge> target
        )
            where TEdge : IEdge<TVertex>
        {
            IDictionary<TEdge, GraphColor> result = target.EdgeColors;
            PexStore.ValueForValidation<IDictionary<TEdge, GraphColor>>("result", result);
            // TODO: add assertions to method ImplicitEdgeDepthFirstSearchAlgorithmTVertexTEdgeTest.EdgeColorsGet(ImplicitEdgeDepthFirstSearchAlgorithm`2<!!0,!!1>)
        }
        
        [PexMethod]
        public void MaxDepthGetSet<TVertex,TEdge>(
            [PexAssumeUnderTest]ImplicitEdgeDepthFirstSearchAlgorithm<TVertex, TEdge> target,
            int value
        )
            where TEdge : IEdge<TVertex>
        {
            target.MaxDepth = value;
            int result = target.MaxDepth;
            PexStore.ValueForValidation<int>("result", result);
            PexAssert.AreEqual((object)value, (object)result);
            // TODO: add assertions to method ImplicitEdgeDepthFirstSearchAlgorithmTVertexTEdgeTest.MaxDepthGetSet(ImplicitEdgeDepthFirstSearchAlgorithm`2<!!0,!!1>, Int32)
        }
        
    }
}
