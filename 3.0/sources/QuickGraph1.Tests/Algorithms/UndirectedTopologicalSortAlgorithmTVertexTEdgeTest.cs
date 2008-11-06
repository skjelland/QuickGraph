using Microsoft.Pex.Framework;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using QuickGraph;
using QuickGraph.Algorithms;
using System.Collections.Generic;

namespace QuickGraph.Algorithms
{
    /// <summary>
    /// This class contains parameterized unit tests for UndirectedTopologicalSortAlgorithm`2
    /// </summary>
    [TestClass]
    [PexClass(typeof(UndirectedTopologicalSortAlgorithm<, >))]
    public partial class UndirectedTopologicalSortAlgorithmTVertexTEdgeTest
    {
        [PexMethod]
        public void AllowCyclicGraphGetSet<TVertex,TEdge>(
            [PexAssumeUnderTest]UndirectedTopologicalSortAlgorithm<TVertex, TEdge> target,
            bool value
        )
            where TEdge : IEdge<TVertex>
        {
            target.AllowCyclicGraph = value;
            bool result = target.AllowCyclicGraph;
            PexStore.ValueForValidation<bool>("result", result);
            PexAssert.AreEqual((object)value, (object)result);
            // TODO: add assertions to method UndirectedTopologicalSortAlgorithmTVertexTEdgeTest.AllowCyclicGraphGetSet(UndirectedTopologicalSortAlgorithm`2<!!0,!!1>, Boolean)
        }
        
        [PexMethod]
        public void Compute<TVertex,TEdge>(
            [PexAssumeUnderTest]UndirectedTopologicalSortAlgorithm<TVertex, TEdge> target,
            IList<TVertex> vertices
        )
            where TEdge : IEdge<TVertex>
        {
            target.Compute(vertices);
            // TODO: add assertions to method UndirectedTopologicalSortAlgorithmTVertexTEdgeTest.Compute(UndirectedTopologicalSortAlgorithm`2<!!0,!!1>, IList`1<!!0>)
        }
        
        [PexMethod]
        public UndirectedTopologicalSortAlgorithm<TVertex, TEdge> Constructor<TVertex,TEdge>(IUndirectedGraph<TVertex, TEdge> g)
            where TEdge : IEdge<TVertex>
        {
            UndirectedTopologicalSortAlgorithm<TVertex, TEdge> target
               = new UndirectedTopologicalSortAlgorithm<TVertex, TEdge>(g);
            return target;
            // TODO: add assertions to method UndirectedTopologicalSortAlgorithmTVertexTEdgeTest.Constructor(IUndirectedGraph`2<!!0,!!1>)
        }
        
        [PexMethod]
        public UndirectedTopologicalSortAlgorithm<TVertex, TEdge> Constructor01<TVertex,TEdge>(IUndirectedGraph<TVertex, TEdge> g, IList<TVertex> vertices)
            where TEdge : IEdge<TVertex>
        {
            UndirectedTopologicalSortAlgorithm<TVertex, TEdge> target
               = new UndirectedTopologicalSortAlgorithm<TVertex, TEdge>(g, vertices);
            return target;
            // TODO: add assertions to method UndirectedTopologicalSortAlgorithmTVertexTEdgeTest.Constructor01(IUndirectedGraph`2<!!0,!!1>, IList`1<!!0>)
        }
        
        [PexMethod]
        public void SortedVerticesGet<TVertex,TEdge>(
            [PexAssumeUnderTest]UndirectedTopologicalSortAlgorithm<TVertex, TEdge> target
        )
            where TEdge : IEdge<TVertex>
        {
            IList<TVertex> result = target.SortedVertices;
            PexStore.ValueForValidation<IList<TVertex>>("result", result);
            // TODO: add assertions to method UndirectedTopologicalSortAlgorithmTVertexTEdgeTest.SortedVerticesGet(UndirectedTopologicalSortAlgorithm`2<!!0,!!1>)
        }
        
    }
}
