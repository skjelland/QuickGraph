using Microsoft.Pex.Framework;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using QuickGraph;
using QuickGraph.Serialization;

namespace QuickGraph.Serialization
{
    /// <summary>
    /// This class contains parameterized unit tests for SerializerBase`2
    /// </summary>
    [TestClass]
    [PexClass(typeof(SerializerBase<, >))]
    [PexGenericArguments(typeof(int), typeof(Edge<int>))]
    public partial class SerializerBaseTVertexTEdgeTest
    {
        [PexMethod]
        public void EmitDocumentDeclarationGetSet<TVertex,TEdge>(
            [PexAssumeNotNull]SerializerBase<TVertex, TEdge> target,
            bool value
        )
            where TEdge : IEdge<TVertex>
        {
            target.EmitDocumentDeclaration = value;
            bool result = target.EmitDocumentDeclaration;
            PexStore.ValueForValidation<bool>("result", result);
            PexAssert.AreEqual((object)value, (object)result);
            // TODO: add assertions to method SerializerBaseTVertexTEdgeTest.EmitDocumentDeclarationGetSet(SerializerBase`2<!!0,!!1>, Boolean)
        }
        
    }
}
