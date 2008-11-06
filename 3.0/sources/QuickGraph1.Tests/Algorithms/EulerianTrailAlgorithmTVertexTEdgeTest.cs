using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Wizard;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using QuickGraph;
using QuickGraph.Algorithms;
using QuickGraph.Algorithms.Services;
using System.Collections;
using System.Collections.Generic;

namespace QuickGraph.Algorithms
{
    /// <summary>
    /// This class contains parameterized unit tests for EulerianTrailAlgorithm`2
    /// </summary>
    [TestClass]
    [PexClass(typeof(EulerianTrailAlgorithm<, >))]
    public partial class EulerianTrailAlgorithmTVertexTEdgeTest
    {
        [PexMethod]
        public void CircuitGet<TVertex,TEdge>([PexAssumeUnderTest]EulerianTrailAlgorithm<TVertex, TEdge> target)
            where TEdge : IEdge<TVertex>
        {
            List<TEdge> result = target.Circuit;
            PexStore.ValueForValidation<List<TEdge>>("result", result);
            // TODO: add assertions to method EulerianTrailAlgorithmTVertexTEdgeTest.CircuitGet(EulerianTrailAlgorithm`2<!!0,!!1>)
        }
        
        [PexMethod]
        public int ComputeEulerianPathCount<TVertex,TEdge>(IVertexAndEdgeListGraph<TVertex, TEdge> g)
            where TEdge : IEdge<TVertex>
        {
            int result = EulerianTrailAlgorithm<TVertex, TEdge>.ComputeEulerianPathCount(g);
            return result;
            // TODO: add assertions to method EulerianTrailAlgorithmTVertexTEdgeTest.ComputeEulerianPathCount(IVertexAndEdgeListGraph`2<!!0,!!1>)
        }
        
        [PexMethod]
        public EulerianTrailAlgorithm<TVertex, TEdge> Constructor<TVertex,TEdge>(IMutableVertexAndEdgeListGraph<TVertex, TEdge> visitedGraph)
            where TEdge : IEdge<TVertex>
        {
            EulerianTrailAlgorithm<TVertex, TEdge> target
               = new EulerianTrailAlgorithm<TVertex, TEdge>(visitedGraph);
            return target;
            // TODO: add assertions to method EulerianTrailAlgorithmTVertexTEdgeTest.Constructor(IMutableVertexAndEdgeListGraph`2<!!0,!!1>)
        }
        
        [PexMethod]
        public EulerianTrailAlgorithm<TVertex, TEdge> Constructor01<TVertex,TEdge>(
            IAlgorithmComponent host,
            IMutableVertexAndEdgeListGraph<TVertex, TEdge> visitedGraph
        )
            where TEdge : IEdge<TVertex>
        {
            EulerianTrailAlgorithm<TVertex, TEdge> target
               = new EulerianTrailAlgorithm<TVertex, TEdge>(host, visitedGraph);
            return target;
            // TODO: add assertions to method EulerianTrailAlgorithmTVertexTEdgeTest.Constructor01(IAlgorithmComponent, IMutableVertexAndEdgeListGraph`2<!!0,!!1>)
        }
        
        [PexMethod]
        public void RemoveTemporaryEdges<TVertex,TEdge>([PexAssumeUnderTest]EulerianTrailAlgorithm<TVertex, TEdge> target)
            where TEdge : IEdge<TVertex>
        {
            target.RemoveTemporaryEdges();
            // TODO: add assertions to method EulerianTrailAlgorithmTVertexTEdgeTest.RemoveTemporaryEdges(EulerianTrailAlgorithm`2<!!0,!!1>)
        }
        
        [PexMethod]
        public void Trails<TVertex,TEdge>([PexAssumeUnderTest]EulerianTrailAlgorithm<TVertex, TEdge> target)
            where TEdge : IEdge<TVertex>
        {
            ICollection<ICollection<TEdge>> result = target.Trails();
            PexStore.ValueForValidation<ICollection<ICollection<TEdge>>>("result", result);
            PexEnumerablePatterns.ForEach<ICollection<TEdge>>
                ((IEnumerable<ICollection<TEdge>>)result);
            PexEnumerablePatterns.ForEach((IEnumerable)result);
            PexEnumerablePatterns.DoubleForEach<ICollection<TEdge>>
                ((IEnumerable<ICollection<TEdge>>)result);
            PexEnumerablePatterns.MoveNextAndReset<ICollection<TEdge>>
                ((IEnumerable<ICollection<TEdge>>)result);
            // TODO: add assertions to method EulerianTrailAlgorithmTVertexTEdgeTest.Trails(EulerianTrailAlgorithm`2<!!0,!!1>)
        }
        
        [PexMethod]
        public void Trails01<TVertex,TEdge>(
            [PexAssumeUnderTest]EulerianTrailAlgorithm<TVertex, TEdge> target,
            TVertex s
        )
            where TEdge : IEdge<TVertex>
        {
            ICollection<ICollection<TEdge>> result = target.Trails(s);
            PexStore.ValueForValidation<ICollection<ICollection<TEdge>>>("result", result);
            PexEnumerablePatterns.ForEach<ICollection<TEdge>>
                ((IEnumerable<ICollection<TEdge>>)result);
            PexEnumerablePatterns.ForEach((IEnumerable)result);
            PexEnumerablePatterns.DoubleForEach<ICollection<TEdge>>
                ((IEnumerable<ICollection<TEdge>>)result);
            PexEnumerablePatterns.MoveNextAndReset<ICollection<TEdge>>
                ((IEnumerable<ICollection<TEdge>>)result);
            // TODO: add assertions to method EulerianTrailAlgorithmTVertexTEdgeTest.Trails01(EulerianTrailAlgorithm`2<!!0,!!1>, !!0)
        }
        
    }
}
