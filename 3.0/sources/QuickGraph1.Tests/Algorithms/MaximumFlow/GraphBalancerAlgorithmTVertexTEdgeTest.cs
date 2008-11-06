using Microsoft.Pex.Framework;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using QuickGraph;
using QuickGraph.Algorithms.MaximumFlow;
using System.Collections.Generic;

namespace QuickGraph.Algorithms.MaximumFlow
{
    /// <summary>
    /// This class contains parameterized unit tests for GraphBalancerAlgorithm`2
    /// </summary>
    [TestClass]
    [PexClass(typeof(GraphBalancerAlgorithm<, >))]
    public partial class GraphBalancerAlgorithmTVertexTEdgeTest
    {
        [PexMethod]
        public void Balance<TVertex,TEdge>([PexAssumeUnderTest]GraphBalancerAlgorithm<TVertex, TEdge> target)
            where TEdge : IEdge<TVertex>
        {
            target.Balance();
            // TODO: add assertions to method GraphBalancerAlgorithmTVertexTEdgeTest.Balance(GraphBalancerAlgorithm`2<!!0,!!1>)
        }
        
        [PexMethod]
        public void BalancedGet<TVertex,TEdge>([PexAssumeUnderTest]GraphBalancerAlgorithm<TVertex, TEdge> target)
            where TEdge : IEdge<TVertex>
        {
            bool result = target.Balanced;
            PexStore.ValueForValidation<bool>("result", result);
            // TODO: add assertions to method GraphBalancerAlgorithmTVertexTEdgeTest.BalancedGet(GraphBalancerAlgorithm`2<!!0,!!1>)
        }
        
        [PexMethod]
        public void BalancingSinkEdgeGet<TVertex,TEdge>([PexAssumeUnderTest]GraphBalancerAlgorithm<TVertex, TEdge> target)
            where TEdge : IEdge<TVertex>
        {
            TEdge result = target.BalancingSinkEdge;
            PexStore.ValueForValidation<TEdge>("result", result);
            // TODO: add assertions to method GraphBalancerAlgorithmTVertexTEdgeTest.BalancingSinkEdgeGet(GraphBalancerAlgorithm`2<!!0,!!1>)
        }
        
        [PexMethod]
        public void BalancingSinkGet<TVertex,TEdge>([PexAssumeUnderTest]GraphBalancerAlgorithm<TVertex, TEdge> target)
            where TEdge : IEdge<TVertex>
        {
            TVertex result = target.BalancingSink;
            PexStore.ValueForValidation<TVertex>("result", result);
            // TODO: add assertions to method GraphBalancerAlgorithmTVertexTEdgeTest.BalancingSinkGet(GraphBalancerAlgorithm`2<!!0,!!1>)
        }
        
        [PexMethod]
        public void BalancingSourceEdgeGet<TVertex,TEdge>([PexAssumeUnderTest]GraphBalancerAlgorithm<TVertex, TEdge> target)
            where TEdge : IEdge<TVertex>
        {
            TEdge result = target.BalancingSourceEdge;
            PexStore.ValueForValidation<TEdge>("result", result);
            // TODO: add assertions to method GraphBalancerAlgorithmTVertexTEdgeTest.BalancingSourceEdgeGet(GraphBalancerAlgorithm`2<!!0,!!1>)
        }
        
        [PexMethod]
        public void BalancingSourceGet<TVertex,TEdge>([PexAssumeUnderTest]GraphBalancerAlgorithm<TVertex, TEdge> target)
            where TEdge : IEdge<TVertex>
        {
            TVertex result = target.BalancingSource;
            PexStore.ValueForValidation<TVertex>("result", result);
            // TODO: add assertions to method GraphBalancerAlgorithmTVertexTEdgeTest.BalancingSourceGet(GraphBalancerAlgorithm`2<!!0,!!1>)
        }
        
        [PexMethod]
        public void CapacitiesGet<TVertex,TEdge>([PexAssumeUnderTest]GraphBalancerAlgorithm<TVertex, TEdge> target)
            where TEdge : IEdge<TVertex>
        {
            IDictionary<TEdge, double> result = target.Capacities;
            PexStore.ValueForValidation<IDictionary<TEdge, double>>("result", result);
            // TODO: add assertions to method GraphBalancerAlgorithmTVertexTEdgeTest.CapacitiesGet(GraphBalancerAlgorithm`2<!!0,!!1>)
        }
        
        [PexMethod]
        public void DeficientEdgesGet<TVertex,TEdge>([PexAssumeUnderTest]GraphBalancerAlgorithm<TVertex, TEdge> target)
            where TEdge : IEdge<TVertex>
        {
            ICollection<TEdge> result = target.DeficientEdges;
            PexStore.ValueForValidation<ICollection<TEdge>>("result", result);
            // TODO: add assertions to method GraphBalancerAlgorithmTVertexTEdgeTest.DeficientEdgesGet(GraphBalancerAlgorithm`2<!!0,!!1>)
        }
        
        [PexMethod]
        public void DeficientVerticesGet<TVertex,TEdge>([PexAssumeUnderTest]GraphBalancerAlgorithm<TVertex, TEdge> target)
            where TEdge : IEdge<TVertex>
        {
            ICollection<TVertex> result = target.DeficientVertices;
            PexStore.ValueForValidation<ICollection<TVertex>>("result", result);
            // TODO: add assertions to method GraphBalancerAlgorithmTVertexTEdgeTest.DeficientVerticesGet(GraphBalancerAlgorithm`2<!!0,!!1>)
        }
        
