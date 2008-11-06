using Microsoft.Pex.Framework;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using QuickGraph;
using System;

namespace QuickGraph
{
    /// <summary>
    /// This class contains parameterized unit tests for NotStronglyConnectedGraphException
    /// </summary>
    [TestClass]
    [PexClass(typeof(NotStronglyConnectedGraphException))]
    public partial class NotStronglyConnectedGraphExceptionTest
    {
        [PexMethod]
        public NotStronglyConnectedGraphException Constructor()
        {
            NotStronglyConnectedGraphException target
               = new NotStronglyConnectedGraphException();
            return target;
            // TODO: add assertions to method NotStronglyConnectedGraphExceptionTest.Constructor()
        }
        
        [PexMethod]
        public NotStronglyConnectedGraphException Constructor01(string message)
        {
            NotStronglyConnectedGraphException target
               = new NotStronglyConnectedGraphException(message);
            return target;
            // TODO: add assertions to method NotStronglyConnectedGraphExceptionTest.Constructor01(String)
        }
        
        [PexMethod]
        public NotStronglyConnectedGraphException Constructor02(string message, Exception inner)
        {
            NotStronglyConnectedGraphException target
               = new NotStronglyConnectedGraphException(message, inner);
            return target;
            // TODO: add assertions to method NotStronglyConnectedGraphExceptionTest.Constructor02(String, Exception)
        }
        
    }
}
