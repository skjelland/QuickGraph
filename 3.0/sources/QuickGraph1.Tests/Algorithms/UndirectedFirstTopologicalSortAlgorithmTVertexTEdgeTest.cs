using Microsoft.Pex.Framework;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using QuickGraph;
using QuickGraph.Algorithms;
using QuickGraph.Collections;
using System.Collections.Generic;

namespace QuickGraph.Algorithms
{
    /// <summary>
    /// This class contains parameterized unit tests for UndirectedFirstTopologicalSortAlgorithm`2
    /// </summary>
    [TestClass]
    [PexClass(typeof(UndirectedFirstTopologicalSortAlgorithm<, >))]
    public partial class UndirectedFirstTopologicalSortAlgorithmTVertexTEdgeTest
    {
        [PexMethod]
        public void AllowCyclicGraphGetSet<TVertex,TEdge>(
            [PexAssumeUnderTest]UndirectedFirstTopologicalSortAlgorithm<TVertex, TEdge> target,
            bool value
        )
            where TEdge : IEdge<TVertex>
        {
            target.AllowCyclicGraph = value;
            bool result = target.AllowCyclicGraph;
            PexStore.ValueForValidation<bool>("result", result);
            PexAssert.AreEqual((object)value, (object)result);
            // TODO: add assertions to method UndirectedFirstTopologicalSortAlgorithmTVertexTEdgeTest.AllowCyclicGraphGetSet(UndirectedFirstTopologicalSortAlgorithm`2<!!0,!!1>, Boolean)
        }
        
        [PexMethod]
        public void Compute<TVertex,TEdge>(
            [PexAssumeUnderTest]UndirectedFirstTopologicalSortAlgorithm<TVertex, TEdge> target,
            IList<TVertex> vertices
        )
            where TEdge : IEdge<TVertex>
        {
            target.Compute(vertices);
            // TODO: add assertions to method UndirectedFirstTopologicalSortAlgorithmTVertexTEdgeTest.Compute(UndirectedFirstTopologicalSortAlgorithm`2<!!0,!!1>, IList`1<!!0>)
        }
        
        [PexMethod]
        public UndirectedFirstTopologicalSortAlgorithm<TVertex, TEdge> Constructor<TVertex,TEdge>(IUndirectedGraph<TVertex, TEdge> visitedGraph)
            where TEdge : IEdge<TVertex>
        {
            UndirectedFirstTopologicalSortAlgorithm<TVertex, TEdge> target
               = new UndirectedFirstTopologicalSortAlgorithm<TVertex, TEdge>(visitedGraph);
            return target;
            // TODO: add assertions to method UndirectedFirstTopologicalSortAlgorithmTVertexTEdgeTest.Constructor(IUndirectedGraph`2<!!0,!!1>)
        }
        
        [PexMethod]
        public void DegreesGet<TVertex,TEdge>(
            [PexAssumeUnderTest]UndirectedFirstTopologicalSortAlgorithm<TVertex, TEdge> target
        )
            where TEdge : IEdge<TVertex>
        {
            IDictionary<TVertex, int> result = target.Degrees;
            PexStore.ValueForValidation<IDictionary<TVertex, int>>("result", result);
            // TODO: add assertions to method UndirectedFirstTopologicalSortAlgorithmTVertexTEdgeTest.DegreesGet(UndirectedFirstTopologicalSortAlgorithm`2<!!0,!!1>)
        }
        
        [PexMethod]
        public void HeapGet<TVertex,TEdge>(
            [PexAssumeUnderTest]UndirectedFirstTopologicalSortAlgorithm<TVertex, TEdge> target
        )
            where TEdge : IEdge<TVertex>
        {
            PriorityQueue<TVertex, int> result = target.Heap;
            PexStore.ValueForValidation<PriorityQueue<TVertex, int>>("result", result);
            // TODO: add assertions to method UndirectedFirstTopologicalSortAlgorithmTVertexTEdgeTest.HeapGet(UndirectedFirstTopologicalSortAlgorithm`2<!!0,!!1>)
        }
        
        [PexMethod]
        public void SortedVerticesGet<TVertex,TEdge>(
            [PexAssumeUnderTest]UndirectedFirstTopologicalSortAlgorithm<TVertex, TEdge> target
        )
            where TEdge : IEdge<TVertex>
        {
            ICollection<TVertex> result = target.SortedVertices;
            PexStore.ValueForValidation<ICollection<TVertex>>("result", result);
            // TODO: add assertions to method UndirectedFirstTopologicalSortAlgorithmTVertexTEdgeTest.SortedVerticesGet(UndirectedFirstTopologicalSortAlgorithm`2<!!0,!!1>)
        }
        
    }
}
