using Microsoft.Pex.Framework;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using QuickGraph;
using QuickGraph.Algorithms;
using QuickGraph.Algorithms.Services;
using System.Collections.Generic;

namespace QuickGraph.Algorithms
{
    /// <summary>
    /// This class contains parameterized unit tests for ConnectedComponentsAlgorithm`2
    /// </summary>
    [TestClass]
    [PexClass(typeof(ConnectedComponentsAlgorithm<, >))]
    public partial class ConnectedComponentsAlgorithmTVertexTEdgeTest
    {
        [PexMethod]
        public void ComponentCountGet<TVertex,TEdge>(
            [PexAssumeUnderTest]ConnectedComponentsAlgorithm<TVertex, TEdge> target
        )
            where TEdge : IEdge<TVertex>
        {
            int result = target.ComponentCount;
            PexStore.ValueForValidation<int>("result", result);
            // TODO: add assertions to method ConnectedComponentsAlgorithmTVertexTEdgeTest.ComponentCountGet(ConnectedComponentsAlgorithm`2<!!0,!!1>)
        }
        
        [PexMethod]
        public void ComponentsGet<TVertex,TEdge>(
            [PexAssumeUnderTest]ConnectedComponentsAlgorithm<TVertex, TEdge> target
        )
            where TEdge : IEdge<TVertex>
        {
            IDictionary<TVertex, int> result = target.Components;
            PexStore.ValueForValidation<IDictionary<TVertex, int>>("result", result);
            // TODO: add assertions to method ConnectedComponentsAlgorithmTVertexTEdgeTest.ComponentsGet(ConnectedComponentsAlgorithm`2<!!0,!!1>)
        }
        
        [PexMethod]
        public ConnectedComponentsAlgorithm<TVertex, TEdge> Constructor<TVertex,TEdge>(IUndirectedGraph<TVertex, TEdge> g)
            where TEdge : IEdge<TVertex>
        {
            ConnectedComponentsAlgorithm<TVertex, TEdge> target
               = new ConnectedComponentsAlgorithm<TVertex, TEdge>(g);
            return target;
            // TODO: add assertions to method ConnectedComponentsAlgorithmTVertexTEdgeTest.Constructor(IUndirectedGraph`2<!!0,!!1>)
        }
        
        [PexMethod]
        public ConnectedComponentsAlgorithm<TVertex, TEdge> Constructor01<TVertex,TEdge>(
            IUndirectedGraph<TVertex, TEdge> visitedGraph,
            IDictionary<TVertex, int> components
        )
            where TEdge : IEdge<TVertex>
        {
            ConnectedComponentsAlgorithm<TVertex, TEdge> target
               = new ConnectedComponentsAlgorithm<TVertex, TEdge>(visitedGraph, components);
            return target;
            // TODO: add assertions to method ConnectedComponentsAlgorithmTVertexTEdgeTest.Constructor01(IUndirectedGraph`2<!!0,!!1>, IDictionary`2<!!0,Int32>)
        }
        
        [PexMethod]
        public ConnectedComponentsAlgorithm<TVertex, TEdge> Constructor02<TVertex,TEdge>(
            IAlgorithmComponent host,
            IUndirectedGraph<TVertex, TEdge> visitedGraph,
            IDictionary<TVertex, int> components
        )
            where TEdge : IEdge<TVertex>
        {
            ConnectedComponentsAlgorithm<TVertex, TEdge> target
               = new ConnectedComponentsAlgorithm<TVertex, TEdge>
                  (host, visitedGraph, components);
            return target;
            // TODO: add assertions to method ConnectedComponentsAlgorithmTVertexTEdgeTest.Constructor02(IAlgorithmComponent, IUndirectedGraph`2<!!0,!!1>, IDictionary`2<!!0,Int32>)
        }
        
    }
}
