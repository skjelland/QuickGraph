using Microsoft.Pex.Framework;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using QuickGraph;
using System;

namespace QuickGraph
{
    /// <summary>
    /// This class contains parameterized unit tests for Edge`1
    /// </summary>
    [TestClass]
    [PexClass(typeof(Edge<>))]
    public partial class EdgeTVertexTest
    {
        [PexMethod]
        [PexGenericArguments(new Type[]{typeof(int)})]
        public Edge<TVertex> Constructor<TVertex>(TVertex source, TVertex target)
        {
            Edge<TVertex> target01 = new Edge<TVertex>(source, target);
            return target01;
            // TODO: add assertions to method EdgeTVertexTest.Constructor(!!0, !!0)
        }
        
        [PexMethod]
        [PexGenericArguments(new Type[]{typeof(int)})]
        public void SourceGet<TVertex>([PexAssumeUnderTest]Edge<TVertex> target)
        {
            TVertex result = target.Source;
            PexStore.ValueForValidation<TVertex>("result", result);
            // TODO: add assertions to method EdgeTVertexTest.SourceGet(Edge`1<!!0>)
        }
        
        [PexMethod]
        [PexGenericArguments(new Type[]{typeof(int)})]
        public void TargetGet<TVertex>([PexAssumeUnderTest]Edge<TVertex> target)
        {
            TVertex result = target.Target;
            PexStore.ValueForValidation<TVertex>("result", result);
            // TODO: add assertions to method EdgeTVertexTest.TargetGet(Edge`1<!!0>)
        }
        
        [PexMethod]
        [PexGenericArguments(new Type[]{typeof(int)})]
        public string ToString<TVertex>([PexAssumeUnderTest]Edge<TVertex> target)
        {
            string result = target.ToString();
            return result;
            // TODO: add assertions to method EdgeTVertexTest.ToString(Edge`1<!!0>)
        }
        
        [PexMethod]
        [PexGenericArguments(new Type[]{typeof(int)})]
        public void VertexTypeGet<TVertex>()
        {
            Type result = Edge<TVertex>.VertexType;
            PexStore.ValueForValidation<Type>("result", result);
            // TODO: add assertions to method EdgeTVertexTest.VertexTypeGet()
        }
        
    }
}
