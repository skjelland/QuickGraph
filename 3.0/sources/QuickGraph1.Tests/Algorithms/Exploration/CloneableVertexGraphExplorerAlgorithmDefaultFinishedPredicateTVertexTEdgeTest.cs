using Microsoft.Pex.Framework;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using QuickGraph;
using QuickGraph.Algorithms.Exploration;
using System;

namespace QuickGraph.Algorithms.Exploration
{
    /// <summary>
    /// This class contains parameterized unit tests for DefaultFinishedPredicate
    /// </summary>
    [TestClass]
    [PexClass(typeof(CloneableVertexGraphExplorerAlgorithm<, >.DefaultFinishedPredicate))]
    public partial class CloneableVertexGraphExplorerAlgorithmDefaultFinishedPredicateTVertexTEdgeTest
    {
        [PexMethod]
        public CloneableVertexGraphExplorerAlgorithm<TVertex, TEdge>.DefaultFinishedPredicate Constructor<TVertex,TEdge>()
            where TVertex : ICloneable, IComparable<TVertex>
            where TEdge : IEdge<TVertex>
        {
            CloneableVertexGraphExplorerAlgorithm<TVertex, TEdge>.DefaultFinishedPredicate 
              target = new CloneableVertexGraphExplorerAlgorithm<TVertex, TEdge>
              .DefaultFinishedPredicate();
            return target;
            // TODO: add assertions to method CloneableVertexGraphExplorerAlgorithmDefaultFinishedPredicateTVertexTEdgeTest.Constructor()
        }
        
        [PexMethod]
        public CloneableVertexGraphExplorerAlgorithm<TVertex, TEdge>.DefaultFinishedPredicate Constructor01<TVertex,TEdge>(int maxVertexCount, int maxEdgeCount)
            where TVertex : ICloneable, IComparable<TVertex>
            where TEdge : IEdge<TVertex>
        {
            CloneableVertexGraphExplorerAlgorithm<TVertex, TEdge>.DefaultFinishedPredicate 
              target = new CloneableVertexGraphExplorerAlgorithm<TVertex, TEdge>
              .DefaultFinishedPredicate(maxVertexCount, maxEdgeCount);
            return target;
            // TODO: add assertions to method CloneableVertexGraphExplorerAlgorithmDefaultFinishedPredicateTVertexTEdgeTest.Constructor01(Int32, Int32)
        }
        
        [PexMethod]
        public void MaxEdgeCountGetSet<TVertex,TEdge>(
            [PexAssumeUnderTest]CloneableVertexGraphExplorerAlgorithm<TVertex, TEdge>.DefaultFinishedPredicate target,
            int value
        )
            where TVertex : ICloneable, IComparable<TVertex>
            where TEdge : IEdge<TVertex>
        {
            target.MaxEdgeCount = value;
            int result = target.MaxEdgeCount;
            PexStore.ValueForValidation<int>("result", result);
            PexAssert.AreEqual((object)value, (object)result);
            // TODO: add assertions to method CloneableVertexGraphExplorerAlgorithmDefaultFinishedPredicateTVertexTEdgeTest.MaxEdgeCountGetSet(DefaultFinishedPredicate<!!0,!!1>, Int32)
        }
        
        [PexMethod]
        public void MaxVertexCountGetSet<TVertex,TEdge>(
            [PexAssumeUnderTest]CloneableVertexGraphExplorerAlgorithm<TVertex, TEdge>.DefaultFinishedPredicate target,
            int value
        )
            where TVertex : ICloneable, IComparable<TVertex>
            where TEdge : IEdge<TVertex>
        {
            target.MaxVertexCount = value;
            int result = target.MaxVertexCount;
            PexStore.ValueForValidation<int>("result", result);
            PexAssert.AreEqual((object)value, (object)result);
            // TODO: add assertions to method CloneableVertexGraphExplorerAlgorithmDefaultFinishedPredicateTVertexTEdgeTest.MaxVertexCountGetSet(DefaultFinishedPredicate<!!0,!!1>, Int32)
        }
        
        [PexMethod]
        public bool Test<TVertex,TEdge>(
            [PexAssumeUnderTest]CloneableVertexGraphExplorerAlgorithm<TVertex, TEdge>.DefaultFinishedPredicate target,
            CloneableVertexGraphExplorerAlgorithm<TVertex, TEdge> t
        )
            where TVertex : ICloneable, IComparable<TVertex>
            where TEdge : IEdge<TVertex>
        {
            bool result = target.Test(t);
            return result;
            // TODO: add assertions to method CloneableVertexGraphExplorerAlgorithmDefaultFinishedPredicateTVertexTEdgeTest.Test(DefaultFinishedPredicate<!!0,!!1>, CloneableVertexGraphExplorerAlgorithm`2<!!0,!!1>)
        }
        
    }
}
