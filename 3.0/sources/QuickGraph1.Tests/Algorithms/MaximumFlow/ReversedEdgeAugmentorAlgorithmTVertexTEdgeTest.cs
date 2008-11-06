using Microsoft.Pex.Framework;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using QuickGraph;
using QuickGraph.Algorithms.MaximumFlow;
using System.Collections.Generic;

namespace QuickGraph.Algorithms.MaximumFlow
{
    /// <summary>
    /// This class contains parameterized unit tests for ReversedEdgeAugmentorAlgorithm`2
    /// </summary>
    [TestClass]
    [PexClass(typeof(ReversedEdgeAugmentorAlgorithm<, >))]
    public partial class ReversedEdgeAugmentorAlgorithmTVertexTEdgeTest
    {
        [PexMethod]
        public void AddReversedEdges<TVertex,TEdge>(
            [PexAssumeUnderTest]ReversedEdgeAugmentorAlgorithm<TVertex, TEdge> target
        )
            where TEdge : IEdge<TVertex>
        {
            target.AddReversedEdges();
            // TODO: add assertions to method ReversedEdgeAugmentorAlgorithmTVertexTEdgeTest.AddReversedEdges(ReversedEdgeAugmentorAlgorithm`2<!!0,!!1>)
        }
        
        [PexMethod]
        public void AugmentedEdgesGet<TVertex,TEdge>(
            [PexAssumeUnderTest]ReversedEdgeAugmentorAlgorithm<TVertex, TEdge> target
        )
            where TEdge : IEdge<TVertex>
        {
            ICollection<TEdge> result = target.AugmentedEdges;
            PexStore.ValueForValidation<ICollection<TEdge>>("result", result);
            // TODO: add assertions to method ReversedEdgeAugmentorAlgorithmTVertexTEdgeTest.AugmentedEdgesGet(ReversedEdgeAugmentorAlgorithm`2<!!0,!!1>)
        }
        
        [PexMethod]
        public void AugmentedGet<TVertex,TEdge>(
            [PexAssumeUnderTest]ReversedEdgeAugmentorAlgorithm<TVertex, TEdge> target
        )
            where TEdge : IEdge<TVertex>
        {
            bool result = target.Augmented;
            PexStore.ValueForValidation<bool>("result", result);
            // TODO: add assertions to method ReversedEdgeAugmentorAlgorithmTVertexTEdgeTest.AugmentedGet(ReversedEdgeAugmentorAlgorithm`2<!!0,!!1>)
        }
        
        [PexMethod]
        public void EdgeFactoryGet<TVertex,TEdge>(
            [PexAssumeUnderTest]ReversedEdgeAugmentorAlgorithm<TVertex, TEdge> target
        )
            where TEdge : IEdge<TVertex>
        {
            EdgeFactory<TVertex, TEdge> result = target.EdgeFactory;
            PexStore.ValueForValidation<EdgeFactory<TVertex, TEdge>>("result", result);
            // TODO: add assertions to method ReversedEdgeAugmentorAlgorithmTVertexTEdgeTest.EdgeFactoryGet(ReversedEdgeAugmentorAlgorithm`2<!!0,!!1>)
        }
        
        [PexMethod]
        public void RemoveReversedEdges<TVertex,TEdge>(
            [PexAssumeUnderTest]ReversedEdgeAugmentorAlgorithm<TVertex, TEdge> target
        )
            where TEdge : IEdge<TVertex>
        {
            target.RemoveReversedEdges();
            // TODO: add assertions to method ReversedEdgeAugmentorAlgorithmTVertexTEdgeTest.RemoveReversedEdges(ReversedEdgeAugmentorAlgorithm`2<!!0,!!1>)
        }
        
        [PexMethod]
        public void ReversedEdgesGet<TVertex,TEdge>(
            [PexAssumeUnderTest]ReversedEdgeAugmentorAlgorithm<TVertex, TEdge> target
        )
            where TEdge : IEdge<TVertex>
        {
            IDictionary<TEdge, TEdge> result = target.ReversedEdges;
            PexStore.ValueForValidation<IDictionary<TEdge, TEdge>>("result", result);
            // TODO: add assertions to method ReversedEdgeAugmentorAlgorithmTVertexTEdgeTest.ReversedEdgesGet(ReversedEdgeAugmentorAlgorithm`2<!!0,!!1>)
        }
        
        [PexMethod]
        public void VisitedGraphGet<TVertex,TEdge>(
            [PexAssumeUnderTest]ReversedEdgeAugmentorAlgorithm<TVertex, TEdge> target
        )
            where TEdge : IEdge<TVertex>
        {
            IMutableVertexAndEdgeListGraph<TVertex, TEdge> result = target.VisitedGraph;
            PexStore.ValueForValidation<IMutableVertexAndEdgeListGraph<TVertex, TEdge>>
                ("result", result);
            // TODO: add assertions to method ReversedEdgeAugmentorAlgorithmTVertexTEdgeTest.VisitedGraphGet(ReversedEdgeAugmentorAlgorithm`2<!!0,!!1>)
        }
        
    }
}
