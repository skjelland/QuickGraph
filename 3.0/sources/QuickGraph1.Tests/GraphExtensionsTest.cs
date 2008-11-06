using Microsoft.Pex.Framework;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using QuickGraph;
using System.Collections.Generic;

namespace QuickGraph
{
    /// <summary>
    /// This class contains parameterized unit tests for GraphExtensions
    /// </summary>
    [TestClass]
    [PexClass(typeof(GraphExtensions))]
    public partial class GraphExtensionsTest
    {
        [PexMethod]
        [PexGenericArguments(typeof(int), typeof(Edge<int>))]
        public void ToAdjacencyGraph<TVertex, TEdge>(IEnumerable<TEdge> edges, bool allowParallelEdges)
            where TEdge : IEdge<TVertex>
        {
            AdjacencyGraph<TVertex, TEdge> result
               = GraphExtensions.ToAdjacencyGraph<TVertex, TEdge>(edges, allowParallelEdges);
            PexStore.ValueForValidation<AdjacencyGraph<TVertex, TEdge>>("result", result);
            // TODO: add assertions to method GraphExtensionsTest.ToAdjacencyGraph(IEnumerable`1<!!1>, Boolean)
        }
        
        [PexMethod]
        [PexGenericArguments(typeof(int), typeof(Edge<int>))]
        public void ToAdjacencyGraph01<TVertex, TEdge>(IEnumerable<TEdge> edges)
            where TEdge : IEdge<TVertex>
        {
            AdjacencyGraph<TVertex, TEdge> result
               = GraphExtensions.ToAdjacencyGraph<TVertex, TEdge>(edges);
            PexStore.ValueForValidation<AdjacencyGraph<TVertex, TEdge>>("result", result);
            // TODO: add assertions to method GraphExtensionsTest.ToAdjacencyGraph01(IEnumerable`1<!!1>)
        }
        
        [PexMethod]
        [PexGenericArguments(typeof(int), typeof(Edge<int>))]
        public void ToBidirectionalGraph<TVertex, TEdge>(IEnumerable<TEdge> edges, bool allowParallelEdges)
            where TEdge : IEdge<TVertex>
        {
            BidirectionalGraph<TVertex, TEdge> result
               = GraphExtensions.ToBidirectionalGraph<TVertex, TEdge>
                  (edges, allowParallelEdges);
            PexStore.ValueForValidation<BidirectionalGraph<TVertex, TEdge>>
                ("result", result);
            // TODO: add assertions to method GraphExtensionsTest.ToBidirectionalGraph(IEnumerable`1<!!1>, Boolean)
        }
        
        [PexMethod]
        [PexGenericArguments(typeof(int), typeof(Edge<int>))]
        public void ToBidirectionalGraph01<TVertex, TEdge>(IEnumerable<TEdge> edges)
            where TEdge : IEdge<TVertex>
        {
            BidirectionalGraph<TVertex, TEdge> result
               = GraphExtensions.ToBidirectionalGraph<TVertex, TEdge>(edges);
            PexStore.ValueForValidation<BidirectionalGraph<TVertex, TEdge>>
                ("result", result);
            // TODO: add assertions to method GraphExtensionsTest.ToBidirectionalGraph01(IEnumerable`1<!!1>)
        }
        
    }
}
