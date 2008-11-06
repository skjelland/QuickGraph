using Microsoft.Pex.Framework;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using QuickGraph;
using QuickGraph.Predicates;

namespace QuickGraph.Predicates
{
    /// <summary>
    /// This class contains parameterized unit tests for AnyEdgePredicate`2
    /// </summary>
    [TestClass]
    [PexClass(typeof(AnyEdgePredicate<, >))]
    [PexGenericArguments(typeof(int), typeof(Edge<int>))]
    public partial class AnyEdgePredicateTVertexTEdgeTest
    {
        [PexMethod]
        public AnyEdgePredicate<TVertex, TEdge> Constructor<TVertex,TEdge>()
            where TEdge : IEdge<TVertex>
        {
            AnyEdgePredicate<TVertex, TEdge> target = new AnyEdgePredicate<TVertex, TEdge>()
              ;
            return target;
            // TODO: add assertions to method AnyEdgePredicateTVertexTEdgeTest.Constructor()
        }
        
        [PexMethod]
        public bool Test<TVertex,TEdge>(
            [PexAssumeUnderTest]AnyEdgePredicate<TVertex, TEdge> target,
            TEdge edge
        )
            where TEdge : IEdge<TVertex>
        {
            bool result = target.Test(edge);
            return result;
            // TODO: add assertions to method AnyEdgePredicateTVertexTEdgeTest.Test(AnyEdgePredicate`2<!!0,!!1>, !!1)
        }
        
    }
}
