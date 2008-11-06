using Microsoft.Pex.Framework;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using QuickGraph;
using QuickGraph.Predicates;
using System.Collections.Generic;

namespace QuickGraph.Predicates
{
    /// <summary>
    /// This class contains parameterized unit tests for ReversedResidualEdgePredicate`2
    /// </summary>
    [TestClass]
    [PexClass(typeof(ReversedResidualEdgePredicate<, >))]
    public partial class ReversedResidualEdgePredicateTVertexTEdgeTest
    {
        [PexMethod]
        public ReversedResidualEdgePredicate<TVertex, TEdge> Constructor<TVertex,TEdge>(
            IDictionary<TEdge, double> residualCapacities,
            IDictionary<TEdge, TEdge> reversedEdges
        )
            where TEdge : IEdge<TVertex>
        {
            ReversedResidualEdgePredicate<TVertex, TEdge> target
               = new ReversedResidualEdgePredicate<TVertex, TEdge>
                  (residualCapacities, reversedEdges);
            return target;
            // TODO: add assertions to method ReversedResidualEdgePredicateTVertexTEdgeTest.Constructor(IDictionary`2<!!1,Double>, IDictionary`2<!!1,!!1>)
        }
        
        [PexMethod]
        public void ResidualCapacitiesGet<TVertex,TEdge>(
            [PexAssumeUnderTest]ReversedResidualEdgePredicate<TVertex, TEdge> target
        )
            where TEdge : IEdge<TVertex>
        {
            IDictionary<TEdge, double> result = target.ResidualCapacities;
            PexStore.ValueForValidation<IDictionary<TEdge, double>>("result", result);
            // TODO: add assertions to method ReversedResidualEdgePredicateTVertexTEdgeTest.ResidualCapacitiesGet(ReversedResidualEdgePredicate`2<!!0,!!1>)
        }
        
        [PexMethod]
        public void ReversedEdgesGet<TVertex,TEdge>(
            [PexAssumeUnderTest]ReversedResidualEdgePredicate<TVertex, TEdge> target
        )
            where TEdge : IEdge<TVertex>
        {
            IDictionary<TEdge, TEdge> result = target.ReversedEdges;
            PexStore.ValueForValidation<IDictionary<TEdge, TEdge>>("result", result);
            // TODO: add assertions to method ReversedResidualEdgePredicateTVertexTEdgeTest.ReversedEdgesGet(ReversedResidualEdgePredicate`2<!!0,!!1>)
        }
        
        [PexMethod]
        public bool Test<TVertex,TEdge>(
            [PexAssumeUnderTest]ReversedResidualEdgePredicate<TVertex, TEdge> target,
            TEdge e
        )
            where TEdge : IEdge<TVertex>
        {
            bool result = target.Test(e);
            return result;
            // TODO: add assertions to method ReversedResidualEdgePredicateTVertexTEdgeTest.Test(ReversedResidualEdgePredicate`2<!!0,!!1>, !!1)
        }
        
    }
}
