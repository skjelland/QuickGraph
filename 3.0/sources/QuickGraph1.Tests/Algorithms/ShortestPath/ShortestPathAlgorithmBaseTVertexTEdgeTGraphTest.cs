using Microsoft.Pex.Framework;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using QuickGraph;
using QuickGraph.Algorithms.ShortestPath;
using System;
using System.Collections.Generic;

namespace QuickGraph.Algorithms.ShortestPath
{
    /// <summary>
    /// This class contains parameterized unit tests for ShortestPathAlgorithmBase`3
    /// </summary>
    [TestClass]
    [PexClass(typeof(ShortestPathAlgorithmBase<, , >))]
    public partial class ShortestPathAlgorithmBaseTVertexTEdgeTGraphTest
    {
        [PexMethod]
        public void DistanceRelaxerGet<TVertex,TEdge,TGraph>(
            [PexAssumeNotNull]ShortestPathAlgorithmBase<TVertex, TEdge, TGraph> target
        )
            where TEdge : IEdge<TVertex>
        {
            IDistanceRelaxer result = target.DistanceRelaxer;
            PexStore.ValueForValidation<IDistanceRelaxer>("result", result);
            // TODO: add assertions to method ShortestPathAlgorithmBaseTVertexTEdgeTGraphTest.DistanceRelaxerGet(ShortestPathAlgorithmBase`3<!!0,!!1,!!2>)
        }
        
        [PexMethod]
        public void DistancesGet<TVertex,TEdge,TGraph>(
            [PexAssumeNotNull]ShortestPathAlgorithmBase<TVertex, TEdge, TGraph> target
        )
            where TEdge : IEdge<TVertex>
        {
            IDictionary<TVertex, double> result = target.Distances;
            PexStore.ValueForValidation<IDictionary<TVertex, double>>("result", result);
            // TODO: add assertions to method ShortestPathAlgorithmBaseTVertexTEdgeTGraphTest.DistancesGet(ShortestPathAlgorithmBase`3<!!0,!!1,!!2>)
        }
        
        [PexMethod]
        public GraphColor GetVertexColor<TVertex,TEdge,TGraph>(
            [PexAssumeNotNull]ShortestPathAlgorithmBase<TVertex, TEdge, TGraph> target,
            TVertex vertex
        )
            where TEdge : IEdge<TVertex>
        {
            GraphColor result = target.GetVertexColor(vertex);
            return result;
            // TODO: add assertions to method ShortestPathAlgorithmBaseTVertexTEdgeTGraphTest.GetVertexColor(ShortestPathAlgorithmBase`3<!!0,!!1,!!2>, !!0)
        }
        
        [PexMethod]
        public void VertexColorsGet<TVertex,TEdge,TGraph>(
            [PexAssumeNotNull]ShortestPathAlgorithmBase<TVertex, TEdge, TGraph> target
        )
            where TEdge : IEdge<TVertex>
        {
            IDictionary<TVertex, GraphColor> result = target.VertexColors;
            PexStore.ValueForValidation<IDictionary<TVertex, GraphColor>>("result", result);
            // TODO: add assertions to method ShortestPathAlgorithmBaseTVertexTEdgeTGraphTest.VertexColorsGet(ShortestPathAlgorithmBase`3<!!0,!!1,!!2>)
        }
        
        [PexMethod]
        public void WeightsGet<TVertex,TEdge,TGraph>(
            [PexAssumeNotNull]ShortestPathAlgorithmBase<TVertex, TEdge, TGraph> target
        )
            where TEdge : IEdge<TVertex>
        {
            Func<TEdge, double> result = target.Weights;
            PexStore.ValueForValidation<Func<TEdge, double>>("result", result);
            // TODO: add assertions to method ShortestPathAlgorithmBaseTVertexTEdgeTGraphTest.WeightsGet(ShortestPathAlgorithmBase`3<!!0,!!1,!!2>)
        }
        
    }
}
