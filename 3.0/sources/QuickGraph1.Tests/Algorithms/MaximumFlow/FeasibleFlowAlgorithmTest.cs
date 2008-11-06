using Microsoft.Pex.Framework;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using QuickGraph.Algorithms.MaximumFlow;

namespace QuickGraph.Algorithms.MaximumFlow
{
    /// <summary>
    /// This class contains parameterized unit tests for FeasibleFlowAlgorithm
    /// </summary>
    [TestClass]
    [PexClass(typeof(FeasibleFlowAlgorithm))]
    public partial class FeasibleFlowAlgorithmTest
    {
        [PexMethod]
        public FeasibleFlowAlgorithm Constructor()
        {
            FeasibleFlowAlgorithm target = new FeasibleFlowAlgorithm();
            return target;
            // TODO: add assertions to method FeasibleFlowAlgorithmTest.Constructor()
        }
        
    }
}
