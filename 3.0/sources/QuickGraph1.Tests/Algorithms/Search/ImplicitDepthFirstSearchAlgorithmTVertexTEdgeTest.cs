using Microsoft.Pex.Framework;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using QuickGraph;
using QuickGraph.Algorithms.Search;
using QuickGraph.Algorithms.Services;
using System.Collections.Generic;

namespace QuickGraph.Algorithms.Search
{
    /// <summary>
    /// This class contains parameterized unit tests for ImplicitDepthFirstSearchAlgorithm`2
    /// </summary>
    [TestClass]
    [PexClass(typeof(ImplicitDepthFirstSearchAlgorithm<, >))]
    public partial class ImplicitDepthFirstSearchAlgorithmTVertexTEdgeTest
    {
        [PexMethod]
        public ImplicitDepthFirstSearchAlgorithm<TVertex, TEdge> Constructor<TVertex,TEdge>(IIncidenceGraph<TVertex, TEdge> visitedGraph)
            where TEdge : IEdge<TVertex>
        {
            ImplicitDepthFirstSearchAlgorithm<TVertex, TEdge> target
               = new ImplicitDepthFirstSearchAlgorithm<TVertex, TEdge>(visitedGraph);
            return target;
            // TODO: add assertions to method ImplicitDepthFirstSearchAlgorithmTVertexTEdgeTest.Constructor(IIncidenceGraph`2<!!0,!!1>)
        }
        
        [PexMethod]
        public ImplicitDepthFirstSearchAlgorithm<TVertex, TEdge> Constructor01<TVertex,TEdge>(IAlgorithmComponent host, IIncidenceGraph<TVertex, TEdge> visitedGraph)
            where TEdge : IEdge<TVertex>
        {
            ImplicitDepthFirstSearchAlgorithm<TVertex, TEdge> target
               = new ImplicitDepthFirstSearchAlgorithm<TVertex, TEdge>(host, visitedGraph);
            return target;
            // TODO: add assertions to method ImplicitDepthFirstSearchAlgorithmTVertexTEdgeTest.Constructor01(IAlgorithmComponent, IIncidenceGraph`2<!!0,!!1>)
        }
        
        [PexMethod]
        public void MaxDepthGetSet<TVertex,TEdge>(
            [PexAssumeUnderTest]ImplicitDepthFirstSearchAlgorithm<TVertex, TEdge> target,
            int value
        )
            where TEdge : IEdge<TVertex>
        {
            target.MaxDepth = value;
            int result = target.MaxDepth;
            PexStore.ValueForValidation<int>("result", result);
            PexAssert.AreEqual((object)value, (object)result);
            // TODO: add assertions to method ImplicitDepthFirstSearchAlgorithmTVertexTEdgeTest.MaxDepthGetSet(ImplicitDepthFirstSearchAlgorithm`2<!!0,!!1>, Int32)
        }
        
        [PexMethod]
        public void VertexColorsGet<TVertex,TEdge>(
            [PexAssumeUnderTest]ImplicitDepthFirstSearchAlgorithm<TVertex, TEdge> target
        )
            where TEdge : IEdge<TVertex>
        {
            IDictionary<TVertex, GraphColor> result = target.VertexColors;
            PexStore.ValueForValidation<IDictionary<TVertex, GraphColor>>("result", result);
            // TODO: add assertions to method ImplicitDepthFirstSearchAlgorithmTVertexTEdgeTest.VertexColorsGet(ImplicitDepthFirstSearchAlgorithm`2<!!0,!!1>)
        }
        
    }
}
