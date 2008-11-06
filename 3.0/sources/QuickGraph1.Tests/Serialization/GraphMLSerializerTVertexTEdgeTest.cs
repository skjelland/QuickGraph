using Microsoft.Pex.Framework;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using QuickGraph;
using QuickGraph.Serialization;
using System.Xml;

namespace QuickGraph.Serialization
{
    /// <summary>
    /// This class contains parameterized unit tests for GraphMLSerializer`2
    /// </summary>
    [TestClass]
    [PexClass(typeof(GraphMLSerializer<, >))]
    [PexGenericArguments(typeof(int), typeof(Edge<int>))]
    public partial class GraphMLSerializerTVertexTEdgeTest
    {
        [PexMethod]
        public GraphMLSerializer<TVertex, TEdge> Constructor<TVertex,TEdge>()
            where TVertex : IIdentifiable
            where TEdge : IIdentifiable, IEdge<TVertex>
        {
            GraphMLSerializer<TVertex, TEdge> target
               = new GraphMLSerializer<TVertex, TEdge>();
            return target;
            // TODO: add assertions to method GraphMLSerializerTVertexTEdgeTest.Constructor()
        }
        
        [PexMethod]
        public bool MoveNextData<TVertex,TEdge>(XmlReader reader)
            where TVertex : IIdentifiable
            where TEdge : IIdentifiable, IEdge<TVertex>
        {
            bool result = GraphMLSerializer<TVertex, TEdge>.MoveNextData(reader);
            return result;
            // TODO: add assertions to method GraphMLSerializerTVertexTEdgeTest.MoveNextData(XmlReader)
        }
        
        [PexMethod]
        public void Serialize<TVertex,TEdge>(
            [PexAssumeUnderTest]GraphMLSerializer<TVertex, TEdge> target,
            XmlWriter writer,
            IVertexAndEdgeSet<TVertex, TEdge> visitedGraph
        )
            where TVertex : IIdentifiable
            where TEdge : IIdentifiable, IEdge<TVertex>
        {
            target.Serialize(writer, visitedGraph);
            // TODO: add assertions to method GraphMLSerializerTVertexTEdgeTest.Serialize(GraphMLSerializer`2<!!0,!!1>, XmlWriter, IVertexAndEdgeSet`2<!!0,!!1>)
        }
        
    }
}
