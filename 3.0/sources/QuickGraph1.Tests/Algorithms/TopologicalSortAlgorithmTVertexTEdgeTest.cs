using Microsoft.Pex.Framework;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using QuickGraph;
using QuickGraph.Algorithms;
using System.Collections.Generic;

namespace QuickGraph.Algorithms
{
    /// <summary>
    /// This class contains parameterized unit tests for TopologicalSortAlgorithm`2
    /// </summary>
    [TestClass]
    [PexClass(typeof(TopologicalSortAlgorithm<, >))]
    public partial class TopologicalSortAlgorithmTVertexTEdgeTest
    {
        [PexMethod]
        public void AllowCyclicGraphGet<TVertex,TEdge>([PexAssumeUnderTest]TopologicalSortAlgorithm<TVertex, TEdge> target)
            where TEdge : IEdge<TVertex>
        {
            bool result = target.AllowCyclicGraph;
            PexStore.ValueForValidation<bool>("result", result);
            // TODO: add assertions to method TopologicalSortAlgorithmTVertexTEdgeTest.AllowCyclicGraphGet(TopologicalSortAlgorithm`2<!!0,!!1>)
        }
        
        [PexMethod]
        public void Compute<TVertex,TEdge>(
            [PexAssumeUnderTest]TopologicalSortAlgorithm<TVertex, TEdge> target,
            IList<TVertex> vertices
        )
            where TEdge : IEdge<TVertex>
        {
            target.Compute(vertices);
            // TODO: add assertions to method TopologicalSortAlgorithmTVertexTEdgeTest.Compute(TopologicalSortAlgorithm`2<!!0,!!1>, IList`1<!!0>)
        }
        
        [PexMethod]
        public TopologicalSortAlgorithm<TVertex, TEdge> Constructor<TVertex,TEdge>(IVertexListGraph<TVertex, TEdge> g)
            where TEdge : IEdge<TVertex>
        {
            TopologicalSortAlgorithm<TVertex, TEdge> target
               = new TopologicalSortAlgorithm<TVertex, TEdge>(g);
            return target;
            // TODO: add assertions to method TopologicalSortAlgorithmTVertexTEdgeTest.Constructor(IVertexListGraph`2<!!0,!!1>)
        }
        
        [PexMethod]
        public TopologicalSortAlgorithm<TVertex, TEdge> Constructor01<TVertex,TEdge>(IVertexListGraph<TVertex, TEdge> g, IList<TVertex> vertices)
            where TEdge : IEdge<TVertex>
        {
            TopologicalSortAlgorithm<TVertex, TEdge> target
               = new TopologicalSortAlgorithm<TVertex, TEdge>(g, vertices);
            return target;
            // TODO: add assertions to method TopologicalSortAlgorithmTVertexTEdgeTest.Constructor01(IVertexListGraph`2<!!0,!!1>, IList`1<!!0>)
        }
        
        [PexMethod]
        public void SortedVerticesGet<TVertex,TEdge>([PexAssumeUnderTest]TopologicalSortAlgorithm<TVertex, TEdge> target)
            where TEdge : IEdge<TVertex>
        {
            IList<TVertex> result = target.SortedVertices;
            PexStore.ValueForValidation<IList<TVertex>>("result", result);
            // TODO: add assertions to method TopologicalSortAlgorithmTVertexTEdgeTest.SortedVerticesGet(TopologicalSortAlgorithm`2<!!0,!!1>)
        }
        
    }
}
