using Microsoft.Pex.Framework;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using QuickGraph;
using System;

namespace QuickGraph
{
    /// <summary>
    /// This class contains parameterized unit tests for NonAcyclicGraphException
    /// </summary>
    [TestClass]
    [PexClass(typeof(NonAcyclicGraphException))]
    public partial class NonAcyclicGraphExceptionTest
    {
        [PexMethod]
        public NonAcyclicGraphException Constructor()
        {
            NonAcyclicGraphException target = new NonAcyclicGraphException();
            return target;
            // TODO: add assertions to method NonAcyclicGraphExceptionTest.Constructor()
        }
        
        [PexMethod]
        public NonAcyclicGraphException Constructor01(string message)
        {
            NonAcyclicGraphException target = new NonAcyclicGraphException(message);
            return target;
            // TODO: add assertions to method NonAcyclicGraphExceptionTest.Constructor01(String)
        }
        
        [PexMethod]
        public NonAcyclicGraphException Constructor02(string message, Exception inner)
        {
            NonAcyclicGraphException target = new NonAcyclicGraphException(message, inner);
            return target;
            // TODO: add assertions to method NonAcyclicGraphExceptionTest.Constructor02(String, Exception)
        }
        
    }
}
