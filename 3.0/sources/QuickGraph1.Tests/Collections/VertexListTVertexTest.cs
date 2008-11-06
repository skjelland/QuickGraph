using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Wizard;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using QuickGraph.Collections;
using System;
using System.Collections;
using System.Collections.Generic;

namespace QuickGraph.Collections
{
    /// <summary>
    /// This class contains parameterized unit tests for VertexList`1
    /// </summary>
    [TestClass]
    [PexClass(typeof(VertexList<>))]
    public partial class VertexListTVertexTest
    {
        [PexMethod]
        [PexGenericArguments(new Type[]{typeof(int)})]
        public void Clone<TVertex>([PexAssumeUnderTest]VertexList<TVertex> target)
        {
            VertexList<TVertex> result = target.Clone();
            PexStore.ValueForValidation<VertexList<TVertex>>("result", result);
            PexEnumerablePatterns.ForEach<TVertex>((IEnumerable<TVertex>)result);
            PexEnumerablePatterns.ForEach((IEnumerable)result);
            PexEnumerablePatterns.DoubleForEach<TVertex>((IEnumerable<TVertex>)result);
            PexEnumerablePatterns.MoveNextAndReset<TVertex>((IEnumerable<TVertex>)result);
            // TODO: add assertions to method VertexListTVertexTest.Clone(VertexList`1<!!0>)
        }
        
        [PexMethod]
        [PexGenericArguments(new Type[]{typeof(int)})]
        public VertexList<TVertex> Constructor<TVertex>()
        {
            VertexList<TVertex> target = new VertexList<TVertex>();
            PexEnumerablePatterns.ForEach<TVertex>((IEnumerable<TVertex>)target);
            PexEnumerablePatterns.ForEach((IEnumerable)target);
            PexEnumerablePatterns.DoubleForEach<TVertex>((IEnumerable<TVertex>)target);
            PexEnumerablePatterns.MoveNextAndReset<TVertex>((IEnumerable<TVertex>)target);
            return target;
            // TODO: add assertions to method VertexListTVertexTest.Constructor()
        }
        
        [PexMethod]
        [PexGenericArguments(new Type[]{typeof(int)})]
        public VertexList<TVertex> Constructor01<TVertex>(int capacity)
        {
            VertexList<TVertex> target = new VertexList<TVertex>(capacity);
            PexEnumerablePatterns.ForEach<TVertex>((IEnumerable<TVertex>)target);
            PexEnumerablePatterns.ForEach((IEnumerable)target);
            PexEnumerablePatterns.DoubleForEach<TVertex>((IEnumerable<TVertex>)target);
            PexEnumerablePatterns.MoveNextAndReset<TVertex>((IEnumerable<TVertex>)target);
            return target;
            // TODO: add assertions to method VertexListTVertexTest.Constructor01(Int32)
        }
        
        [PexMethod]
        [PexGenericArguments(new Type[]{typeof(int)})]
        public VertexList<TVertex> Constructor02<TVertex>(VertexList<TVertex> other)
        {
            VertexList<TVertex> target = new VertexList<TVertex>(other);
            PexEnumerablePatterns.ForEach<TVertex>((IEnumerable<TVertex>)target);
            PexEnumerablePatterns.ForEach((IEnumerable)target);
            PexEnumerablePatterns.DoubleForEach<TVertex>((IEnumerable<TVertex>)target);
            PexEnumerablePatterns.MoveNextAndReset<TVertex>((IEnumerable<TVertex>)target);
            return target;
            // TODO: add assertions to method VertexListTVertexTest.Constructor02(VertexList`1<!!0>)
        }
        
    }
}
