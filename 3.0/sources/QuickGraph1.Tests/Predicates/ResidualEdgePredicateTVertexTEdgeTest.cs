using Microsoft.Pex.Framework;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using QuickGraph;
using QuickGraph.Predicates;
using System.Collections.Generic;

namespace QuickGraph.Predicates
{
    /// <summary>
    /// This class contains parameterized unit tests for ResidualEdgePredicate`2
    /// </summary>
    [TestClass]
    [PexClass(typeof(ResidualEdgePredicate<, >))]
    public partial class ResidualEdgePredicateTVertexTEdgeTest
    {
        [PexMethod]
        public ResidualEdgePredicate<TVertex, TEdge> Constructor<TVertex,TEdge>(IDictionary<TEdge, double> residualCapacities)
            where TEdge : IEdge<TVertex>
        {
            ResidualEdgePredicate<TVertex, TEdge> target
               = new ResidualEdgePredicate<TVertex, TEdge>(residualCapacities);
            return target;
            // TODO: add assertions to method ResidualEdgePredicateTVertexTEdgeTest.Constructor(IDictionary`2<!!1,Double>)
        }
        
        [PexMethod]
        public void ResidualCapacitiesGet<TVertex,TEdge>([PexAssumeUnderTest]ResidualEdgePredicate<TVertex, TEdge> target)
            where TEdge : IEdge<TVertex>
        {
            IDictionary<TEdge, double> result = target.ResidualCapacities;
            PexStore.ValueForValidation<IDictionary<TEdge, double>>("result", result);
            // TODO: add assertions to method ResidualEdgePredicateTVertexTEdgeTest.ResidualCapacitiesGet(ResidualEdgePredicate`2<!!0,!!1>)
        }
        
        [PexMethod]
        public bool Test<TVertex,TEdge>(
            [PexAssumeUnderTest]ResidualEdgePredicate<TVertex, TEdge> target,
            TEdge e
        )
            where TEdge : IEdge<TVertex>
        {
            bool result = target.Test(e);
            return result;
            // TODO: add assertions to method ResidualEdgePredicateTVertexTEdgeTest.Test(ResidualEdgePredicate`2<!!0,!!1>, !!1)
        }
        
    }
}
