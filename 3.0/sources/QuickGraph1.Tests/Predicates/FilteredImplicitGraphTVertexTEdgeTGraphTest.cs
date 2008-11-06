using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Wizard;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using QuickGraph;
using QuickGraph.Predicates;
using System.Collections;
using System.Collections.Generic;

namespace QuickGraph.Predicates
{
    /// <summary>
    /// This class contains parameterized unit tests for FilteredImplicitGraph`3
    /// </summary>
    [TestClass]
    [PexClass(typeof(FilteredImplicitGraph<, , >))]
    public partial class FilteredImplicitGraphTVertexTEdgeTGraphTest
    {
        [PexMethod]
        public bool IsOutEdgesEmpty<TVertex,TEdge,TGraph>(
            [PexAssumeUnderTest]FilteredImplicitGraph<TVertex, TEdge, TGraph> target,
            TVertex v
        )
            where TEdge : IEdge<TVertex>
            where TGraph : IImplicitGraph<TVertex, TEdge>
        {
            bool result = target.IsOutEdgesEmpty(v);
            return result;
            // TODO: add assertions to method FilteredImplicitGraphTVertexTEdgeTGraphTest.IsOutEdgesEmpty(FilteredImplicitGraph`3<!!0,!!1,!!2>, !!0)
        }
        
        [PexMethod]
        public int OutDegree<TVertex,TEdge,TGraph>(
            [PexAssumeUnderTest]FilteredImplicitGraph<TVertex, TEdge, TGraph> target,
            TVertex v
        )
            where TEdge : IEdge<TVertex>
            where TGraph : IImplicitGraph<TVertex, TEdge>
        {
            int result = target.OutDegree(v);
            return result;
            // TODO: add assertions to method FilteredImplicitGraphTVertexTEdgeTGraphTest.OutDegree(FilteredImplicitGraph`3<!!0,!!1,!!2>, !!0)
        }
        
        [PexMethod]
        public void OutEdge<TVertex,TEdge,TGraph>(
            [PexAssumeUnderTest]FilteredImplicitGraph<TVertex, TEdge, TGraph> target,
            TVertex v,
            int index
        )
            where TEdge : IEdge<TVertex>
            where TGraph : IImplicitGraph<TVertex, TEdge>
        {
            TEdge result = target.OutEdge(v, index);
            PexStore.ValueForValidation<TEdge>("result", result);
            // TODO: add assertions to method FilteredImplicitGraphTVertexTEdgeTGraphTest.OutEdge(FilteredImplicitGraph`3<!!0,!!1,!!2>, !!0, Int32)
        }
        
        [PexMethod]
        public void OutEdges<TVertex,TEdge,TGraph>(
            [PexAssumeUnderTest]FilteredImplicitGraph<TVertex, TEdge, TGraph> target,
            TVertex v
        )
            where TEdge : IEdge<TVertex>
            where TGraph : IImplicitGraph<TVertex, TEdge>
        {
            IEnumerable<TEdge> result = target.OutEdges(v);
            PexStore.ValueForValidation<IEnumerable<TEdge>>("result", result);
            PexEnumerablePatterns.ForEach<TEdge>(result);
            PexEnumerablePatterns.ForEach((IEnumerable)result);
            PexEnumerablePatterns.DoubleForEach<TEdge>(result);
            PexEnumerablePatterns.MoveNextAndReset<TEdge>(result);
            // TODO: add assertions to method FilteredImplicitGraphTVertexTEdgeTGraphTest.OutEdges(FilteredImplicitGraph`3<!!0,!!1,!!2>, !!0)
        }
        
    }
}
