using Microsoft.Pex.Framework;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using QuickGraph;
using QuickGraph.Predicates;

namespace QuickGraph.Predicates
{
    /// <summary>
    /// This class contains parameterized unit tests for SinkVertexPredicate`2
    /// </summary>
    [TestClass]
    [PexClass(typeof(SinkVertexPredicate<, >))]
    public partial class SinkVertexPredicateTVertexTEdgeTest
    {
        [PexMethod]
        public SinkVertexPredicate<TVertex, TEdge> Constructor<TVertex,TEdge>(IIncidenceGraph<TVertex, TEdge> visitedGraph)
            where TEdge : IEdge<TVertex>
        {
            SinkVertexPredicate<TVertex, TEdge> target
               = new SinkVertexPredicate<TVertex, TEdge>(visitedGraph);
            return target;
            // TODO: add assertions to method SinkVertexPredicateTVertexTEdgeTest.Constructor(IIncidenceGraph`2<!!0,!!1>)
        }
        
        [PexMethod]
        public bool Test<TVertex,TEdge>(
            [PexAssumeUnderTest]SinkVertexPredicate<TVertex, TEdge> target,
            TVertex v
        )
            where TEdge : IEdge<TVertex>
        {
            bool result = target.Test(v);
            return result;
            // TODO: add assertions to method SinkVertexPredicateTVertexTEdgeTest.Test(SinkVertexPredicate`2<!!0,!!1>, !!0)
        }
        
    }
}
