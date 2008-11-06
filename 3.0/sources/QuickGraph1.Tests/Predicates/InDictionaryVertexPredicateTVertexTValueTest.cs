using Microsoft.Pex.Framework;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using QuickGraph.Predicates;
using System;
using System.Collections.Generic;

namespace QuickGraph.Predicates
{
    /// <summary>
    /// This class contains parameterized unit tests for InDictionaryVertexPredicate`2
    /// </summary>
    [TestClass]
    [PexClass(typeof(InDictionaryVertexPredicate<, >))]
    public partial class InDictionaryVertexPredicateTVertexTValueTest
    {
        [PexMethod]
        [PexGenericArguments(new Type[]{typeof(int), typeof(int)})]
        public InDictionaryVertexPredicate<TVertex, TValue> Constructor<TVertex,TValue>(IDictionary<TVertex, TValue> dictionary)
        {
            InDictionaryVertexPredicate<TVertex, TValue> target
               = new InDictionaryVertexPredicate<TVertex, TValue>(dictionary);
            return target;
            // TODO: add assertions to method InDictionaryVertexPredicateTVertexTValueTest.Constructor(IDictionary`2<!!0,!!1>)
        }
        
        [PexMethod]
        [PexGenericArguments(new Type[]{typeof(int), typeof(int)})]
        public bool Test<TVertex,TValue>(
            [PexAssumeUnderTest]InDictionaryVertexPredicate<TVertex, TValue> target,
            TVertex v
        )
        {
            bool result = target.Test(v);
            return result;
            // TODO: add assertions to method InDictionaryVertexPredicateTVertexTValueTest.Test(InDictionaryVertexPredicate`2<!!0,!!1>, !!0)
        }
        
    }
}
