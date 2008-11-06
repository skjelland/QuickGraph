using Microsoft.Pex.Framework;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using QuickGraph;
using QuickGraph.Algorithms.Search;
using QuickGraph.Algorithms.Services;
using System.Collections.Generic;

namespace QuickGraph.Algorithms.Search
{
    /// <summary>
    /// This class contains parameterized unit tests for EdgeDepthFirstSearchAlgorithm`2
    /// </summary>
    [TestClass]
    [PexClass(typeof(EdgeDepthFirstSearchAlgorithm<, >))]
    public partial class EdgeDepthFirstSearchAlgorithmTVertexTEdgeTest
    {
        [PexMethod]
        public EdgeDepthFirstSearchAlgorithm<TVertex, TEdge> Constructor<TVertex,TEdge>(IEdgeListAndIncidenceGraph<TVertex, TEdge> g)
            where TEdge : IEdge<TVertex>
        {
            EdgeDepthFirstSearchAlgorithm<TVertex, TEdge> target
               = new EdgeDepthFirstSearchAlgorithm<TVertex, TEdge>(g);
            return target;
            // TODO: add assertions to method EdgeDepthFirstSearchAlgorithmTVertexTEdgeTest.Constructor(IEdgeListAndIncidenceGraph`2<!!0,!!1>)
        }
        
        [PexMethod]
        public EdgeDepthFirstSearchAlgorithm<TVertex, TEdge> Constructor01<TVertex,TEdge>(
            IEdgeListAndIncidenceGraph<TVertex, TEdge> visitedGraph,
            IDictionary<TEdge, GraphColor> colors
        )
            where TEdge : IEdge<TVertex>
        {
            EdgeDepthFirstSearchAlgorithm<TVertex, TEdge> target
               = new EdgeDepthFirstSearchAlgorithm<TVertex, TEdge>(visitedGraph, colors);
            return target;
            // TODO: add assertions to method EdgeDepthFirstSearchAlgorithmTVertexTEdgeTest.Constructor01(IEdgeListAndIncidenceGraph`2<!!0,!!1>, IDictionary`2<!!1,GraphColor>)
        }
        
        [PexMethod]
        public EdgeDepthFirstSearchAlgorithm<TVertex, TEdge> Constructor02<TVertex,TEdge>(
            IAlgorithmComponent host,
            IEdgeListAndIncidenceGraph<TVertex, TEdge> visitedGraph,
            IDictionary<TEdge, GraphColor> colors
        )
            where TEdge : IEdge<TVertex>
        {
            EdgeDepthFirstSearchAlgorithm<TVertex, TEdge> target
               = new EdgeDepthFirstSearchAlgorithm<TVertex, TEdge>
                  (host, visitedGraph, colors);
            return target;
            // TODO: add assertions to method EdgeDepthFirstSearchAlgorithmTVertexTEdgeTest.Constructor02(IAlgorithmComponent, IEdgeListAndIncidenceGraph`2<!!0,!!1>, IDictionary`2<!!1,GraphColor>)
        }
        
        [PexMethod]
        public void EdgeColorsGet<TVertex,TEdge>(
            [PexAssumeUnderTest]EdgeDepthFirstSearchAlgorithm<TVertex, TEdge> target
        )
            where TEdge : IEdge<TVertex>
        {
            IDictionary<TEdge, GraphColor> result = target.EdgeColors;
            PexStore.ValueForValidation<IDictionary<TEdge, GraphColor>>("result", result);
            // TODO: add assertions to method EdgeDepthFirstSearchAlgorithmTVertexTEdgeTest.EdgeColorsGet(EdgeDepthFirstSearchAlgorithm`2<!!0,!!1>)
        }
        
        [PexMethod]
        public void Initialize<TVertex,TEdge>(
            [PexAssumeUnderTest]EdgeDepthFirstSearchAlgorithm<TVertex, TEdge> target
        )
            where TEdge : IEdge<TVertex>
        {
            target.Initialize();
            // TODO: add assertions to method EdgeDepthFirstSearchAlgorithmTVertexTEdgeTest.Initialize(EdgeDepthFirstSearchAlgorithm`2<!!0,!!1>)
        }
        
        [PexMethod]
        public void MaxDepthGetSet<TVertex,TEdge>(
            [PexAssumeUnderTest]EdgeDepthFirstSearchAlgorithm<TVertex, TEdge> target,
            int value
        )
            where TEdge : IEdge<TVertex>
        {
            target.MaxDepth = value;
            int result = target.MaxDepth;
            PexStore.ValueForValidation<int>("result", result);
            PexAssert.AreEqual((object)value, (object)result);
            // TODO: add assertions to method EdgeDepthFirstSearchAlgorithmTVertexTEdgeTest.MaxDepthGetSet(EdgeDepthFirstSearchAlgorithm`2<!!0,!!1>, Int32)
        }
        
        [PexMethod]
        public void Visit<TVertex,TEdge>(
            [PexAssumeUnderTest]EdgeDepthFirstSearchAlgorithm<TVertex, TEdge> target,
            TEdge se,
            int depth
        )
            where TEdge : IEdge<TVertex>
        {
            target.Visit(se, depth);
            // TODO: add assertions to method EdgeDepthFirstSearchAlgorithmTVertexTEdgeTest.Visit(EdgeDepthFirstSearchAlgorithm`2<!!0,!!1>, !!1, Int32)
        }
        
    }
}
