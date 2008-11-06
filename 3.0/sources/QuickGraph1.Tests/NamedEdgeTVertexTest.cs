using Microsoft.Pex.Framework;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using QuickGraph;
using System;

namespace QuickGraph
{
    /// <summary>
    /// This class contains parameterized unit tests for NamedEdge`1
    /// </summary>
    [TestClass]
    [PexClass(typeof(NamedEdge<>))]
    public partial class NamedEdgeTVertexTest
    {
        [PexMethod]
        [PexGenericArguments(new Type[]{typeof(int)})]
        public NamedEdge<TVertex> Constructor<TVertex>(
            TVertex source,
            TVertex target,
            string name
        )
        {
            NamedEdge<TVertex> target01 = new NamedEdge<TVertex>(source, target, name);
            return target01;
            // TODO: add assertions to method NamedEdgeTVertexTest.Constructor(!!0, !!0, String)
        }
        
        [PexMethod]
        [PexGenericArguments(new Type[]{typeof(int)})]
        public void NameGet<TVertex>([PexAssumeUnderTest]NamedEdge<TVertex> target)
        {
            string result = target.Name;
            PexStore.ValueForValidation<string>("result", result);
            // TODO: add assertions to method NamedEdgeTVertexTest.NameGet(NamedEdge`1<!!0>)
        }
        
        [PexMethod]
        [PexGenericArguments(new Type[]{typeof(int)})]
        public string ToString<TVertex>([PexAssumeUnderTest]NamedEdge<TVertex> target)
        {
            string result = target.ToString();
            return result;
            // TODO: add assertions to method NamedEdgeTVertexTest.ToString(NamedEdge`1<!!0>)
        }
        
    }
}
