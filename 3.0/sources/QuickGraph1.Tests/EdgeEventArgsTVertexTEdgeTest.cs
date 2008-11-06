using Microsoft.Pex.Framework;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using QuickGraph;

namespace QuickGraph
{
    /// <summary>
    /// This class contains parameterized unit tests for EdgeEventArgs`2
    /// </summary>
    [TestClass]
    [PexClass(typeof(EdgeEventArgs<, >))]
    [PexGenericArguments(typeof(int), typeof(Edge<int>))]
    public partial class EdgeEventArgsTVertexTEdgeTest
    {
        [PexMethod]
        public EdgeEventArgs<TVertex, TEdge> Constructor<TVertex,TEdge>(TEdge edge)
            where TEdge : IEdge<TVertex>
        {
            EdgeEventArgs<TVertex, TEdge> target = new EdgeEventArgs<TVertex, TEdge>(edge);
            return target;
            // TODO: add assertions to method EdgeEventArgsTVertexTEdgeTest.Constructor(!!1)
        }
        
        [PexMethod]
        public void EdgeGet<TVertex,TEdge>([PexAssumeUnderTest]EdgeEventArgs<TVertex, TEdge> target)
            where TEdge : IEdge<TVertex>
        {
            TEdge result = target.Edge;
            PexStore.ValueForValidation<TEdge>("result", result);
            // TODO: add assertions to method EdgeEventArgsTVertexTEdgeTest.EdgeGet(EdgeEventArgs`2<!!0,!!1>)
        }
        
    }
}
