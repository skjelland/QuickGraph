using Microsoft.Pex.Framework;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using QuickGraph.Algorithms.ShortestPath;

namespace QuickGraph.Algorithms.ShortestPath
{
    /// <summary>
    /// This class contains parameterized unit tests for CriticalDistanceRelaxer
    /// </summary>
    [TestClass]
    [PexClass(typeof(CriticalDistanceRelaxer))]
    public partial class CriticalDistanceRelaxerTest
    {
        [PexMethod]
        public double Combine(
            [PexAssumeUnderTest]CriticalDistanceRelaxer target,
            double distance,
            double weight
        )
        {
            double result = target.Combine(distance, weight);
            return result;
            // TODO: add assertions to method CriticalDistanceRelaxerTest.Combine(CriticalDistanceRelaxer, Double, Double)
        }
        
        [PexMethod]
        public bool Compare(
            [PexAssumeUnderTest]CriticalDistanceRelaxer target,
            double a,
            double b
        )
        {
            bool result = target.Compare(a, b);
            return result;
            // TODO: add assertions to method CriticalDistanceRelaxerTest.Compare(CriticalDistanceRelaxer, Double, Double)
        }
        
        [PexMethod]
        public void InitialDistanceGet([PexAssumeUnderTest]CriticalDistanceRelaxer target)
        {
            double result = target.InitialDistance;
            PexStore.ValueForValidation<double>("result", result);
            // TODO: add assertions to method CriticalDistanceRelaxerTest.InitialDistanceGet(CriticalDistanceRelaxer)
        }
        
    }
}
