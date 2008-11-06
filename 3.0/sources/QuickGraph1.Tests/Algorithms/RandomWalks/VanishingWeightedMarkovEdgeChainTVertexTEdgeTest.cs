using Microsoft.Pex.Framework;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using QuickGraph;
using QuickGraph.Algorithms.RandomWalks;
using System.Collections.Generic;

namespace QuickGraph.Algorithms.RandomWalks
{
    /// <summary>
    /// This class contains parameterized unit tests for VanishingWeightedMarkovEdgeChain`2
    /// </summary>
    [TestClass]
    [PexClass(typeof(VanishingWeightedMarkovEdgeChain<, >))]
    public partial class VanishingWeightedMarkovEdgeChainTVertexTEdgeTest
    {
        [PexMethod]
        public VanishingWeightedMarkovEdgeChain<TVertex, TEdge> Constructor<TVertex,TEdge>(IDictionary<TEdge, double> weights)
            where TEdge : IEdge<TVertex>
        {
            VanishingWeightedMarkovEdgeChain<TVertex, TEdge> target
               = new VanishingWeightedMarkovEdgeChain<TVertex, TEdge>(weights);
            return target;
            // TODO: add assertions to method VanishingWeightedMarkovEdgeChainTVertexTEdgeTest.Constructor(IDictionary`2<!!1,Double>)
        }
        
        [PexMethod]
        public VanishingWeightedMarkovEdgeChain<TVertex, TEdge> Constructor01<TVertex,TEdge>(IDictionary<TEdge, double> weights, double factor)
            where TEdge : IEdge<TVertex>
        {
            VanishingWeightedMarkovEdgeChain<TVertex, TEdge> target
               = new VanishingWeightedMarkovEdgeChain<TVertex, TEdge>(weights, factor);
            return target;
            // TODO: add assertions to method VanishingWeightedMarkovEdgeChainTVertexTEdgeTest.Constructor01(IDictionary`2<!!1,Double>, Double)
        }
        
        [PexMethod]
        public void FactorGetSet<TVertex,TEdge>(
            [PexAssumeUnderTest]VanishingWeightedMarkovEdgeChain<TVertex, TEdge> target,
            double value
        )
            where TEdge : IEdge<TVertex>
        {
            target.Factor = value;
            double result = target.Factor;
            PexStore.ValueForValidation<double>("result", result);
            PexAssert.AreEqual((object)value, (object)result);
            // TODO: add assertions to method VanishingWeightedMarkovEdgeChainTVertexTEdgeTest.FactorGetSet(VanishingWeightedMarkovEdgeChain`2<!!0,!!1>, Double)
        }
        
        [PexMethod]
        public void Successor<TVertex,TEdge>(
            [PexAssumeUnderTest]VanishingWeightedMarkovEdgeChain<TVertex, TEdge> target,
            IImplicitGraph<TVertex, TEdge> g,
            TVertex u
        )
            where TEdge : IEdge<TVertex>
        {
            TEdge result = target.Successor(g, u);
            PexStore.ValueForValidation<TEdge>("result", result);
            // TODO: add assertions to method VanishingWeightedMarkovEdgeChainTVertexTEdgeTest.Successor(VanishingWeightedMarkovEdgeChain`2<!!0,!!1>, IImplicitGraph`2<!!0,!!1>, !!0)
        }
        
    }
}
