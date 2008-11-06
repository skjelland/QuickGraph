using Microsoft.Pex.Framework;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using QuickGraph;
using QuickGraph.Algorithms;
using System;

namespace QuickGraph.Algorithms
{
    /// <summary>
    /// This class contains parameterized unit tests for CentralityApproximationAlgorithm`2
    /// </summary>
    [TestClass]
    [PexClass(typeof(CentralityApproximationAlgorithm<, >))]
    public partial class CentralityApproximationAlgorithmTVertexTEdgeTest
    {
        [PexMethod]
        public void DistancesGet<TVertex,TEdge>(
            [PexAssumeUnderTest]CentralityApproximationAlgorithm<TVertex, TEdge> target
        )
            where TEdge : IEdge<TVertex>
        {
            Func<TEdge, double> result = target.Distances;
            PexStore.ValueForValidation<Func<TEdge, double>>("result", result);
            // TODO: add assertions to method CentralityApproximationAlgorithmTVertexTEdgeTest.DistancesGet(CentralityApproximationAlgorithm`2<!!0,!!1>)
        }
        
        [PexMethod]
        public void MaxIterationCountGetSet<TVertex,TEdge>(
            [PexAssumeUnderTest]CentralityApproximationAlgorithm<TVertex, TEdge> target,
            int value
        )
            where TEdge : IEdge<TVertex>
        {
            target.MaxIterationCount = value;
            int result = target.MaxIterationCount;
            PexStore.ValueForValidation<int>("result", result);
            PexAssert.AreEqual((object)value, (object)result);
            // TODO: add assertions to method CentralityApproximationAlgorithmTVertexTEdgeTest.MaxIterationCountGetSet(CentralityApproximationAlgorithm`2<!!0,!!1>, Int32)
        }
        
        [PexMethod]
        public void RandGetSet<TVertex,TEdge>(
            [PexAssumeUnderTest]CentralityApproximationAlgorithm<TVertex, TEdge> target,
            Random value
        )
            where TEdge : IEdge<TVertex>
        {
            target.Rand = value;
            Random result = target.Rand;
            PexStore.ValueForValidation<Random>("result", result);
            PexAssert.AreEqual((object)value, (object)result);
            // TODO: add assertions to method CentralityApproximationAlgorithmTVertexTEdgeTest.RandGetSet(CentralityApproximationAlgorithm`2<!!0,!!1>, Random)
        }
        
    }
}
