using Microsoft.Pex.Framework;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using QuickGraph;
using QuickGraph.Serialization;
using System.IO;

namespace QuickGraph.Serialization
{
    /// <summary>
    /// This class contains parameterized unit tests for SerializationExtensions
    /// </summary>
    [TestClass]
    [PexClass(typeof(SerializationExtensions))]
    public partial class SerializationExtensionsTest
    {
        [PexMethod]
        public void DeserializeFromBinary<TVertex,TEdge,TGraph>(Stream stream)
            where TEdge : IEdge<TVertex>
            where TGraph : IGraph<TVertex, TEdge>
        {
            TGraph result
               = SerializationExtensions.DeserializeFromBinary<TVertex, TEdge, TGraph>
                  (stream);
            PexStore.ValueForValidation<TGraph>("result", result);
            // TODO: add assertions to method SerializationExtensionsTest.DeserializeFromBinary(Stream)
        }
        
        [PexMethod]
        [PexGenericArguments(typeof(int), typeof(Edge<int>))]
        public void SerializeToBinary<TVertex, TEdge>(IGraph<TVertex, TEdge> graph, Stream stream)
            where TEdge : IEdge<TVertex>
        {
            SerializationExtensions.SerializeToBinary<TVertex, TEdge>(graph, stream);
            // TODO: add assertions to method SerializationExtensionsTest.SerializeToBinary(IGraph`2<!!0,!!1>, Stream)
        }
        
    }
}
