using Microsoft.Pex.Framework;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using QuickGraph;

namespace QuickGraph
{
    /// <summary>
    /// This class contains parameterized unit tests for IdentifiableVertex
    /// </summary>
    [TestClass]
    [PexClass(typeof(IdentifiableVertex))]
    public partial class IdentifiableVertexTest
    {
        [PexMethod]
        public IdentifiableVertex Constructor(string id)
        {
            IdentifiableVertex target = new IdentifiableVertex(id);
            return target;
            // TODO: add assertions to method IdentifiableVertexTest.Constructor(String)
        }
        
        [PexMethod]
        public void IDGet([PexAssumeUnderTest]IdentifiableVertex target)
        {
            string result = target.ID;
            PexStore.ValueForValidation<string>("result", result);
            // TODO: add assertions to method IdentifiableVertexTest.IDGet(IdentifiableVertex)
        }
        
        [PexMethod]
        public string ToString([PexAssumeUnderTest]IdentifiableVertex target)
        {
            string result = target.ToString();
            return result;
            // TODO: add assertions to method IdentifiableVertexTest.ToString(IdentifiableVertex)
        }
        
    }
}