        [PexMethod]
        public void EdgeFactoryGet<TVertex,TEdge>([PexAssumeUnderTest]GraphBalancerAlgorithm<TVertex, TEdge> target)
            where TEdge : IEdge<TVertex>
        {
            EdgeFactory<TVertex, TEdge> result = target.EdgeFactory;
            PexStore.ValueForValidation<EdgeFactory<TVertex, TEdge>>("result", result);
            // TODO: add assertions to method GraphBalancerAlgorithmTVertexTEdgeTest.EdgeFactoryGet(GraphBalancerAlgorithm`2<!!0,!!1>)
        }
        
        [PexMethod]
        public int GetBalancingIndex<TVertex,TEdge>(
            [PexAssumeUnderTest]GraphBalancerAlgorithm<TVertex, TEdge> target,
            TVertex v
        )
            where TEdge : IEdge<TVertex>
        {
            int result = target.GetBalancingIndex(v);
            return result;
            // TODO: add assertions to method GraphBalancerAlgorithmTVertexTEdgeTest.GetBalancingIndex(GraphBalancerAlgorithm`2<!!0,!!1>, !!0)
        }
        
        [PexMethod]
        public void SinkGet<TVertex,TEdge>([PexAssumeUnderTest]GraphBalancerAlgorithm<TVertex, TEdge> target)
            where TEdge : IEdge<TVertex>
        {
            TVertex result = target.Sink;
            PexStore.ValueForValidation<TVertex>("result", result);
            // TODO: add assertions to method GraphBalancerAlgorithmTVertexTEdgeTest.SinkGet(GraphBalancerAlgorithm`2<!!0,!!1>)
        }
        
        [PexMethod]
        public void SourceGet<TVertex,TEdge>([PexAssumeUnderTest]GraphBalancerAlgorithm<TVertex, TEdge> target)
            where TEdge : IEdge<TVertex>
        {
            TVertex result = target.Source;
            PexStore.ValueForValidation<TVertex>("result", result);
            // TODO: add assertions to method GraphBalancerAlgorithmTVertexTEdgeTest.SourceGet(GraphBalancerAlgorithm`2<!!0,!!1>)
        }
        
        [PexMethod]
        public void SurplusEdgesGet<TVertex,TEdge>([PexAssumeUnderTest]GraphBalancerAlgorithm<TVertex, TEdge> target)
            where TEdge : IEdge<TVertex>
        {
            ICollection<TEdge> result = target.SurplusEdges;
            PexStore.ValueForValidation<ICollection<TEdge>>("result", result);
            // TODO: add assertions to method GraphBalancerAlgorithmTVertexTEdgeTest.SurplusEdgesGet(GraphBalancerAlgorithm`2<!!0,!!1>)
        }
        
        [PexMethod]
        public void SurplusVerticesGet<TVertex,TEdge>([PexAssumeUnderTest]GraphBalancerAlgorithm<TVertex, TEdge> target)
            where TEdge : IEdge<TVertex>
        {
            ICollection<TVertex> result = target.SurplusVertices;
            PexStore.ValueForValidation<ICollection<TVertex>>("result", result);
            // TODO: add assertions to method GraphBalancerAlgorithmTVertexTEdgeTest.SurplusVerticesGet(GraphBalancerAlgorithm`2<!!0,!!1>)
        }
        
        [PexMethod]
        public void UnBalance<TVertex,TEdge>([PexAssumeUnderTest]GraphBalancerAlgorithm<TVertex, TEdge> target)
            where TEdge : IEdge<TVertex>
        {
            target.UnBalance();
            // TODO: add assertions to method GraphBalancerAlgorithmTVertexTEdgeTest.UnBalance(GraphBalancerAlgorithm`2<!!0,!!1>)
        }
        
        [PexMethod]
        public void VertexFactoryGet<TVertex,TEdge>([PexAssumeUnderTest]GraphBalancerAlgorithm<TVertex, TEdge> target)
            where TEdge : IEdge<TVertex>
        {
            VertexFactory<TVertex> result = target.VertexFactory;
            PexStore.ValueForValidation<VertexFactory<TVertex>>("result", result);
            // TODO: add assertions to method GraphBalancerAlgorithmTVertexTEdgeTest.VertexFactoryGet(GraphBalancerAlgorithm`2<!!0,!!1>)
        }
        
        [PexMethod]
        public void VisitedGraphGet<TVertex,TEdge>([PexAssumeUnderTest]GraphBalancerAlgorithm<TVertex, TEdge> target)
            where TEdge : IEdge<TVertex>
        {
            IMutableBidirectionalGraph<TVertex, TEdge> result = target.VisitedGraph;
            PexStore.ValueForValidation<IMutableBidirectionalGraph<TVertex, TEdge>>
                ("result", result);
            // TODO: add assertions to method GraphBalancerAlgorithmTVertexTEdgeTest.VisitedGraphGet(GraphBalancerAlgorithm`2<!!0,!!1>)
        }
        
    }
}
