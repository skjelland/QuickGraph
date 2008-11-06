using Microsoft.Pex.Framework;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using QuickGraph;
using System;
using System.Collections.Generic;

namespace QuickGraph
{
    /// <summary>
    /// This class contains parameterized unit tests for EnumerableContract
    /// </summary>
    [TestClass]
    [PexClass(typeof(EnumerableContract))]
    public partial class EnumerableContractTest
    {
        [PexMethod]
        [PexGenericArguments(new Type[]{typeof(int)})]
        public void RequiresElementsNotNull<T>(IEnumerable<T> elements)
        {
            EnumerableContract.RequiresElementsNotNull<T>(elements);
            // TODO: add assertions to method EnumerableContractTest.RequiresElementsNotNull(IEnumerable`1<!!0>)
        }
        
    }
}
