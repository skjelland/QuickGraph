using Microsoft.Pex.Framework;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using QuickGraph;
using QuickGraph.Algorithms;
using QuickGraph.Algorithms.Matrix;
using System.Collections.Generic;

namespace QuickGraph.Algorithms
{
    /// <summary>
    /// This class contains parameterized unit tests for VertexAdjacencyMatrixBuilderAlgorithm`2
    /// </summary>
    [TestClass]
    [PexClass(typeof(VertexAdjacencyMatrixBuilderAlgorithm<, >))]
    public partial class VertexAdjacencyMatrixBuilderAlgorithmTVertexTEdgeTest
    {
        [PexMethod]
        public VertexAdjacencyMatrixBuilderAlgorithm<TVertex, TEdge> Constructor<TVertex,TEdge>(IVertexListGraph<TVertex, TEdge> visitedGraph)
            where TEdge : IEdge<TVertex>
        {
            VertexAdjacencyMatrixBuilderAlgorithm<TVertex, TEdge> target
               = new VertexAdjacencyMatrixBuilderAlgorithm<TVertex, TEdge>(visitedGraph);
            return target;
            // TODO: add assertions to method VertexAdjacencyMatrixBuilderAlgorithmTVertexTEdgeTest.Constructor(IVertexListGraph`2<!!0,!!1>)
        }
        
        [PexMethod]
        public void MatrixGet<TVertex,TEdge>(
            [PexAssumeUnderTest]VertexAdjacencyMatrixBuilderAlgorithm<TVertex, TEdge> target
        )
            where TEdge : IEdge<TVertex>
        {
            DoubleDenseMatrix result = target.Matrix;
            PexStore.ValueForValidation<DoubleDenseMatrix>("result", result);
            // TODO: add assertions to method VertexAdjacencyMatrixBuilderAlgorithmTVertexTEdgeTest.MatrixGet(VertexAdjacencyMatrixBuilderAlgorithm`2<!!0,!!1>)
        }
        
        [PexMethod]
        public void VertexIndicesGet<TVertex,TEdge>(
            [PexAssumeUnderTest]VertexAdjacencyMatrixBuilderAlgorithm<TVertex, TEdge> target
        )
            where TEdge : IEdge<TVertex>
        {
            Dictionary<TVertex, int> result = target.VertexIndices;
            PexStore.ValueForValidation<Dictionary<TVertex, int>>("result", result);
            // TODO: add assertions to method VertexAdjacencyMatrixBuilderAlgorithmTVertexTEdgeTest.VertexIndicesGet(VertexAdjacencyMatrixBuilderAlgorithm`2<!!0,!!1>)
        }
        
    }
}
