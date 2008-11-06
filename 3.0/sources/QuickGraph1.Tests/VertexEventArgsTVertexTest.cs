using Microsoft.Pex.Framework;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using QuickGraph;
using System;

namespace QuickGraph
{
    /// <summary>
    /// This class contains parameterized unit tests for VertexEventArgs`1
    /// </summary>
    [TestClass]
    [PexClass(typeof(VertexEventArgs<>))]
    public partial class VertexEventArgsTVertexTest
    {
        [PexMethod]
        [PexGenericArguments(new Type[]{typeof(int)})]
        public VertexEventArgs<TVertex> Constructor<TVertex>(TVertex vertex)
        {
            VertexEventArgs<TVertex> target = new VertexEventArgs<TVertex>(vertex);
            return target;
            // TODO: add assertions to method VertexEventArgsTVertexTest.Constructor(!!0)
        }
        
        [PexMethod]
        [PexGenericArguments(new Type[]{typeof(int)})]
        public void VertexGet<TVertex>([PexAssumeUnderTest]VertexEventArgs<TVertex> target)
        {
            TVertex result = target.Vertex;
            PexStore.ValueForValidation<TVertex>("result", result);
            // TODO: add assertions to method VertexEventArgsTVertexTest.VertexGet(VertexEventArgs`1<!!0>)
        }
        
    }
}
