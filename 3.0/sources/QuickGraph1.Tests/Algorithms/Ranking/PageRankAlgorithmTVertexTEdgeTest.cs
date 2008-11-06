using Microsoft.Pex.Framework;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using QuickGraph;
using QuickGraph.Algorithms.Ranking;
using System.Collections.Generic;

namespace QuickGraph.Algorithms.Ranking
{
    /// <summary>
    /// This class contains parameterized unit tests for PageRankAlgorithm`2
    /// </summary>
    [TestClass]
    [PexClass(typeof(PageRankAlgorithm<, >))]
    public partial class PageRankAlgorithmTVertexTEdgeTest
    {
        [PexMethod]
        public PageRankAlgorithm<TVertex, TEdge> Constructor<TVertex,TEdge>(IBidirectionalGraph<TVertex, TEdge> visitedGraph)
            where TEdge : IEdge<TVertex>
        {
            PageRankAlgorithm<TVertex, TEdge> target
               = new PageRankAlgorithm<TVertex, TEdge>(visitedGraph);
            return target;
            // TODO: add assertions to method PageRankAlgorithmTVertexTEdgeTest.Constructor(IBidirectionalGraph`2<!!0,!!1>)
        }
        
        [PexMethod]
        public void DampingGetSet<TVertex,TEdge>(
            [PexAssumeUnderTest]PageRankAlgorithm<TVertex, TEdge> target,
            double value
        )
            where TEdge : IEdge<TVertex>
        {
            target.Damping = value;
            double result = target.Damping;
            PexStore.ValueForValidation<double>("result", result);
            PexAssert.AreEqual((object)value, (object)result);
            // TODO: add assertions to method PageRankAlgorithmTVertexTEdgeTest.DampingGetSet(PageRankAlgorithm`2<!!0,!!1>, Double)
        }
        
        [PexMethod]
        public double GetRanksMean<TVertex,TEdge>([PexAssumeUnderTest]PageRankAlgorithm<TVertex, TEdge> target)
            where TEdge : IEdge<TVertex>
        {
            double result = target.GetRanksMean();
            return result;
            // TODO: add assertions to method PageRankAlgorithmTVertexTEdgeTest.GetRanksMean(PageRankAlgorithm`2<!!0,!!1>)
        }
        
        [PexMethod]
        public double GetRanksSum<TVertex,TEdge>([PexAssumeUnderTest]PageRankAlgorithm<TVertex, TEdge> target)
            where TEdge : IEdge<TVertex>
        {
            double result = target.GetRanksSum();
            return result;
            // TODO: add assertions to method PageRankAlgorithmTVertexTEdgeTest.GetRanksSum(PageRankAlgorithm`2<!!0,!!1>)
        }
        
        [PexMethod]
        public void InitializeRanks<TVertex,TEdge>([PexAssumeUnderTest]PageRankAlgorithm<TVertex, TEdge> target)
            where TEdge : IEdge<TVertex>
        {
            target.InitializeRanks();
            // TODO: add assertions to method PageRankAlgorithmTVertexTEdgeTest.InitializeRanks(PageRankAlgorithm`2<!!0,!!1>)
        }
        
        [PexMethod]
        public void MaxIterationGetSet<TVertex,TEdge>(
            [PexAssumeUnderTest]PageRankAlgorithm<TVertex, TEdge> target,
            int value
        )
            where TEdge : IEdge<TVertex>
        {
            target.MaxIteration = value;
            int result = target.MaxIteration;
            PexStore.ValueForValidation<int>("result", result);
            PexAssert.AreEqual((object)value, (object)result);
            // TODO: add assertions to method PageRankAlgorithmTVertexTEdgeTest.MaxIterationGetSet(PageRankAlgorithm`2<!!0,!!1>, Int32)
        }
        
        [PexMethod]
        public void RanksGet<TVertex,TEdge>([PexAssumeUnderTest]PageRankAlgorithm<TVertex, TEdge> target)
            where TEdge : IEdge<TVertex>
        {
            IDictionary<TVertex, double> result = target.Ranks;
            PexStore.ValueForValidation<IDictionary<TVertex, double>>("result", result);
            // TODO: add assertions to method PageRankAlgorithmTVertexTEdgeTest.RanksGet(PageRankAlgorithm`2<!!0,!!1>)
        }
        
        [PexMethod]
        public void ToleranceGetSet<TVertex,TEdge>(
            [PexAssumeUnderTest]PageRankAlgorithm<TVertex, TEdge> target,
            double value
        )
            where TEdge : IEdge<TVertex>
        {
            target.Tolerance = value;
            double result = target.Tolerance;
            PexStore.ValueForValidation<double>("result", result);
            PexAssert.AreEqual((object)value, (object)result);
            // TODO: add assertions to method PageRankAlgorithmTVertexTEdgeTest.ToleranceGetSet(PageRankAlgorithm`2<!!0,!!1>, Double)
        }
        
    }
}
