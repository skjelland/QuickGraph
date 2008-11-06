using Microsoft.Pex.Framework;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using QuickGraph;

namespace QuickGraph
{
    /// <summary>
    /// This class contains parameterized unit tests for EdgeEdgeEventArgs`2
    /// </summary>
    [TestClass]
    [PexClass(typeof(EdgeEdgeEventArgs<, >))]
    [PexGenericArguments(typeof(int), typeof(Edge<int>))]
    public partial class EdgeEdgeEventArgsTVertexTEdgeTest
    {
        [PexMethod]
        public EdgeEdgeEventArgs<TVertex, TEdge> Constructor<TVertex,TEdge>(TEdge edge, TEdge targetEdge)
            where TEdge : IEdge<TVertex>
        {
            EdgeEdgeEventArgs<TVertex, TEdge> target
               = new EdgeEdgeEventArgs<TVertex, TEdge>(edge, targetEdge);
            return target;
            // TODO: add assertions to method EdgeEdgeEventArgsTVertexTEdgeTest.Constructor(!!1, !!1)
        }
        
        [PexMethod]
        public void TargetEdgeGet<TVertex,TEdge>([PexAssumeUnderTest]EdgeEdgeEventArgs<TVertex, TEdge> target)
            where TEdge : IEdge<TVertex>
        {
            TEdge result = target.TargetEdge;
            PexStore.ValueForValidation<TEdge>("result", result);
            // TODO: add assertions to method EdgeEdgeEventArgsTVertexTEdgeTest.TargetEdgeGet(EdgeEdgeEventArgs`2<!!0,!!1>)
        }
        
    }
}
