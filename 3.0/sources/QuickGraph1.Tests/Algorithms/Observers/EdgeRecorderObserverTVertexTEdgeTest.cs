using Microsoft.Pex.Framework;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using QuickGraph;
using QuickGraph.Algorithms;
using QuickGraph.Algorithms.Observers;
using System.Collections.Generic;

namespace QuickGraph.Algorithms.Observers
{
    /// <summary>
    /// This class contains parameterized unit tests for EdgeRecorderObserver`2
    /// </summary>
    [TestClass]
    [PexClass(typeof(EdgeRecorderObserver<, >))]
    public partial class EdgeRecorderObserverTVertexTEdgeTest
    {
        [PexMethod]
        public void Attach<TVertex,TEdge>(
            [PexAssumeUnderTest]EdgeRecorderObserver<TVertex, TEdge> target,
            ITreeBuilderAlgorithm<TVertex, TEdge> algorithm
        )
            where TEdge : IEdge<TVertex>
        {
            target.Attach(algorithm);
            // TODO: add assertions to method EdgeRecorderObserverTVertexTEdgeTest.Attach(EdgeRecorderObserver`2<!!0,!!1>, ITreeBuilderAlgorithm`2<!!0,!!1>)
        }
        
        [PexMethod]
        public EdgeRecorderObserver<TVertex, TEdge> Constructor<TVertex,TEdge>()
            where TEdge : IEdge<TVertex>
        {
            EdgeRecorderObserver<TVertex, TEdge> target
               = new EdgeRecorderObserver<TVertex, TEdge>();
            return target;
            // TODO: add assertions to method EdgeRecorderObserverTVertexTEdgeTest.Constructor()
        }
        
        [PexMethod]
        public EdgeRecorderObserver<TVertex, TEdge> Constructor01<TVertex,TEdge>(IList<TEdge> edges)
            where TEdge : IEdge<TVertex>
        {
            EdgeRecorderObserver<TVertex, TEdge> target
               = new EdgeRecorderObserver<TVertex, TEdge>(edges);
            return target;
            // TODO: add assertions to method EdgeRecorderObserverTVertexTEdgeTest.Constructor01(IList`1<!!1>)
        }
        
        [PexMethod]
        public void Detach<TVertex,TEdge>(
            [PexAssumeUnderTest]EdgeRecorderObserver<TVertex, TEdge> target,
            ITreeBuilderAlgorithm<TVertex, TEdge> algorithm
        )
            where TEdge : IEdge<TVertex>
        {
            target.Detach(algorithm);
            // TODO: add assertions to method EdgeRecorderObserverTVertexTEdgeTest.Detach(EdgeRecorderObserver`2<!!0,!!1>, ITreeBuilderAlgorithm`2<!!0,!!1>)
        }
        
        [PexMethod]
        public void EdgesGet<TVertex,TEdge>([PexAssumeUnderTest]EdgeRecorderObserver<TVertex, TEdge> target)
            where TEdge : IEdge<TVertex>
        {
            IList<TEdge> result = target.Edges;
            PexStore.ValueForValidation<IList<TEdge>>("result", result);
            // TODO: add assertions to method EdgeRecorderObserverTVertexTEdgeTest.EdgesGet(EdgeRecorderObserver`2<!!0,!!1>)
        }
        
        [PexMethod]
        public void RecordEdge<TVertex,TEdge>(
            [PexAssumeUnderTest]EdgeRecorderObserver<TVertex, TEdge> target,
            object sender,
            EdgeEventArgs<TVertex, TEdge> args
        )
            where TEdge : IEdge<TVertex>
        {
            target.RecordEdge(sender, args);
            // TODO: add assertions to method EdgeRecorderObserverTVertexTEdgeTest.RecordEdge(EdgeRecorderObserver`2<!!0,!!1>, Object, EdgeEventArgs`2<!!0,!!1>)
        }
        
        [PexMethod]
        public void RecordSource<TVertex,TEdge>(
            [PexAssumeUnderTest]EdgeRecorderObserver<TVertex, TEdge> target,
            object sender,
            EdgeEdgeEventArgs<TVertex, TEdge> args
        )
            where TEdge : IEdge<TVertex>
        {
            target.RecordSource(sender, args);
            // TODO: add assertions to method EdgeRecorderObserverTVertexTEdgeTest.RecordSource(EdgeRecorderObserver`2<!!0,!!1>, Object, EdgeEdgeEventArgs`2<!!0,!!1>)
        }
        
        [PexMethod]
        public void RecordTarget<TVertex,TEdge>(
            [PexAssumeUnderTest]EdgeRecorderObserver<TVertex, TEdge> target,
            object sender,
            EdgeEdgeEventArgs<TVertex, TEdge> args
        )
            where TEdge : IEdge<TVertex>
        {
            target.RecordTarget(sender, args);
            // TODO: add assertions to method EdgeRecorderObserverTVertexTEdgeTest.RecordTarget(EdgeRecorderObserver`2<!!0,!!1>, Object, EdgeEdgeEventArgs`2<!!0,!!1>)
        }
        
    }
}
