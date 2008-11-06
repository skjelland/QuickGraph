using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Wizard;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using QuickGraph;
using QuickGraph.Algorithms;
using QuickGraph.Algorithms.Observers;
using System.Collections;
using System.Collections.Generic;

namespace QuickGraph.Algorithms.Observers
{
    /// <summary>
    /// This class contains parameterized unit tests for VertexPredecessorPathRecorderObserver`2
    /// </summary>
    [TestClass]
    [PexClass(typeof(VertexPredecessorPathRecorderObserver<, >))]
    public partial class VertexPredecessorPathRecorderObserverTVertexTEdgeTest
    {
        [PexMethod]
        public void AllPaths<TVertex,TEdge>(
            [PexAssumeUnderTest]VertexPredecessorPathRecorderObserver<TVertex, TEdge> target
        )
            where TEdge : IEdge<TVertex>
        {
            IEnumerable<IEnumerable<TEdge>> result = target.AllPaths();
            PexStore.ValueForValidation<IEnumerable<IEnumerable<TEdge>>>("result", result);
            PexEnumerablePatterns.ForEach<IEnumerable<TEdge>>(result);
            PexEnumerablePatterns.ForEach((IEnumerable)result);
            PexEnumerablePatterns.DoubleForEach<IEnumerable<TEdge>>(result);
            PexEnumerablePatterns.MoveNextAndReset<IEnumerable<TEdge>>(result);
            // TODO: add assertions to method VertexPredecessorPathRecorderObserverTVertexTEdgeTest.AllPaths(VertexPredecessorPathRecorderObserver`2<!!0,!!1>)
        }
        
        [PexMethod]
        public void Attach<TVertex,TEdge>(
            [PexAssumeUnderTest]VertexPredecessorPathRecorderObserver<TVertex, TEdge> target,
            IVertexPredecessorRecorderAlgorithm<TVertex, TEdge> algorithm
        )
            where TEdge : IEdge<TVertex>
        {
            target.Attach(algorithm);
            // TODO: add assertions to method VertexPredecessorPathRecorderObserverTVertexTEdgeTest.Attach(VertexPredecessorPathRecorderObserver`2<!!0,!!1>, IVertexPredecessorRecorderAlgorithm`2<!!0,!!1>)
        }
        
        [PexMethod]
        public VertexPredecessorPathRecorderObserver<TVertex, TEdge> Constructor<TVertex,TEdge>()
            where TEdge : IEdge<TVertex>
        {
            VertexPredecessorPathRecorderObserver<TVertex, TEdge> target
               = new VertexPredecessorPathRecorderObserver<TVertex, TEdge>();
            return target;
            // TODO: add assertions to method VertexPredecessorPathRecorderObserverTVertexTEdgeTest.Constructor()
        }
        
        [PexMethod]
        public VertexPredecessorPathRecorderObserver<TVertex, TEdge> Constructor01<TVertex,TEdge>(IDictionary<TVertex, TEdge> vertexPredecessors)
            where TEdge : IEdge<TVertex>
        {
            VertexPredecessorPathRecorderObserver<TVertex, TEdge> target
               = new VertexPredecessorPathRecorderObserver<TVertex, TEdge>
                  (vertexPredecessors);
            return target;
            // TODO: add assertions to method VertexPredecessorPathRecorderObserverTVertexTEdgeTest.Constructor01(IDictionary`2<!!0,!!1>)
        }
        
        [PexMethod]
        public void Detach<TVertex,TEdge>(
            [PexAssumeUnderTest]VertexPredecessorPathRecorderObserver<TVertex, TEdge> target,
            IVertexPredecessorRecorderAlgorithm<TVertex, TEdge> algorithm
        )
            where TEdge : IEdge<TVertex>
        {
            target.Detach(algorithm);
            // TODO: add assertions to method VertexPredecessorPathRecorderObserverTVertexTEdgeTest.Detach(VertexPredecessorPathRecorderObserver`2<!!0,!!1>, IVertexPredecessorRecorderAlgorithm`2<!!0,!!1>)
        }
        
        [PexMethod]
        public void EndPathVerticesGet<TVertex,TEdge>(
            [PexAssumeUnderTest]VertexPredecessorPathRecorderObserver<TVertex, TEdge> target
        )
            where TEdge : IEdge<TVertex>
        {
            ICollection<TVertex> result = target.EndPathVertices;
            PexStore.ValueForValidation<ICollection<TVertex>>("result", result);
            // TODO: add assertions to method VertexPredecessorPathRecorderObserverTVertexTEdgeTest.EndPathVerticesGet(VertexPredecessorPathRecorderObserver`2<!!0,!!1>)
        }
        
        [PexMethod]
        public void VertexPredecessorsGet<TVertex,TEdge>(
            [PexAssumeUnderTest]VertexPredecessorPathRecorderObserver<TVertex, TEdge> target
        )
            where TEdge : IEdge<TVertex>
        {
            IDictionary<TVertex, TEdge> result = target.VertexPredecessors;
            PexStore.ValueForValidation<IDictionary<TVertex, TEdge>>("result", result);
            // TODO: add assertions to method VertexPredecessorPathRecorderObserverTVertexTEdgeTest.VertexPredecessorsGet(VertexPredecessorPathRecorderObserver`2<!!0,!!1>)
        }
        
    }
}
