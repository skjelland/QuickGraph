using Microsoft.Pex.Framework;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using QuickGraph;
using QuickGraph.Algorithms.MaximumFlow;
using System.Collections.Generic;

namespace QuickGraph.Algorithms.MaximumFlow
{
    /// <summary>
    /// This class contains parameterized unit tests for GraphAugmentorAlgorithmBase`3
    /// </summary>
    [TestClass]
    [PexClass(typeof(GraphAugmentorAlgorithmBase<, , >))]
    public partial class GraphAugmentorAlgorithmBaseTVertexTEdgeTGraphTest
    {
        [PexMethod]
        public void AugmentedEdgesGet<TVertex,TEdge,TGraph>(
            [PexAssumeNotNull]GraphAugmentorAlgorithmBase<TVertex, TEdge, TGraph> target
        )
            where TEdge : IEdge<TVertex>
            where TGraph : IMutableVertexAndEdgeListGraph<TVertex, TEdge>
        {
            ICollection<TEdge> result = target.AugmentedEdges;
            PexStore.ValueForValidation<ICollection<TEdge>>("result", result);
            // TODO: add assertions to method GraphAugmentorAlgorithmBaseTVertexTEdgeTGraphTest.AugmentedEdgesGet(GraphAugmentorAlgorithmBase`3<!!0,!!1,!!2>)
        }
        
        [PexMethod]
        public void AugmentedGet<TVertex,TEdge,TGraph>(
            [PexAssumeNotNull]GraphAugmentorAlgorithmBase<TVertex, TEdge, TGraph> target
        )
            where TEdge : IEdge<TVertex>
            where TGraph : IMutableVertexAndEdgeListGraph<TVertex, TEdge>
        {
            bool result = target.Augmented;
            PexStore.ValueForValidation<bool>("result", result);
            // TODO: add assertions to method GraphAugmentorAlgorithmBaseTVertexTEdgeTGraphTest.AugmentedGet(GraphAugmentorAlgorithmBase`3<!!0,!!1,!!2>)
        }
        
        [PexMethod]
        public void EdgeFactoryGet<TVertex,TEdge,TGraph>(
            [PexAssumeNotNull]GraphAugmentorAlgorithmBase<TVertex, TEdge, TGraph> target
        )
            where TEdge : IEdge<TVertex>
            where TGraph : IMutableVertexAndEdgeListGraph<TVertex, TEdge>
        {
            EdgeFactory<TVertex, TEdge> result = target.EdgeFactory;
            PexStore.ValueForValidation<EdgeFactory<TVertex, TEdge>>("result", result);
            // TODO: add assertions to method GraphAugmentorAlgorithmBaseTVertexTEdgeTGraphTest.EdgeFactoryGet(GraphAugmentorAlgorithmBase`3<!!0,!!1,!!2>)
        }
        
        [PexMethod]
        public void Rollback<TVertex,TEdge,TGraph>(
            [PexAssumeNotNull]GraphAugmentorAlgorithmBase<TVertex, TEdge, TGraph> target
        )
            where TEdge : IEdge<TVertex>
            where TGraph : IMutableVertexAndEdgeListGraph<TVertex, TEdge>
        {
            target.Rollback();
            // TODO: add assertions to method GraphAugmentorAlgorithmBaseTVertexTEdgeTGraphTest.Rollback(GraphAugmentorAlgorithmBase`3<!!0,!!1,!!2>)
        }
        
        [PexMethod]
        public void SuperSinkGet<TVertex,TEdge,TGraph>(
            [PexAssumeNotNull]GraphAugmentorAlgorithmBase<TVertex, TEdge, TGraph> target
        )
            where TEdge : IEdge<TVertex>
            where TGraph : IMutableVertexAndEdgeListGraph<TVertex, TEdge>
        {
            TVertex result = target.SuperSink;
            PexStore.ValueForValidation<TVertex>("result", result);
            // TODO: add assertions to method GraphAugmentorAlgorithmBaseTVertexTEdgeTGraphTest.SuperSinkGet(GraphAugmentorAlgorithmBase`3<!!0,!!1,!!2>)
        }
        
        [PexMethod]
        public void SuperSourceGet<TVertex,TEdge,TGraph>(
            [PexAssumeNotNull]GraphAugmentorAlgorithmBase<TVertex, TEdge, TGraph> target
        )
            where TEdge : IEdge<TVertex>
            where TGraph : IMutableVertexAndEdgeListGraph<TVertex, TEdge>
        {
            TVertex result = target.SuperSource;
            PexStore.ValueForValidation<TVertex>("result", result);
            // TODO: add assertions to method GraphAugmentorAlgorithmBaseTVertexTEdgeTGraphTest.SuperSourceGet(GraphAugmentorAlgorithmBase`3<!!0,!!1,!!2>)
        }
        
        [PexMethod]
        public void VertexFactoryGet<TVertex,TEdge,TGraph>(
            [PexAssumeNotNull]GraphAugmentorAlgorithmBase<TVertex, TEdge, TGraph> target
        )
            where TEdge : IEdge<TVertex>
            where TGraph : IMutableVertexAndEdgeListGraph<TVertex, TEdge>
        {
            VertexFactory<TVertex> result = target.VertexFactory;
            PexStore.ValueForValidation<VertexFactory<TVertex>>("result", result);
            // TODO: add assertions to method GraphAugmentorAlgorithmBaseTVertexTEdgeTGraphTest.VertexFactoryGet(GraphAugmentorAlgorithmBase`3<!!0,!!1,!!2>)
        }
        
    }
}
