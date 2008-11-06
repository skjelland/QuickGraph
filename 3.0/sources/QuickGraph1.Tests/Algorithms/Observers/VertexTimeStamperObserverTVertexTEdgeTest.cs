using Microsoft.Pex.Framework;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using QuickGraph;
using QuickGraph.Algorithms;
using QuickGraph.Algorithms.Observers;
using System.Collections.Generic;

namespace QuickGraph.Algorithms.Observers
{
    /// <summary>
    /// This class contains parameterized unit tests for VertexTimeStamperObserver`2
    /// </summary>
    [TestClass]
    [PexClass(typeof(VertexTimeStamperObserver<, >))]
    public partial class VertexTimeStamperObserverTVertexTEdgeTest
    {
        [PexMethod]
        public void Attach<TVertex,TEdge>(
            [PexAssumeUnderTest]VertexTimeStamperObserver<TVertex, TEdge> target,
            IVertexTimeStamperAlgorithm<TVertex, TEdge> algorithm
        )
            where TEdge : IEdge<TVertex>
        {
            target.Attach(algorithm);
            // TODO: add assertions to method VertexTimeStamperObserverTVertexTEdgeTest.Attach(VertexTimeStamperObserver`2<!!0,!!1>, IVertexTimeStamperAlgorithm`2<!!0,!!1>)
        }
        
        [PexMethod]
        public VertexTimeStamperObserver<TVertex, TEdge> Constructor<TVertex,TEdge>()
            where TEdge : IEdge<TVertex>
        {
            VertexTimeStamperObserver<TVertex, TEdge> target
               = new VertexTimeStamperObserver<TVertex, TEdge>();
            return target;
            // TODO: add assertions to method VertexTimeStamperObserverTVertexTEdgeTest.Constructor()
        }
        
        [PexMethod]
        public VertexTimeStamperObserver<TVertex, TEdge> Constructor01<TVertex,TEdge>(
            IDictionary<TVertex, int> discoverTimes,
            IDictionary<TVertex, int> finishTimes
        )
            where TEdge : IEdge<TVertex>
        {
            VertexTimeStamperObserver<TVertex, TEdge> target
               = new VertexTimeStamperObserver<TVertex, TEdge>(discoverTimes, finishTimes);
            return target;
            // TODO: add assertions to method VertexTimeStamperObserverTVertexTEdgeTest.Constructor01(IDictionary`2<!!0,Int32>, IDictionary`2<!!0,Int32>)
        }
        
        [PexMethod]
        public void Detach<TVertex,TEdge>(
            [PexAssumeUnderTest]VertexTimeStamperObserver<TVertex, TEdge> target,
            IVertexTimeStamperAlgorithm<TVertex, TEdge> algorithm
        )
            where TEdge : IEdge<TVertex>
        {
            target.Detach(algorithm);
            // TODO: add assertions to method VertexTimeStamperObserverTVertexTEdgeTest.Detach(VertexTimeStamperObserver`2<!!0,!!1>, IVertexTimeStamperAlgorithm`2<!!0,!!1>)
        }
        
        [PexMethod]
        public void DiscoverTimesGet<TVertex,TEdge>(
            [PexAssumeUnderTest]VertexTimeStamperObserver<TVertex, TEdge> target
        )
            where TEdge : IEdge<TVertex>
        {
            IDictionary<TVertex, int> result = target.DiscoverTimes;
            PexStore.ValueForValidation<IDictionary<TVertex, int>>("result", result);
            // TODO: add assertions to method VertexTimeStamperObserverTVertexTEdgeTest.DiscoverTimesGet(VertexTimeStamperObserver`2<!!0,!!1>)
        }
        
        [PexMethod]
        public void FinishTimesGet<TVertex,TEdge>(
            [PexAssumeUnderTest]VertexTimeStamperObserver<TVertex, TEdge> target
        )
            where TEdge : IEdge<TVertex>
        {
            IDictionary<TVertex, int> result = target.FinishTimes;
            PexStore.ValueForValidation<IDictionary<TVertex, int>>("result", result);
            // TODO: add assertions to method VertexTimeStamperObserverTVertexTEdgeTest.FinishTimesGet(VertexTimeStamperObserver`2<!!0,!!1>)
        }
        
    }
}
