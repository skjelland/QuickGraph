using Microsoft.Pex.Framework;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using QuickGraph.Predicates;
using System;

namespace QuickGraph.Predicates
{
    /// <summary>
    /// This class contains parameterized unit tests for AnyVertexPredicate`1
    /// </summary>
    [TestClass]
    [PexClass(typeof(AnyVertexPredicate<>))]
    public partial class AnyVertexPredicateTVertexTest
    {
        [PexMethod]
        [PexGenericArguments(new Type[]{typeof(int)})]
        public AnyVertexPredicate<TVertex> Constructor<TVertex>()
        {
            AnyVertexPredicate<TVertex> target = new AnyVertexPredicate<TVertex>();
            return target;
            // TODO: add assertions to method AnyVertexPredicateTVertexTest.Constructor()
        }
        
        [PexMethod]
        [PexGenericArguments(new Type[]{typeof(int)})]
        public bool Test<TVertex>(
            [PexAssumeUnderTest]AnyVertexPredicate<TVertex> target,
            TVertex vertex
        )
        {
            bool result = target.Test(vertex);
            return result;
            // TODO: add assertions to method AnyVertexPredicateTVertexTest.Test(AnyVertexPredicate`1<!!0>, !!0)
        }
        
    }
}
