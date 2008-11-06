using Microsoft.Pex.Framework;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using QuickGraph;
using QuickGraph.Algorithms.RandomWalks;
using System.Collections.Generic;

namespace QuickGraph.Algorithms.RandomWalks
{
    /// <summary>
    /// This class contains parameterized unit tests for WeightedMarkovEdgeChain`2
    /// </summary>
    [TestClass]
    [PexClass(typeof(WeightedMarkovEdgeChain<, >))]
    public partial class WeightedMarkovEdgeChainTVertexTEdgeTest
    {
        [PexMethod]
        public WeightedMarkovEdgeChain<TVertex, TEdge> Constructor<TVertex,TEdge>(IDictionary<TEdge, double> weights)
            where TEdge : IEdge<TVertex>
        {
            WeightedMarkovEdgeChain<TVertex, TEdge> target
               = new WeightedMarkovEdgeChain<TVertex, TEdge>(weights);
            return target;
            // TODO: add assertions to method WeightedMarkovEdgeChainTVertexTEdgeTest.Constructor(IDictionary`2<!!1,Double>)
        }
        
        [PexMethod]
        public void Successor<TVertex,TEdge>(
            [PexAssumeUnderTest]WeightedMarkovEdgeChain<TVertex, TEdge> target,
            IImplicitGraph<TVertex, TEdge> g,
            TVertex u
        )
            where TEdge : IEdge<TVertex>
        {
            TEdge result = target.Successor(g, u);
            PexStore.ValueForValidation<TEdge>("result", result);
            // TODO: add assertions to method WeightedMarkovEdgeChainTVertexTEdgeTest.Successor(WeightedMarkovEdgeChain`2<!!0,!!1>, IImplicitGraph`2<!!0,!!1>, !!0)
        }
        
    }
}
