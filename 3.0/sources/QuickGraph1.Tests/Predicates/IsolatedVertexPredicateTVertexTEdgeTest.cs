using Microsoft.Pex.Framework;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using QuickGraph;
using QuickGraph.Predicates;

namespace QuickGraph.Predicates
{
    /// <summary>
    /// This class contains parameterized unit tests for IsolatedVertexPredicate`2
    /// </summary>
    [TestClass]
    [PexClass(typeof(IsolatedVertexPredicate<, >))]
    public partial class IsolatedVertexPredicateTVertexTEdgeTest
    {
        [PexMethod]
        public IsolatedVertexPredicate<TVertex, TEdge> Constructor<TVertex,TEdge>(IBidirectionalGraph<TVertex, TEdge> visitedGraph)
            where TEdge : IEdge<TVertex>
        {
            IsolatedVertexPredicate<TVertex, TEdge> target
               = new IsolatedVertexPredicate<TVertex, TEdge>(visitedGraph);
            return target;
            // TODO: add assertions to method IsolatedVertexPredicateTVertexTEdgeTest.Constructor(IBidirectionalGraph`2<!!0,!!1>)
        }
        
        [PexMethod]
        public bool Test<TVertex,TEdge>(
            [PexAssumeUnderTest]IsolatedVertexPredicate<TVertex, TEdge> target,
            TVertex v
        )
            where TEdge : IEdge<TVertex>
        {
            bool result = target.Test(v);
            return result;
            // TODO: add assertions to method IsolatedVertexPredicateTVertexTEdgeTest.Test(IsolatedVertexPredicate`2<!!0,!!1>, !!0)
        }
        
    }
}
