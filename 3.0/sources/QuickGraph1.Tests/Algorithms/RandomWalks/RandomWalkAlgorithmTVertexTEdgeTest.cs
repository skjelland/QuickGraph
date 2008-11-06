using Microsoft.Pex.Framework;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using QuickGraph;
using QuickGraph.Algorithms.RandomWalks;

namespace QuickGraph.Algorithms.RandomWalks
{
    /// <summary>
    /// This class contains parameterized unit tests for RandomWalkAlgorithm`2
    /// </summary>
    [TestClass]
    [PexClass(typeof(RandomWalkAlgorithm<, >))]
    public partial class RandomWalkAlgorithmTVertexTEdgeTest
    {
        [PexMethod]
        public RandomWalkAlgorithm<TVertex, TEdge> Constructor<TVertex,TEdge>(IImplicitGraph<TVertex, TEdge> visitedGraph)
            where TEdge : IEdge<TVertex>
        {
            RandomWalkAlgorithm<TVertex, TEdge> target
               = new RandomWalkAlgorithm<TVertex, TEdge>(visitedGraph);
            return target;
            // TODO: add assertions to method RandomWalkAlgorithmTVertexTEdgeTest.Constructor(IImplicitGraph`2<!!0,!!1>)
        }
        
        [PexMethod]
        public RandomWalkAlgorithm<TVertex, TEdge> Constructor01<TVertex,TEdge>(IImplicitGraph<TVertex, TEdge> visitedGraph, IEdgeChain<TVertex, TEdge> edgeChain)
            where TEdge : IEdge<TVertex>
        {
            RandomWalkAlgorithm<TVertex, TEdge> target
               = new RandomWalkAlgorithm<TVertex, TEdge>(visitedGraph, edgeChain);
            return target;
            // TODO: add assertions to method RandomWalkAlgorithmTVertexTEdgeTest.Constructor01(IImplicitGraph`2<!!0,!!1>, IEdgeChain`2<!!0,!!1>)
        }
        
        [PexMethod]
        public void EdgeChainGetSet<TVertex,TEdge>(
            [PexAssumeUnderTest]RandomWalkAlgorithm<TVertex, TEdge> target,
            IEdgeChain<TVertex, TEdge> value
        )
            where TEdge : IEdge<TVertex>
        {
            target.EdgeChain = value;
            IEdgeChain<TVertex, TEdge> result = target.EdgeChain;
            PexStore.ValueForValidation<IEdgeChain<TVertex, TEdge>>("result", result);
            // TODO: add assertions to method RandomWalkAlgorithmTVertexTEdgeTest.EdgeChainGetSet(RandomWalkAlgorithm`2<!!0,!!1>, IEdgeChain`2<!!0,!!1>)
        }
        
        [PexMethod]
        public void EndPredicateGetSet<TVertex,TEdge>(
            [PexAssumeUnderTest]RandomWalkAlgorithm<TVertex, TEdge> target,
            EdgePredicate<TVertex, TEdge> value
        )
            where TEdge : IEdge<TVertex>
        {
            target.EndPredicate = value;
            EdgePredicate<TVertex, TEdge> result = target.EndPredicate;
            PexStore.ValueForValidation<EdgePredicate<TVertex, TEdge>>("result", result);
            // TODO: add assertions to method RandomWalkAlgorithmTVertexTEdgeTest.EndPredicateGetSet(RandomWalkAlgorithm`2<!!0,!!1>, EdgePredicate`2<!!0,!!1>)
        }
        
        [PexMethod]
        public void Generate<TVertex,TEdge>(
            [PexAssumeUnderTest]RandomWalkAlgorithm<TVertex, TEdge> target,
            TVertex root
        )
            where TEdge : IEdge<TVertex>
        {
            target.Generate(root);
            // TODO: add assertions to method RandomWalkAlgorithmTVertexTEdgeTest.Generate(RandomWalkAlgorithm`2<!!0,!!1>, !!0)
        }
        
        [PexMethod]
        public void Generate01<TVertex,TEdge>(
            [PexAssumeUnderTest]RandomWalkAlgorithm<TVertex, TEdge> target,
            TVertex root,
            int walkCount
        )
            where TEdge : IEdge<TVertex>
        {
            target.Generate(root, walkCount);
            // TODO: add assertions to method RandomWalkAlgorithmTVertexTEdgeTest.Generate01(RandomWalkAlgorithm`2<!!0,!!1>, !!0, Int32)
        }
        
        [PexMethod]
        public void VisitedGraphGet<TVertex,TEdge>([PexAssumeUnderTest]RandomWalkAlgorithm<TVertex, TEdge> target)
            where TEdge : IEdge<TVertex>
        {
            IImplicitGraph<TVertex, TEdge> result = target.VisitedGraph;
            PexStore.ValueForValidation<IImplicitGraph<TVertex, TEdge>>("result", result);
            // TODO: add assertions to method RandomWalkAlgorithmTVertexTEdgeTest.VisitedGraphGet(RandomWalkAlgorithm`2<!!0,!!1>)
        }
        
    }
}
