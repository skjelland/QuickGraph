using Microsoft.Pex.Framework;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using QuickGraph;
using QuickGraph.Algorithms;
using QuickGraph.Algorithms.Observers;
using System.Collections.Generic;

namespace QuickGraph.Algorithms.Observers
{
    /// <summary>
    /// This class contains parameterized unit tests for VertexDistanceRecorderObserver`2
    /// </summary>
    [TestClass]
    [PexClass(typeof(VertexDistanceRecorderObserver<, >))]
    public partial class VertexDistanceRecorderObserverTVertexTEdgeTest
    {
        [PexMethod]
        public void Attach<TVertex,TEdge>(
            [PexAssumeUnderTest]VertexDistanceRecorderObserver<TVertex, TEdge> target,
            IDistanceRecorderAlgorithm<TVertex, TEdge> algorithm
        )
            where TEdge : IEdge<TVertex>
        {
            target.Attach(algorithm);
            // TODO: add assertions to method VertexDistanceRecorderObserverTVertexTEdgeTest.Attach(VertexDistanceRecorderObserver`2<!!0,!!1>, IDistanceRecorderAlgorithm`2<!!0,!!1>)
        }
        
        [PexMethod]
        public VertexDistanceRecorderObserver<TVertex, TEdge> Constructor<TVertex,TEdge>()
            where TEdge : IEdge<TVertex>
        {
            VertexDistanceRecorderObserver<TVertex, TEdge> target
               = new VertexDistanceRecorderObserver<TVertex, TEdge>();
            return target;
            // TODO: add assertions to method VertexDistanceRecorderObserverTVertexTEdgeTest.Constructor()
        }
        
        [PexMethod]
        public VertexDistanceRecorderObserver<TVertex, TEdge> Constructor01<TVertex,TEdge>(IDictionary<TVertex, int> distances)
            where TEdge : IEdge<TVertex>
        {
            VertexDistanceRecorderObserver<TVertex, TEdge> target
               = new VertexDistanceRecorderObserver<TVertex, TEdge>(distances);
            return target;
            // TODO: add assertions to method VertexDistanceRecorderObserverTVertexTEdgeTest.Constructor01(IDictionary`2<!!0,Int32>)
        }
        
        [PexMethod]
        public void Detach<TVertex,TEdge>(
            [PexAssumeUnderTest]VertexDistanceRecorderObserver<TVertex, TEdge> target,
            IDistanceRecorderAlgorithm<TVertex, TEdge> algorithm
        )
            where TEdge : IEdge<TVertex>
        {
            target.Detach(algorithm);
            // TODO: add assertions to method VertexDistanceRecorderObserverTVertexTEdgeTest.Detach(VertexDistanceRecorderObserver`2<!!0,!!1>, IDistanceRecorderAlgorithm`2<!!0,!!1>)
        }
        
        [PexMethod]
        public void DistancesGet<TVertex,TEdge>(
            [PexAssumeUnderTest]VertexDistanceRecorderObserver<TVertex, TEdge> target
        )
            where TEdge : IEdge<TVertex>
        {
            IDictionary<TVertex, int> result = target.Distances;
            PexStore.ValueForValidation<IDictionary<TVertex, int>>("result", result);
            // TODO: add assertions to method VertexDistanceRecorderObserverTVertexTEdgeTest.DistancesGet(VertexDistanceRecorderObserver`2<!!0,!!1>)
        }
        
    }
}
