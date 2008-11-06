using Microsoft.Pex.Framework;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using QuickGraph;
using QuickGraph.Algorithms.RandomWalks;

namespace QuickGraph.Algorithms.RandomWalks
{
    /// <summary>
    /// This class contains parameterized unit tests for NormalizedMarkovEdgeChain`2
    /// </summary>
    [TestClass]
    [PexClass(typeof(NormalizedMarkovEdgeChain<, >))]
    public partial class NormalizedMarkovEdgeChainTVertexTEdgeTest
    {
        [PexMethod]
        public NormalizedMarkovEdgeChain<TVertex, TEdge> Constructor<TVertex,TEdge>()
            where TEdge : IEdge<TVertex>
        {
            NormalizedMarkovEdgeChain<TVertex, TEdge> target
               = new NormalizedMarkovEdgeChain<TVertex, TEdge>();
            return target;
            // TODO: add assertions to method NormalizedMarkovEdgeChainTVertexTEdgeTest.Constructor()
        }
        
        [PexMethod]
        public void Successor<TVertex,TEdge>(
            [PexAssumeUnderTest]NormalizedMarkovEdgeChain<TVertex, TEdge> target,
            IImplicitGraph<TVertex, TEdge> g,
            TVertex u
        )
            where TEdge : IEdge<TVertex>
        {
            TEdge result = target.Successor(g, u);
            PexStore.ValueForValidation<TEdge>("result", result);
            // TODO: add assertions to method NormalizedMarkovEdgeChainTVertexTEdgeTest.Successor(NormalizedMarkovEdgeChain`2<!!0,!!1>, IImplicitGraph`2<!!0,!!1>, !!0)
        }
        
    }
}
