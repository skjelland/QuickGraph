using Microsoft.Pex.Framework;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using QuickGraph;
using QuickGraph.Algorithms.RandomWalks;
using System;

namespace QuickGraph.Algorithms.RandomWalks
{
    /// <summary>
    /// This class contains parameterized unit tests for MarkovEdgeChainBase`2
    /// </summary>
    [TestClass]
    [PexClass(typeof(MarkovEdgeChainBase<, >))]
    public partial class MarkovEdgeChainBaseTVertexTEdgeTest
    {
        [PexMethod]
        public void RandGetSet<TVertex,TEdge>(
            [PexAssumeNotNull]MarkovEdgeChainBase<TVertex, TEdge> target,
            Random value
        )
            where TEdge : IEdge<TVertex>
        {
            target.Rand = value;
            Random result = target.Rand;
            PexStore.ValueForValidation<Random>("result", result);
            PexAssert.AreEqual((object)value, (object)result);
            // TODO: add assertions to method MarkovEdgeChainBaseTVertexTEdgeTest.RandGetSet(MarkovEdgeChainBase`2<!!0,!!1>, Random)
        }
        
        [PexMethod]
        public void Successor<TVertex,TEdge>(
            [PexAssumeNotNull]MarkovEdgeChainBase<TVertex, TEdge> target,
            IImplicitGraph<TVertex, TEdge> g,
            TVertex u
        )
            where TEdge : IEdge<TVertex>
        {
            TEdge result = target.Successor(g, u);
            PexStore.ValueForValidation<TEdge>("result", result);
            // TODO: add assertions to method MarkovEdgeChainBaseTVertexTEdgeTest.Successor(MarkovEdgeChainBase`2<!!0,!!1>, IImplicitGraph`2<!!0,!!1>, !!0)
        }
        
    }
}
