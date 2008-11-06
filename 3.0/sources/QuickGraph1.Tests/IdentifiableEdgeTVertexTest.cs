using Microsoft.Pex.Framework;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using QuickGraph;
using System;

namespace QuickGraph
{
    /// <summary>
    /// This class contains parameterized unit tests for IdentifiableEdge`1
    /// </summary>
    [TestClass]
    [PexClass(typeof(IdentifiableEdge<>))]
    [PexGenericArguments(typeof(int))]
    public partial class IdentifiableEdgeTVertexTest
    {
        [PexMethod]
        [PexGenericArguments(new Type[]{typeof(int)})]
        public IdentifiableEdge<TVertex> Constructor<TVertex>(
            TVertex source,
            TVertex target,
            string id
        )
        {
            IdentifiableEdge<TVertex> target01
               = new IdentifiableEdge<TVertex>(source, target, id);
            return target01;
            // TODO: add assertions to method IdentifiableEdgeTVertexTest.Constructor(!!0, !!0, String)
        }
        
        [PexMethod]
        [PexGenericArguments(new Type[]{typeof(int)})]
        public void IDGet<TVertex>([PexAssumeUnderTest]IdentifiableEdge<TVertex> target)
        {
            string result = target.ID;
            PexStore.ValueForValidation<string>("result", result);
            // TODO: add assertions to method IdentifiableEdgeTVertexTest.IDGet(IdentifiableEdge`1<!!0>)
        }
        
        [PexMethod]
        [PexGenericArguments(new Type[]{typeof(int)})]
        public string ToString<TVertex>([PexAssumeUnderTest]IdentifiableEdge<TVertex> target)
        {
            string result = target.ToString();
            return result;
            // TODO: add assertions to method IdentifiableEdgeTVertexTest.ToString(IdentifiableEdge`1<!!0>)
        }
        
    }
}
