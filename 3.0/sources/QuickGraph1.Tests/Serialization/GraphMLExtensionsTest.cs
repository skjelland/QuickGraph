using Microsoft.Pex.Framework;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using QuickGraph;
using QuickGraph.Serialization;
using System.Xml;

namespace QuickGraph.Serialization
{
    /// <summary>
    /// This class contains parameterized unit tests for GraphMLExtensions
    /// </summary>
    [TestClass]
    [PexClass(typeof(GraphMLExtensions))]
    [PexGenericArguments(typeof(int), typeof(Edge<int>))]
    public partial class GraphMLExtensionsTest
    {
        [PexMethod]
        public void SerializeToGraphML<TVertex,TEdge>(IVertexAndEdgeSet<TVertex, TEdge> graph, XmlWriter writer)
            where TVertex : IIdentifiable
            where TEdge : IIdentifiable, IEdge<TVertex>
        {
            GraphMLExtensions.SerializeToGraphML<TVertex, TEdge>(graph, writer);
            // TODO: add assertions to method GraphMLExtensionsTest.SerializeToGraphML(IVertexAndEdgeSet`2<!!0,!!1>, XmlWriter)
        }
        
    }
}
