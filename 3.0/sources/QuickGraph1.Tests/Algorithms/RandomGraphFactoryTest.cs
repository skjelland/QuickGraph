using Microsoft.Pex.Framework;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using QuickGraph;
using QuickGraph.Algorithms;
using System;
using System.Collections.Generic;

namespace QuickGraph.Algorithms
{
    /// <summary>
    /// This class contains parameterized unit tests for RandomGraphFactory
    /// </summary>
    [TestClass]
    [PexClass(typeof(RandomGraphFactory))]
    public partial class RandomGraphFactoryTest
    {
        [PexMethod]
        public void GetEdge<TVertex,TEdge>(IEdgeSet<TVertex, TEdge> g, Random rnd)
            where TEdge : IEdge<TVertex>
        {
            TEdge result = RandomGraphFactory.GetEdge<TVertex, TEdge>(g, rnd);
            PexStore.ValueForValidation<TEdge>("result", result);
            // TODO: add assertions to method RandomGraphFactoryTest.GetEdge(IEdgeSet`2<!!0,!!1>, Random)
        }
        
        [PexMethod]
        public void GetEdge01<TVertex,TEdge>(
            IEnumerable<TEdge> edges,
            int count,
            Random rnd
        )
            where TEdge : IEdge<TVertex>
        {
            TEdge result = RandomGraphFactory.GetEdge<TVertex, TEdge>(edges, count, rnd);
            PexStore.ValueForValidation<TEdge>("result", result);
            // TODO: add assertions to method RandomGraphFactoryTest.GetEdge01(IEnumerable`1<!!1>, Int32, Random)
        }
        
        [PexMethod]
        public void GetVertex<TVertex,TEdge>(IVertexListGraph<TVertex, TEdge> g, Random rnd)
            where TEdge : IEdge<TVertex>
        {
            TVertex result = RandomGraphFactory.GetVertex<TVertex, TEdge>(g, rnd);
            PexStore.ValueForValidation<TVertex>("result", result);
            // TODO: add assertions to method RandomGraphFactoryTest.GetVertex(IVertexListGraph`2<!!0,!!1>, Random)
        }
        
        [PexMethod]
        public void GetVertex01<TVertex,TEdge>(
            IEnumerable<TVertex> vertices,
            int count,
            Random rnd
        )
            where TEdge : IEdge<TVertex>
        {
            TVertex result
               = RandomGraphFactory.GetVertex<TVertex, TEdge>(vertices, count, rnd);
            PexStore.ValueForValidation<TVertex>("result", result);
            // TODO: add assertions to method RandomGraphFactoryTest.GetVertex01(IEnumerable`1<!!0>, Int32, Random)
        }
        
    }
}
