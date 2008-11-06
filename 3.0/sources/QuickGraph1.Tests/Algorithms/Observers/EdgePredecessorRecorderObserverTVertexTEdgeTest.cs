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
    /// This class contains parameterized unit tests for EdgePredecessorRecorderObserver`2
    /// </summary>
    [TestClass]
    [PexClass(typeof(EdgePredecessorRecorderObserver<, >))]
    public partial class EdgePredecessorRecorderObserverTVertexTEdgeTest
    {
        [PexMethod]
        public void AllMergedPaths<TVertex,TEdge>(
            [PexAssumeUnderTest]EdgePredecessorRecorderObserver<TVertex, TEdge> target
        )
            where TEdge : IEdge<TVertex>
        {
            ICollection<ICollection<TEdge>> result = target.AllMergedPaths();
            PexStore.ValueForValidation<ICollection<ICollection<TEdge>>>("result", result);
            PexEnumerablePatterns.ForEach<ICollection<TEdge>>
                ((IEnumerable<ICollection<TEdge>>)result);
            PexEnumerablePatterns.ForEach((IEnumerable)result);
            PexEnumerablePatterns.DoubleForEach<ICollection<TEdge>>
                ((IEnumerable<ICollection<TEdge>>)result);
            PexEnumerablePatterns.MoveNextAndReset<ICollection<TEdge>>
                ((IEnumerable<ICollection<TEdge>>)result);
            // TODO: add assertions to method EdgePredecessorRecorderObserverTVertexTEdgeTest.AllMergedPaths(EdgePredecessorRecorderObserver`2<!!0,!!1>)
        }
        
        [PexMethod]
        public void AllPaths<TVertex,TEdge>(
            [PexAssumeUnderTest]EdgePredecessorRecorderObserver<TVertex, TEdge> target
        )
            where TEdge : IEdge<TVertex>
        {
            ICollection<ICollection<TEdge>> result = target.AllPaths();
            PexStore.ValueForValidation<ICollection<ICollection<TEdge>>>("result", result);
            PexEnumerablePatterns.ForEach<ICollection<TEdge>>
                ((IEnumerable<ICollection<TEdge>>)result);
            PexEnumerablePatterns.ForEach((IEnumerable)result);
            PexEnumerablePatterns.DoubleForEach<ICollection<TEdge>>
                ((IEnumerable<ICollection<TEdge>>)result);
            PexEnumerablePatterns.MoveNextAndReset<ICollection<TEdge>>
                ((IEnumerable<ICollection<TEdge>>)result);
            // TODO: add assertions to method EdgePredecessorRecorderObserverTVertexTEdgeTest.AllPaths(EdgePredecessorRecorderObserver`2<!!0,!!1>)
        }
        
        [PexMethod]
        public void Attach<TVertex,TEdge>(
            [PexAssumeUnderTest]EdgePredecessorRecorderObserver<TVertex, TEdge> target,
            IEdgePredecessorRecorderAlgorithm<TVertex, TEdge> algorithm
        )
            where TEdge : IEdge<TVertex>
        {
            target.Attach(algorithm);
            // TODO: add assertions to method EdgePredecessorRecorderObserverTVertexTEdgeTest.Attach(EdgePredecessorRecorderObserver`2<!!0,!!1>, IEdgePredecessorRecorderAlgorithm`2<!!0,!!1>)
        }
        
        [PexMethod]
        public EdgePredecessorRecorderObserver<TVertex, TEdge> Constructor<TVertex,TEdge>()
            where TEdge : IEdge<TVertex>
        {
            EdgePredecessorRecorderObserver<TVertex, TEdge> target
               = new EdgePredecessorRecorderObserver<TVertex, TEdge>();
            return target;
            // TODO: add assertions to method EdgePredecessorRecorderObserverTVertexTEdgeTest.Constructor()
        }
        
        [PexMethod]
        public EdgePredecessorRecorderObserver<TVertex, TEdge> Constructor01<TVertex,TEdge>(IDictionary<TEdge, TEdge> edgePredecessors, IList<TEdge> endPathEdges)
            where TEdge : IEdge<TVertex>
        {
            EdgePredecessorRecorderObserver<TVertex, TEdge> target
               = new EdgePredecessorRecorderObserver<TVertex, TEdge>
                  (edgePredecessors, endPathEdges);
            return target;
            // TODO: add assertions to method EdgePredecessorRecorderObserverTVertexTEdgeTest.Constructor01(IDictionary`2<!!1,!!1>, IList`1<!!1>)
        }
        
        [PexMethod]
        public void Detach<TVertex,TEdge>(
            [PexAssumeUnderTest]EdgePredecessorRecorderObserver<TVertex, TEdge> target,
            IEdgePredecessorRecorderAlgorithm<TVertex, TEdge> algorithm
        )
            where TEdge : IEdge<TVertex>
        {
            target.Detach(algorithm);
            // TODO: add assertions to method EdgePredecessorRecorderObserverTVertexTEdgeTest.Detach(EdgePredecessorRecorderObserver`2<!!0,!!1>, IEdgePredecessorRecorderAlgorithm`2<!!0,!!1>)
        }
        
        [PexMethod]
        public void EdgePredecessorsGet<TVertex,TEdge>(
            [PexAssumeUnderTest]EdgePredecessorRecorderObserver<TVertex, TEdge> target
        )
            where TEdge : IEdge<TVertex>
        {
            IDictionary<TEdge, TEdge> result = target.EdgePredecessors;
            PexStore.ValueForValidation<IDictionary<TEdge, TEdge>>("result", result);
            // TODO: add assertions to method EdgePredecessorRecorderObserverTVertexTEdgeTest.EdgePredecessorsGet(EdgePredecessorRecorderObserver`2<!!0,!!1>)
        }
        
        [PexMethod]
        public void EndPathEdgesGet<TVertex,TEdge>(
            [PexAssumeUnderTest]EdgePredecessorRecorderObserver<TVertex, TEdge> target
        )
            where TEdge : IEdge<TVertex>
        {
            IList<TEdge> result = target.EndPathEdges;
            PexStore.ValueForValidation<IList<TEdge>>("result", result);
            // TODO: add assertions to method EdgePredecessorRecorderObserverTVertexTEdgeTest.EndPathEdgesGet(EdgePredecessorRecorderObserver`2<!!0,!!1>)
        }
        
        [PexMethod]
        public void MergedPath<TVertex,TEdge>(
            [PexAssumeUnderTest]EdgePredecessorRecorderObserver<TVertex, TEdge> target,
            TEdge se,
            IDictionary<TEdge, GraphColor> colors
        )
            where TEdge : IEdge<TVertex>
        {
            ICollection<TEdge> result = target.MergedPath(se, colors);
            PexStore.ValueForValidation<ICollection<TEdge>>("result", result);
            PexEnumerablePatterns.ForEach<TEdge>((IEnumerable<TEdge>)result);
            PexEnumerablePatterns.ForEach((IEnumerable)result);
            PexEnumerablePatterns.DoubleForEach<TEdge>((IEnumerable<TEdge>)result);
            PexEnumerablePatterns.MoveNextAndReset<TEdge>((IEnumerable<TEdge>)result);
            // TODO: add assertions to method EdgePredecessorRecorderObserverTVertexTEdgeTest.MergedPath(EdgePredecessorRecorderObserver`2<!!0,!!1>, !!1, IDictionary`2<!!1,GraphColor>)
        }
        
        [PexMethod]
        public void Path<TVertex,TEdge>(
            [PexAssumeUnderTest]EdgePredecessorRecorderObserver<TVertex, TEdge> target,
            TEdge se
        )
            where TEdge : IEdge<TVertex>
        {
            ICollection<TEdge> result = target.Path(se);
            PexStore.ValueForValidation<ICollection<TEdge>>("result", result);
            PexEnumerablePatterns.ForEach<TEdge>((IEnumerable<TEdge>)result);
            PexEnumerablePatterns.ForEach((IEnumerable)result);
            PexEnumerablePatterns.DoubleForEach<TEdge>((IEnumerable<TEdge>)result);
            PexEnumerablePatterns.MoveNextAndReset<TEdge>((IEnumerable<TEdge>)result);
            // TODO: add assertions to method EdgePredecessorRecorderObserverTVertexTEdgeTest.Path(EdgePredecessorRecorderObserver`2<!!0,!!1>, !!1)
        }
        
    }
}
