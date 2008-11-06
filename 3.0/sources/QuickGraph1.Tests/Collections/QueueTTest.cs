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
    /// This class contains parameterized unit tests for Queue`1
    /// </summary>
    [TestClass]
    [PexClass(typeof(Queue<>))]
    public partial class QueueTTest
    {
        [PexMethod]
        [PexGenericArguments(new Type[]{typeof(int)})]
        public Queue<T> Constructor<T>()
        {
            Queue<T> target = new Queue<T>();
            PexEnumerablePatterns.ForEach<T>((IEnumerable<T>)target);
            PexEnumerablePatterns.ForEach((IEnumerable)target);
            PexEnumerablePatterns.DoubleForEach<T>((IEnumerable<T>)target);
            PexEnumerablePatterns.MoveNextAndReset<T>((IEnumerable<T>)target);
            return target;
            // TODO: add assertions to method QueueTTest.Constructor()
        }
        
    }
}
