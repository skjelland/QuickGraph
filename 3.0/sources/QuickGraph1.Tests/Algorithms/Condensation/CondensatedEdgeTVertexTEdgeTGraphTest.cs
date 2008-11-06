using Microsoft.Pex.Framework;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using QuickGraph;
using QuickGraph.Algorithms.Condensation;
using System.Collections.Generic;

namespace QuickGraph.Algorithms.Condensation
{
    /// <summary>
    /// This class contains parameterized unit tests for CondensatedEdge`3
    /// </summary>
    [TestClass]
    [PexClass(typeof(CondensatedEdge<, , >))]
    public partial class CondensatedEdgeTVertexTEdgeTGraphTest
    {
        [PexMethod]
        public CondensatedEdge<TVertex, TEdge, TGraph> Constructor<TVertex,TEdge,TGraph>(TGraph source, TGraph target)
            where TEdge : IEdge<TVertex>
            where TGraph : IMutableVertexAndEdgeListGraph<TVertex, TEdge>, new()
        {
            CondensatedEdge<TVertex, TEdge, TGraph> target01
               = new CondensatedEdge<TVertex, TEdge, TGraph>(source, target);
            return target01;
            // TODO: add assertions to method CondensatedEdgeTVertexTEdgeTGraphTest.Constructor(!!2, !!2)
        }
        
        [PexMethod]
        public void EdgesGet<TVertex,TEdge,TGraph>([PexAssumeUnderTest]CondensatedEdge<TVertex, TEdge, TGraph> target)
            where TEdge : IEdge<TVertex>
            where TGraph : IMutableVertexAndEdgeListGraph<TVertex, TEdge>, new()
        {
            IList<TEdge> result = target.Edges;
            PexStore.ValueForValidation<IList<TEdge>>("result", result);
            // TODO: add assertions to method CondensatedEdgeTVertexTEdgeTGraphTest.EdgesGet(CondensatedEdge`3<!!0,!!1,!!2>)
        }
        
    }
}
