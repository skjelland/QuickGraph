using Microsoft.Pex.Framework;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using QuickGraph.Algorithms.ShortestPath;

namespace QuickGraph.Algorithms.ShortestPath
{
    /// <summary>
    /// This class contains parameterized unit tests for ShortestDistanceRelaxer
    /// </summary>
    [TestClass]
    [PexClass(typeof(ShortestDistanceRelaxer))]
    public partial class ShortestDistanceRelaxerTest
    {
        [PexMethod]
        public double Combine(
            [PexAssumeUnderTest]ShortestDistanceRelaxer target,
            double distance,
            double weight
        )
        {
            double result = target.Combine(distance, weight);
            return result;
            // TODO: add assertions to method ShortestDistanceRelaxerTest.Combine(ShortestDistanceRelaxer, Double, Double)
        }
        
        [PexMethod]
        public bool Compare(
            [PexAssumeUnderTest]ShortestDistanceRelaxer target,
            double a,
            double b
        )
        {
            bool result = target.Compare(a, b);
            return result;
            // TODO: add assertions to method ShortestDistanceRelaxerTest.Compare(ShortestDistanceRelaxer, Double, Double)
        }
        
        [PexMethod]
        public void InitialDistanceGet([PexAssumeUnderTest]ShortestDistanceRelaxer target)
        {
            double result = target.InitialDistance;
            PexStore.ValueForValidation<double>("result", result);
            // TODO: add assertions to method ShortestDistanceRelaxerTest.InitialDistanceGet(ShortestDistanceRelaxer)
        }
        
    }
}
