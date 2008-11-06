using Microsoft.Pex.Framework;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using QuickGraph;
using QuickGraph.Algorithms;
using QuickGraph.Algorithms.Services;
using System.Collections.Generic;

namespace QuickGraph.Algorithms
{
    /// <summary>
    /// This class contains parameterized unit tests for StronglyConnectedComponentsAlgorithm`2
    /// </summary>
    [TestClass]
    [PexClass(typeof(StronglyConnectedComponentsAlgorithm<, >))]
    public partial class StronglyConnectedComponentsAlgorithmTVertexTEdgeTest
    {
        [PexMethod]
        public void ComponentCountGet<TVertex,TEdge>(
            [PexAssumeUnderTest]StronglyConnectedComponentsAlgorithm<TVertex, TEdge> target
        )
            where TEdge : IEdge<TVertex>
        {
            int result = target.ComponentCount;
            PexStore.ValueForValidation<int>("result", result);
            // TODO: add assertions to method StronglyConnectedComponentsAlgorithmTVertexTEdgeTest.ComponentCountGet(StronglyConnectedComponentsAlgorithm`2<!!0,!!1>)
        }
        
        [PexMethod]
        public void ComponentsGet<TVertex,TEdge>(
            [PexAssumeUnderTest]StronglyConnectedComponentsAlgorithm<TVertex, TEdge> target
        )
            where TEdge : IEdge<TVertex>
        {
            IDictionary<TVertex, int> result = target.Components;
            PexStore.ValueForValidation<IDictionary<TVertex, int>>("result", result);
            // TODO: add assertions to method StronglyConnectedComponentsAlgorithmTVertexTEdgeTest.ComponentsGet(StronglyConnectedComponentsAlgorithm`2<!!0,!!1>)
        }
        
        [PexMethod]
        public StronglyConnectedComponentsAlgorithm<TVertex, TEdge> Constructor<TVertex,TEdge>(IVertexListGraph<TVertex, TEdge> g)
            where TEdge : IEdge<TVertex>
        {
            StronglyConnectedComponentsAlgorithm<TVertex, TEdge> target
               = new StronglyConnectedComponentsAlgorithm<TVertex, TEdge>(g);
            return target;
            // TODO: add assertions to method StronglyConnectedComponentsAlgorithmTVertexTEdgeTest.Constructor(IVertexListGraph`2<!!0,!!1>)
        }
        
        [PexMethod]
        public StronglyConnectedComponentsAlgorithm<TVertex, TEdge> Constructor01<TVertex,TEdge>(IVertexListGraph<TVertex, TEdge> g, IDictionary<TVertex, int> components)
            where TEdge : IEdge<TVertex>
        {
            StronglyConnectedComponentsAlgorithm<TVertex, TEdge> target
               = new StronglyConnectedComponentsAlgorithm<TVertex, TEdge>(g, components);
            return target;
            // TODO: add assertions to method StronglyConnectedComponentsAlgorithmTVertexTEdgeTest.Constructor01(IVertexListGraph`2<!!0,!!1>, IDictionary`2<!!0,Int32>)
        }
        
        [PexMethod]
        public StronglyConnectedComponentsAlgorithm<TVertex, TEdge> Constructor02<TVertex,TEdge>(
            IAlgorithmComponent host,
            IVertexListGraph<TVertex, TEdge> g,
            IDictionary<TVertex, int> components
        )
            where TEdge : IEdge<TVertex>
        {
            StronglyConnectedComponentsAlgorithm<TVertex, TEdge> target
               = new StronglyConnectedComponentsAlgorithm<TVertex, TEdge>
                  (host, g, components);
            return target;
            // TODO: add assertions to method StronglyConnectedComponentsAlgorithmTVertexTEdgeTest.Constructor02(IAlgorithmComponent, IVertexListGraph`2<!!0,!!1>, IDictionary`2<!!0,Int32>)
        }
        
        [PexMethod]
        public void DiscoverTimesGet<TVertex,TEdge>(
            [PexAssumeUnderTest]StronglyConnectedComponentsAlgorithm<TVertex, TEdge> target
        )
            where TEdge : IEdge<TVertex>
        {
            IDictionary<TVertex, int> result = target.DiscoverTimes;
            PexStore.ValueForValidation<IDictionary<TVertex, int>>("result", result);
            // TODO: add assertions to method StronglyConnectedComponentsAlgorithmTVertexTEdgeTest.DiscoverTimesGet(StronglyConnectedComponentsAlgorithm`2<!!0,!!1>)
        }
        
        [PexMethod]
        public void RootsGet<TVertex,TEdge>(
            [PexAssumeUnderTest]StronglyConnectedComponentsAlgorithm<TVertex, TEdge> target
        )
            where TEdge : IEdge<TVertex>
        {
            IDictionary<TVertex, TVertex> result = target.Roots;
            PexStore.ValueForValidation<IDictionary<TVertex, TVertex>>("result", result);
            // TODO: add assertions to method StronglyConnectedComponentsAlgorithmTVertexTEdgeTest.RootsGet(StronglyConnectedComponentsAlgorithm`2<!!0,!!1>)
        }
        
    }
}
