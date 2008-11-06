using Microsoft.Pex.Framework;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using QuickGraph;
using QuickGraph.Algorithms.MaximumFlow;
using System;
using System.Collections.Generic;

namespace QuickGraph.Algorithms.MaximumFlow
{
    /// <summary>
    /// This class contains parameterized unit tests for MaximumFlowAlgorithm`2
    /// </summary>
    [TestClass]
    [PexClass(typeof(MaximumFlowAlgorithm<, >))]
    public partial class MaximumFlowAlgorithmTVertexTEdgeTest
    {
        [PexMethod]
        public void CapacitiesGet<TVertex,TEdge>([PexAssumeNotNull]MaximumFlowAlgorithm<TVertex, TEdge> target)
            where TEdge : IEdge<TVertex>
        {
            Func<TEdge, double> result = target.Capacities;
            PexStore.ValueForValidation<Func<TEdge, double>>("result", result);
            // TODO: add assertions to method MaximumFlowAlgorithmTVertexTEdgeTest.CapacitiesGet(MaximumFlowAlgorithm`2<!!0,!!1>)
        }
        
        [PexMethod]
        public double Compute<TVertex,TEdge>(
            [PexAssumeNotNull]MaximumFlowAlgorithm<TVertex, TEdge> target,
            TVertex source,
            TVertex sink
        )
            where TEdge : IEdge<TVertex>
        {
            double result = target.Compute(source, sink);
            return result;
            // TODO: add assertions to method MaximumFlowAlgorithmTVertexTEdgeTest.Compute(MaximumFlowAlgorithm`2<!!0,!!1>, !!0, !!0)
        }
        
        [PexMethod]
        public GraphColor GetVertexColor<TVertex,TEdge>(
            [PexAssumeNotNull]MaximumFlowAlgorithm<TVertex, TEdge> target,
            TVertex vertex
        )
            where TEdge : IEdge<TVertex>
        {
            GraphColor result = target.GetVertexColor(vertex);
            return result;
            // TODO: add assertions to method MaximumFlowAlgorithmTVertexTEdgeTest.GetVertexColor(MaximumFlowAlgorithm`2<!!0,!!1>, !!0)
        }
        
        [PexMethod]
        public void MaxFlowGetSet<TVertex,TEdge>(
            [PexAssumeNotNull]MaximumFlowAlgorithm<TVertex, TEdge> target,
            double value
        )
            where TEdge : IEdge<TVertex>
        {
            target.MaxFlow = value;
            double result = target.MaxFlow;
            PexStore.ValueForValidation<double>("result", result);
            PexAssert.AreEqual((object)value, (object)result);
            // TODO: add assertions to method MaximumFlowAlgorithmTVertexTEdgeTest.MaxFlowGetSet(MaximumFlowAlgorithm`2<!!0,!!1>, Double)
        }
        
        [PexMethod]
        public void PredecessorsGet<TVertex,TEdge>([PexAssumeNotNull]MaximumFlowAlgorithm<TVertex, TEdge> target)
            where TEdge : IEdge<TVertex>
        {
            IDictionary<TVertex, TEdge> result = target.Predecessors;
            PexStore.ValueForValidation<IDictionary<TVertex, TEdge>>("result", result);
            // TODO: add assertions to method MaximumFlowAlgorithmTVertexTEdgeTest.PredecessorsGet(MaximumFlowAlgorithm`2<!!0,!!1>)
        }
        
        [PexMethod]
        public void ResidualCapacitiesGet<TVertex,TEdge>([PexAssumeNotNull]MaximumFlowAlgorithm<TVertex, TEdge> target)
            where TEdge : IEdge<TVertex>
        {
            IDictionary<TEdge, double> result = target.ResidualCapacities;
            PexStore.ValueForValidation<IDictionary<TEdge, double>>("result", result);
            // TODO: add assertions to method MaximumFlowAlgorithmTVertexTEdgeTest.ResidualCapacitiesGet(MaximumFlowAlgorithm`2<!!0,!!1>)
        }
        
        [PexMethod]
        public void ReversedEdgesGet<TVertex,TEdge>([PexAssumeNotNull]MaximumFlowAlgorithm<TVertex, TEdge> target)
            where TEdge : IEdge<TVertex>
        {
            IDictionary<TEdge, TEdge> result = target.ReversedEdges;
            PexStore.ValueForValidation<IDictionary<TEdge, TEdge>>("result", result);
            // TODO: add assertions to method MaximumFlowAlgorithmTVertexTEdgeTest.ReversedEdgesGet(MaximumFlowAlgorithm`2<!!0,!!1>)
        }
        
        [PexMethod]
        public void SinkGetSet<TVertex,TEdge>(
            [PexAssumeNotNull]MaximumFlowAlgorithm<TVertex, TEdge> target,
            TVertex value
        )
            where TEdge : IEdge<TVertex>
        {
            target.Sink = value;
            TVertex result = target.Sink;
            PexStore.ValueForValidation<TVertex>("result", result);
            // TODO: add assertions to method MaximumFlowAlgorithmTVertexTEdgeTest.SinkGetSet(MaximumFlowAlgorithm`2<!!0,!!1>, !!0)
        }
        
        [PexMethod]
        public void SourceGetSet<TVertex,TEdge>(
            [PexAssumeNotNull]MaximumFlowAlgorithm<TVertex, TEdge> target,
            TVertex value
        )
            where TEdge : IEdge<TVertex>
        {
            target.Source = value;
            TVertex result = target.Source;
            PexStore.ValueForValidation<TVertex>("result", result);
            // TODO: add assertions to method MaximumFlowAlgorithmTVertexTEdgeTest.SourceGetSet(MaximumFlowAlgorithm`2<!!0,!!1>, !!0)
        }
        
        [PexMethod]
        public void VertexColorsGet<TVertex,TEdge>([PexAssumeNotNull]MaximumFlowAlgorithm<TVertex, TEdge> target)
            where TEdge : IEdge<TVertex>
        {
            IDictionary<TVertex, GraphColor> result = target.VertexColors;
            PexStore.ValueForValidation<IDictionary<TVertex, GraphColor>>("result", result);
            // TODO: add assertions to method MaximumFlowAlgorithmTVertexTEdgeTest.VertexColorsGet(MaximumFlowAlgorithm`2<!!0,!!1>)
        }
        
    }
}
