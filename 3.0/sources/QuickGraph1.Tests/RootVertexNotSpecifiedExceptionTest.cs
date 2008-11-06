using Microsoft.Pex.Framework;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using QuickGraph;
using System;

namespace QuickGraph
{
    /// <summary>
    /// This class contains parameterized unit tests for RootVertexNotSpecifiedException
    /// </summary>
    [TestClass]
    [PexClass(typeof(RootVertexNotSpecifiedException))]
    public partial class RootVertexNotSpecifiedExceptionTest
    {
        [PexMethod]
        public RootVertexNotSpecifiedException Constructor()
        {
            RootVertexNotSpecifiedException target = new RootVertexNotSpecifiedException();
            return target;
            // TODO: add assertions to method RootVertexNotSpecifiedExceptionTest.Constructor()
        }
        
        [PexMethod]
        public RootVertexNotSpecifiedException Constructor01(string message)
        {
            RootVertexNotSpecifiedException target
               = new RootVertexNotSpecifiedException(message);
            return target;
            // TODO: add assertions to method RootVertexNotSpecifiedExceptionTest.Constructor01(String)
        }
        
        [PexMethod]
        public RootVertexNotSpecifiedException Constructor02(string message, Exception inner)
        {
            RootVertexNotSpecifiedException target
               = new RootVertexNotSpecifiedException(message, inner);
            return target;
            // TODO: add assertions to method RootVertexNotSpecifiedExceptionTest.Constructor02(String, Exception)
        }
        
    }
}
