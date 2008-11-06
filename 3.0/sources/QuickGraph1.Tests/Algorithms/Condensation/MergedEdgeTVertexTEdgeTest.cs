using Microsoft.Pex.Framework;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using QuickGraph;
using QuickGraph.Algorithms.Condensation;
using System.Collections.Generic;

namespace QuickGraph.Algorithms.Condensation
{
    /// <summary>
    /// This class contains parameterized unit tests for MergedEdge`2
    /// </summary>
    [TestClass]
    [PexClass(typeof(MergedEdge<, >))]
    public partial class MergedEdgeTVertexTEdgeTest
    {
        [PexMethod]
        public MergedEdge<TVertex, TEdge> Constructor<TVertex,TEdge>(TVertex source, TVertex target)
            where TEdge : IEdge<TVertex>
        {
            MergedEdge<TVertex, TEdge> target01
               = new MergedEdge<TVertex, TEdge>(source, target);
            return target01;
            // TODO: add assertions to method MergedEdgeTVertexTEdgeTest.Constructor(!!0, !!0)
        }
        
        [PexMethod]
        public void EdgesGet<TVertex,TEdge>([PexAssumeUnderTest]MergedEdge<TVertex, TEdge> target)
            where TEdge : IEdge<TVertex>
        {
            IList<TEdge> result = target.Edges;
            PexStore.ValueForValidation<IList<TEdge>>("result", result);
            // TODO: add assertions to method MergedEdgeTVertexTEdgeTest.EdgesGet(MergedEdge`2<!!0,!!1>)
        }
        
        [PexMethod]
        public void Merge<TVertex,TEdge>(MergedEdge<TVertex, TEdge> inEdge, MergedEdge<TVertex, TEdge> outEdge)
            where TEdge : IEdge<TVertex>
        {
            MergedEdge<TVertex, TEdge> result
               = MergedEdge<TVertex, TEdge>.Merge(inEdge, outEdge);
            PexStore.ValueForValidation<MergedEdge<TVertex, TEdge>>("result", result);
            // TODO: add assertions to method MergedEdgeTVertexTEdgeTest.Merge(MergedEdge`2<!!0,!!1>, MergedEdge`2<!!0,!!1>)
        }
        
    }
}
