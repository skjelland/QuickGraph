using Microsoft.Pex.Framework;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using QuickGraph;
using QuickGraph.Predicates;
using System.Collections.Generic;

namespace QuickGraph.Predicates
{
    /// <summary>
    /// This class contains parameterized unit tests for FilteredIncidenceGraph`3
    /// </summary>
    [TestClass]
    [PexClass(typeof(FilteredIncidenceGraph<, , >))]
    public partial class FilteredIncidenceGraphTVertexTEdgeTGraphTest
    {
        [PexMethod]
        public bool ContainsEdge<TVertex,TEdge,TGraph>(
            [PexAssumeUnderTest]FilteredIncidenceGraph<TVertex, TEdge, TGraph> target01,
            TVertex source,
            TVertex target
        )
            where TEdge : IEdge<TVertex>
            where TGraph : IIncidenceGraph<TVertex, TEdge>
        {
            bool result = target01.ContainsEdge(source, target);
            return result;
            // TODO: add assertions to method FilteredIncidenceGraphTVertexTEdgeTGraphTest.ContainsEdge(FilteredIncidenceGraph`3<!!0,!!1,!!2>, !!0, !!0)
        }
        
        [PexMethod]
        public bool TryGetEdge<TVertex,TEdge,TGraph>(
            [PexAssumeUnderTest]FilteredIncidenceGraph<TVertex, TEdge, TGraph> target01,
            TVertex source,
            TVertex target,
            out TEdge edge
        )
            where TEdge : IEdge<TVertex>
            where TGraph : IIncidenceGraph<TVertex, TEdge>
        {
            bool result = target01.TryGetEdge(source, target, out edge);
            return result;
            // TODO: add assertions to method FilteredIncidenceGraphTVertexTEdgeTGraphTest.TryGetEdge(FilteredIncidenceGraph`3<!!0,!!1,!!2>, !!0, !!0, !!1&)
        }
        
        [PexMethod]
        public bool TryGetEdges<TVertex,TEdge,TGraph>(
            [PexAssumeUnderTest]FilteredIncidenceGraph<TVertex, TEdge, TGraph> target01,
            TVertex source,
            TVertex target,
            out IEnumerable<TEdge> edges
        )
            where TEdge : IEdge<TVertex>
            where TGraph : IIncidenceGraph<TVertex, TEdge>
        {
            bool result = target01.TryGetEdges(source, target, out edges);
            return result;
            // TODO: add assertions to method FilteredIncidenceGraphTVertexTEdgeTGraphTest.TryGetEdges(FilteredIncidenceGraph`3<!!0,!!1,!!2>, !!0, !!0, IEnumerable`1<!!1>&)
        }
        
    }
}
