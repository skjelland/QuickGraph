using Microsoft.Pex.Framework;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using QuickGraph;
using QuickGraph.Algorithms.Condensation;

namespace QuickGraph.Algorithms.Condensation
{
    /// <summary>
    /// This class contains parameterized unit tests for CondensationGraphAlgorithm`3
    /// </summary>
    [TestClass]
    [PexClass(typeof(CondensationGraphAlgorithm<, , >))]
    public partial class CondensationGraphAlgorithmTVertexTEdgeTGraphTest
    {
        [PexMethod]
        public void CondensatedGraphGet<TVertex,TEdge,TGraph>(
            [PexAssumeUnderTest]CondensationGraphAlgorithm<TVertex, TEdge, TGraph> target
        )
            where TEdge : IEdge<TVertex>
            where TGraph : IMutableVertexAndEdgeListGraph<TVertex, TEdge>, new()
        {
            IMutableBidirectionalGraph<TGraph, CondensatedEdge<TVertex, TEdge, TGraph>> 
              result = target.CondensatedGraph;
            PexStore.ValueForValidation<IMutableBidirectionalGraph
                <TGraph, CondensatedEdge<TVertex, TEdge, TGraph>>>("result", result);
            // TODO: add assertions to method CondensationGraphAlgorithmTVertexTEdgeTGraphTest.CondensatedGraphGet(CondensationGraphAlgorithm`3<!!0,!!1,!!2>)
        }
        
        [PexMethod]
        public CondensationGraphAlgorithm<TVertex, TEdge, TGraph> Constructor<TVertex,TEdge,TGraph>(IVertexAndEdgeListGraph<TVertex, TEdge> visitedGraph)
            where TEdge : IEdge<TVertex>
            where TGraph : IMutableVertexAndEdgeListGraph<TVertex, TEdge>, new()
        {
            CondensationGraphAlgorithm<TVertex, TEdge, TGraph> target
               = new CondensationGraphAlgorithm<TVertex, TEdge, TGraph>(visitedGraph);
            return target;
            // TODO: add assertions to method CondensationGraphAlgorithmTVertexTEdgeTGraphTest.Constructor(IVertexAndEdgeListGraph`2<!!0,!!1>)
        }
        
        [PexMethod]
        public void StronglyConnectedGetSet<TVertex,TEdge,TGraph>(
            [PexAssumeUnderTest]CondensationGraphAlgorithm<TVertex, TEdge, TGraph> target,
            bool value
        )
            where TEdge : IEdge<TVertex>
            where TGraph : IMutableVertexAndEdgeListGraph<TVertex, TEdge>, new()
        {
            target.StronglyConnected = value;
            bool result = target.StronglyConnected;
            PexStore.ValueForValidation<bool>("result", result);
            PexAssert.AreEqual((object)value, (object)result);
            // TODO: add assertions to method CondensationGraphAlgorithmTVertexTEdgeTGraphTest.StronglyConnectedGetSet(CondensationGraphAlgorithm`3<!!0,!!1,!!2>, Boolean)
        }
        
    }
}
