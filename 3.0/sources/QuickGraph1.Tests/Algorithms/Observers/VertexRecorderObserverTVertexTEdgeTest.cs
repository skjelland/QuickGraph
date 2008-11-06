using Microsoft.Pex.Framework;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using QuickGraph;
using QuickGraph.Algorithms;
using QuickGraph.Algorithms.Observers;
using System.Collections.Generic;

namespace QuickGraph.Algorithms.Observers
{
    /// <summary>
    /// This class contains parameterized unit tests for VertexRecorderObserver`2
    /// </summary>
    [TestClass]
    [PexClass(typeof(VertexRecorderObserver<, >))]
    public partial class VertexRecorderObserverTVertexTEdgeTest
    {
        [PexMethod]
        public void Attach<TVertex,TEdge>(
            [PexAssumeUnderTest]VertexRecorderObserver<TVertex, TEdge> target,
            IVertexTimeStamperAlgorithm<TVertex, TEdge> algorithm
        )
            where TEdge : IEdge<TVertex>
        {
            target.Attach(algorithm);
            // TODO: add assertions to method VertexRecorderObserverTVertexTEdgeTest.Attach(VertexRecorderObserver`2<!!0,!!1>, IVertexTimeStamperAlgorithm`2<!!0,!!1>)
        }
        
        [PexMethod]
        public VertexRecorderObserver<TVertex, TEdge> Constructor<TVertex,TEdge>()
            where TEdge : IEdge<TVertex>
        {
            VertexRecorderObserver<TVertex, TEdge> target
               = new VertexRecorderObserver<TVertex, TEdge>();
            return target;
            // TODO: add assertions to method VertexRecorderObserverTVertexTEdgeTest.Constructor()
        }
        
        [PexMethod]
        public VertexRecorderObserver<TVertex, TEdge> Constructor01<TVertex,TEdge>(IList<TVertex> vertices)
            where TEdge : IEdge<TVertex>
        {
            VertexRecorderObserver<TVertex, TEdge> target
               = new VertexRecorderObserver<TVertex, TEdge>(vertices);
            return target;
            // TODO: add assertions to method VertexRecorderObserverTVertexTEdgeTest.Constructor01(IList`1<!!0>)
        }
        
        [PexMethod]
        public void Detach<TVertex,TEdge>(
            [PexAssumeUnderTest]VertexRecorderObserver<TVertex, TEdge> target,
            IVertexTimeStamperAlgorithm<TVertex, TEdge> algorithm
        )
            where TEdge : IEdge<TVertex>
        {
            target.Detach(algorithm);
            // TODO: add assertions to method VertexRecorderObserverTVertexTEdgeTest.Detach(VertexRecorderObserver`2<!!0,!!1>, IVertexTimeStamperAlgorithm`2<!!0,!!1>)
        }
        
        [PexMethod]
        public void VerticesGet<TVertex,TEdge>([PexAssumeUnderTest]VertexRecorderObserver<TVertex, TEdge> target)
            where TEdge : IEdge<TVertex>
        {
            IEnumerable<TVertex> result = target.Vertices;
            PexStore.ValueForValidation<IEnumerable<TVertex>>("result", result);
            // TODO: add assertions to method VertexRecorderObserverTVertexTEdgeTest.VerticesGet(VertexRecorderObserver`2<!!0,!!1>)
        }
        
    }
}
