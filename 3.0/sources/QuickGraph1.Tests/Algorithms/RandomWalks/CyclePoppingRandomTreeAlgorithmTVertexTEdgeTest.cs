using Microsoft.Pex.Framework;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using QuickGraph;
using QuickGraph.Algorithms.RandomWalks;
using QuickGraph.Algorithms.Services;
using System;
using System.Collections.Generic;

namespace QuickGraph.Algorithms.RandomWalks
{
    /// <summary>
    /// This class contains parameterized unit tests for CyclePoppingRandomTreeAlgorithm`2
    /// </summary>
    [TestClass]
    [PexClass(typeof(CyclePoppingRandomTreeAlgorithm<, >))]
    public partial class CyclePoppingRandomTreeAlgorithmTVertexTEdgeTest
    {
        [PexMethod]
        public CyclePoppingRandomTreeAlgorithm<TVertex, TEdge> Constructor<TVertex,TEdge>(IVertexListGraph<TVertex, TEdge> visitedGraph)
            where TEdge : IEdge<TVertex>
        {
            CyclePoppingRandomTreeAlgorithm<TVertex, TEdge> target
               = new CyclePoppingRandomTreeAlgorithm<TVertex, TEdge>(visitedGraph);
            return target;
            // TODO: add assertions to method CyclePoppingRandomTreeAlgorithmTVertexTEdgeTest.Constructor(IVertexListGraph`2<!!0,!!1>)
        }
        
        [PexMethod]
        public CyclePoppingRandomTreeAlgorithm<TVertex, TEdge> Constructor01<TVertex,TEdge>(
            IVertexListGraph<TVertex, TEdge> visitedGraph,
            IMarkovEdgeChain<TVertex, TEdge> edgeChain
        )
            where TEdge : IEdge<TVertex>
        {
            CyclePoppingRandomTreeAlgorithm<TVertex, TEdge> target = 
              new CyclePoppingRandomTreeAlgorithm<TVertex, TEdge>(visitedGraph, edgeChain);
            return target;
            // TODO: add assertions to method CyclePoppingRandomTreeAlgorithmTVertexTEdgeTest.Constructor01(IVertexListGraph`2<!!0,!!1>, IMarkovEdgeChain`2<!!0,!!1>)
        }
        
        [PexMethod]
        public CyclePoppingRandomTreeAlgorithm<TVertex, TEdge> Constructor02<TVertex,TEdge>(
            IAlgorithmComponent host,
            IVertexListGraph<TVertex, TEdge> visitedGraph,
            IMarkovEdgeChain<TVertex, TEdge> edgeChain
        )
            where TEdge : IEdge<TVertex>
        {
            CyclePoppingRandomTreeAlgorithm<TVertex, TEdge> target
               = new CyclePoppingRandomTreeAlgorithm<TVertex, TEdge>
                  (host, visitedGraph, edgeChain);
            return target;
            // TODO: add assertions to method CyclePoppingRandomTreeAlgorithmTVertexTEdgeTest.Constructor02(IAlgorithmComponent, IVertexListGraph`2<!!0,!!1>, IMarkovEdgeChain`2<!!0,!!1>)
        }
        
        [PexMethod]
        public void EdgeChainGet<TVertex,TEdge>(
            [PexAssumeUnderTest]CyclePoppingRandomTreeAlgorithm<TVertex, TEdge> target
        )
            where TEdge : IEdge<TVertex>
        {
            IMarkovEdgeChain<TVertex, TEdge> result = target.EdgeChain;
            PexStore.ValueForValidation<IMarkovEdgeChain<TVertex, TEdge>>("result", result);
            // TODO: add assertions to method CyclePoppingRandomTreeAlgorithmTVertexTEdgeTest.EdgeChainGet(CyclePoppingRandomTreeAlgorithm`2<!!0,!!1>)
        }
        
        [PexMethod]
        public void RandomTree<TVertex,TEdge>(
            [PexAssumeUnderTest]CyclePoppingRandomTreeAlgorithm<TVertex, TEdge> target
        )
            where TEdge : IEdge<TVertex>
        {
            target.RandomTree();
            // TODO: add assertions to method CyclePoppingRandomTreeAlgorithmTVertexTEdgeTest.RandomTree(CyclePoppingRandomTreeAlgorithm`2<!!0,!!1>)
        }
        
        [PexMethod]
        public void RandomTreeWithRoot<TVertex,TEdge>(
            [PexAssumeUnderTest]CyclePoppingRandomTreeAlgorithm<TVertex, TEdge> target,
            TVertex root
        )
            where TEdge : IEdge<TVertex>
        {
            target.RandomTreeWithRoot(root);
            // TODO: add assertions to method CyclePoppingRandomTreeAlgorithmTVertexTEdgeTest.RandomTreeWithRoot(CyclePoppingRandomTreeAlgorithm`2<!!0,!!1>, !!0)
        }
        
        [PexMethod]
        public void RndGetSet<TVertex,TEdge>(
            [PexAssumeUnderTest]CyclePoppingRandomTreeAlgorithm<TVertex, TEdge> target,
            Random value
        )
            where TEdge : IEdge<TVertex>
        {
            target.Rnd = value;
            Random result = target.Rnd;
            PexStore.ValueForValidation<Random>("result", result);
            PexAssert.AreEqual((object)value, (object)result);
            // TODO: add assertions to method CyclePoppingRandomTreeAlgorithmTVertexTEdgeTest.RndGetSet(CyclePoppingRandomTreeAlgorithm`2<!!0,!!1>, Random)
        }
        
        [PexMethod]
        public void SuccessorsGet<TVertex,TEdge>(
            [PexAssumeUnderTest]CyclePoppingRandomTreeAlgorithm<TVertex, TEdge> target
        )
            where TEdge : IEdge<TVertex>
        {
            IDictionary<TVertex, TEdge> result = target.Successors;
            PexStore.ValueForValidation<IDictionary<TVertex, TEdge>>("result", result);
            // TODO: add assertions to method CyclePoppingRandomTreeAlgorithmTVertexTEdgeTest.SuccessorsGet(CyclePoppingRandomTreeAlgorithm`2<!!0,!!1>)
        }
        
        [PexMethod]
        public void VertexColorsGet<TVertex,TEdge>(
            [PexAssumeUnderTest]CyclePoppingRandomTreeAlgorithm<TVertex, TEdge> target
        )
            where TEdge : IEdge<TVertex>
        {
            IDictionary<TVertex, GraphColor> result = target.VertexColors;
            PexStore.ValueForValidation<IDictionary<TVertex, GraphColor>>("result", result);
            // TODO: add assertions to method CyclePoppingRandomTreeAlgorithmTVertexTEdgeTest.VertexColorsGet(CyclePoppingRandomTreeAlgorithm`2<!!0,!!1>)
        }
        
    }
}
