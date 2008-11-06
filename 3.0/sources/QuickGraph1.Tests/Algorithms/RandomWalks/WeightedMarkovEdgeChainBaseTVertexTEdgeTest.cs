using Microsoft.Pex.Framework;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using QuickGraph;
using QuickGraph.Algorithms.RandomWalks;
using System.Collections.Generic;

namespace QuickGraph.Algorithms.RandomWalks
{
    /// <summary>
    /// This class contains parameterized unit tests for WeightedMarkovEdgeChainBase`2
    /// </summary>
    [TestClass]
    [PexClass(typeof(WeightedMarkovEdgeChainBase<, >))]
    public partial class WeightedMarkovEdgeChainBaseTVertexTEdgeTest
    {
        [PexMethod]
        public void WeightsGetSet<TVertex,TEdge>(
            [PexAssumeNotNull]WeightedMarkovEdgeChainBase<TVertex, TEdge> target,
            IDictionary<TEdge, double> value
        )
            where TEdge : IEdge<TVertex>
        {
            target.Weights = value;
            IDictionary<TEdge, double> result = target.Weights;
            PexStore.ValueForValidation<IDictionary<TEdge, double>>("result", result);
            // TODO: add assertions to method WeightedMarkovEdgeChainBaseTVertexTEdgeTest.WeightsGetSet(WeightedMarkovEdgeChainBase`2<!!0,!!1>, IDictionary`2<!!1,Double>)
        }
        
    }
}
