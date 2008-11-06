using Microsoft.Pex.Framework;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using QuickGraph;
using QuickGraph.Algorithms;
using QuickGraph.Algorithms.Services;
using System.Collections.Generic;

namespace QuickGraph.Algorithms
{
    /// <summary>
    /// This class contains parameterized unit tests for WeaklyConnectedComponentsAlgorithm`2
    /// </summary>
    [TestClass]
    [PexClass(typeof(WeaklyConnectedComponentsAlgorithm<, >))]
    public partial class WeaklyConnectedComponentsAlgorithmTVertexTEdgeTest
    {
        [PexMethod]
        public void ComponentCountGet<TVertex,TEdge>(
            [PexAssumeUnderTest]WeaklyConnectedComponentsAlgorithm<TVertex, TEdge> target
        )
            where TEdge : IEdge<TVertex>
        {
            int result = target.ComponentCount;
            PexStore.ValueForValidation<int>("result", result);
            // TODO: add assertions to method WeaklyConnectedComponentsAlgorithmTVertexTEdgeTest.ComponentCountGet(WeaklyConnectedComponentsAlgorithm`2<!!0,!!1>)
        }
        
        [PexMethod]
        public void ComponentsGet<TVertex,TEdge>(
            [PexAssumeUnderTest]WeaklyConnectedComponentsAlgorithm<TVertex, TEdge> target
        )
            where TEdge : IEdge<TVertex>
        {
            IDictionary<TVertex, int> result = target.Components;
            PexStore.ValueForValidation<IDictionary<TVertex, int>>("result", result);
            // TODO: add assertions to method WeaklyConnectedComponentsAlgorithmTVertexTEdgeTest.ComponentsGet(WeaklyConnectedComponentsAlgorithm`2<!!0,!!1>)
        }
        
        [PexMethod]
        public WeaklyConnectedComponentsAlgorithm<TVertex, TEdge> Constructor<TVertex,TEdge>(IVertexListGraph<TVertex, TEdge> visitedGraph)
            where TEdge : IEdge<TVertex>
        {
            WeaklyConnectedComponentsAlgorithm<TVertex, TEdge> target
               = new WeaklyConnectedComponentsAlgorithm<TVertex, TEdge>(visitedGraph);
            return target;
            // TODO: add assertions to method WeaklyConnectedComponentsAlgorithmTVertexTEdgeTest.Constructor(IVertexListGraph`2<!!0,!!1>)
        }
        
        [PexMethod]
        public WeaklyConnectedComponentsAlgorithm<TVertex, TEdge> Constructor01<TVertex,TEdge>(
            IVertexListGraph<TVertex, TEdge> visitedGraph,
            IDictionary<TVertex, int> components
        )
            where TEdge : IEdge<TVertex>
        {
            WeaklyConnectedComponentsAlgorithm<TVertex, TEdge> target
               = new WeaklyConnectedComponentsAlgorithm<TVertex, TEdge>
                  (visitedGraph, components);
            return target;
            // TODO: add assertions to method WeaklyConnectedComponentsAlgorithmTVertexTEdgeTest.Constructor01(IVertexListGraph`2<!!0,!!1>, IDictionary`2<!!0,Int32>)
        }
        
        [PexMethod]
        public WeaklyConnectedComponentsAlgorithm<TVertex, TEdge> Constructor02<TVertex,TEdge>(
            IAlgorithmComponent host,
            IVertexListGraph<TVertex, TEdge> visitedGraph,
            IDictionary<TVertex, int> components
        )
            where TEdge : IEdge<TVertex>
        {
            WeaklyConnectedComponentsAlgorithm<TVertex, TEdge> target
               = new WeaklyConnectedComponentsAlgorithm<TVertex, TEdge>
                  (host, visitedGraph, components);
            return target;
            // TODO: add assertions to method WeaklyConnectedComponentsAlgorithmTVertexTEdgeTest.Constructor02(IAlgorithmComponent, IVertexListGraph`2<!!0,!!1>, IDictionary`2<!!0,Int32>)
        }
        
    }
}
