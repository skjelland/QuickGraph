using Microsoft.Pex.Framework;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using QuickGraph;
using System;

namespace QuickGraph
{
    /// <summary>
    /// This class contains parameterized unit tests for ParallelEdgeNotAllowedException
    /// </summary>
    [TestClass]
    [PexClass(typeof(ParallelEdgeNotAllowedException))]
    public partial class ParallelEdgeNotAllowedExceptionTest
    {
        [PexMethod]
        public ParallelEdgeNotAllowedException Constructor()
        {
            ParallelEdgeNotAllowedException target = new ParallelEdgeNotAllowedException();
            return target;
            // TODO: add assertions to method ParallelEdgeNotAllowedExceptionTest.Constructor()
        }
        
        [PexMethod]
        public ParallelEdgeNotAllowedException Constructor01(string message)
        {
            ParallelEdgeNotAllowedException target
               = new ParallelEdgeNotAllowedException(message);
            return target;
            // TODO: add assertions to method ParallelEdgeNotAllowedExceptionTest.Constructor01(String)
        }
        
        [PexMethod]
        public ParallelEdgeNotAllowedException Constructor02(string message, Exception inner)
        {
            ParallelEdgeNotAllowedException target
               = new ParallelEdgeNotAllowedException(message, inner);
            return target;
            // TODO: add assertions to method ParallelEdgeNotAllowedExceptionTest.Constructor02(String, Exception)
        }
        
    }
}
