using Microsoft.Pex.Framework;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using QuickGraph;
using QuickGraph.Algorithms.RandomWalks;

namespace QuickGraph.Algorithms.RandomWalks
{
    /// <summary>
    /// This class contains parameterized unit tests for RoundRobinEdgeChain`2
    /// </summary>
    [TestClass]
    [PexClass(typeof(RoundRobinEdgeChain<, >))]
    public partial class RoundRobinEdgeChainTVertexTEdgeTest
    {
        [PexMethod]
        public RoundRobinEdgeChain<TVertex, TEdge> Constructor<TVertex,TEdge>()
            where TEdge : IEdge<TVertex>
        {
            RoundRobinEdgeChain<TVertex, TEdge> target
               = new RoundRobinEdgeChain<TVertex, TEdge>();
            return target;
            // TODO: add assertions to method RoundRobinEdgeChainTVertexTEdgeTest.Constructor()
        }
        
        [PexMethod]
        public void Successor<TVertex,TEdge>(
            [PexAssumeUnderTest]RoundRobinEdgeChain<TVertex, TEdge> target,
            IImplicitGraph<TVertex, TEdge> g,
            TVertex u
        )
            where TEdge : IEdge<TVertex>
        {
            TEdge result = target.Successor(g, u);
            PexStore.ValueForValidation<TEdge>("result", result);
            // TODO: add assertions to method RoundRobinEdgeChainTVertexTEdgeTest.Successor(RoundRobinEdgeChain`2<!!0,!!1>, IImplicitGraph`2<!!0,!!1>, !!0)
        }
        
    }
}
