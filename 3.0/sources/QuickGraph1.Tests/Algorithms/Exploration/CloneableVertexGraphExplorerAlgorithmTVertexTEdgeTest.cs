using Microsoft.Pex.Framework;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using QuickGraph;
using QuickGraph.Algorithms.Exploration;
using QuickGraph.Algorithms.Services;
using System;
using System.Collections.Generic;

namespace QuickGraph.Algorithms.Exploration
{
    /// <summary>
    /// This class contains parameterized unit tests for CloneableVertexGraphExplorerAlgorithm`2
    /// </summary>
    [TestClass]
    [PexClass(typeof(CloneableVertexGraphExplorerAlgorithm<, >))]
    public partial class CloneableVertexGraphExplorerAlgorithmTVertexTEdgeTest
    {
        [PexMethod]
        public void AddEdgePredicateGetSet<TVertex,TEdge>(
            [PexAssumeUnderTest]CloneableVertexGraphExplorerAlgorithm<TVertex, TEdge> target,
            EdgePredicate<TVertex, TEdge> value
        )
            where TVertex : ICloneable, IComparable<TVertex>
            where TEdge : IEdge<TVertex>
        {
            target.AddEdgePredicate = value;
            EdgePredicate<TVertex, TEdge> result = target.AddEdgePredicate;
            PexStore.ValueForValidation<EdgePredicate<TVertex, TEdge>>("result", result);
            // TODO: add assertions to method CloneableVertexGraphExplorerAlgorithmTVertexTEdgeTest.AddEdgePredicateGetSet(CloneableVertexGraphExplorerAlgorithm`2<!!0,!!1>, EdgePredicate`2<!!0,!!1>)
        }
        
        [PexMethod]
        public void AddVertexPredicateGetSet<TVertex,TEdge>(
            [PexAssumeUnderTest]CloneableVertexGraphExplorerAlgorithm<TVertex, TEdge> target,
            VertexPredicate<TVertex> value
        )
            where TVertex : ICloneable, IComparable<TVertex>
            where TEdge : IEdge<TVertex>
        {
            target.AddVertexPredicate = value;
            VertexPredicate<TVertex> result = target.AddVertexPredicate;
            PexStore.ValueForValidation<VertexPredicate<TVertex>>("result", result);
            // TODO: add assertions to method CloneableVertexGraphExplorerAlgorithmTVertexTEdgeTest.AddVertexPredicateGetSet(CloneableVertexGraphExplorerAlgorithm`2<!!0,!!1>, VertexPredicate`1<!!0>)
        }
        
        [PexMethod]
        public CloneableVertexGraphExplorerAlgorithm<TVertex, TEdge> Constructor<TVertex,TEdge>(IMutableVertexAndEdgeListGraph<TVertex, TEdge> visitedGraph)
            where TVertex : ICloneable, IComparable<TVertex>
            where TEdge : IEdge<TVertex>
        {
            CloneableVertexGraphExplorerAlgorithm<TVertex, TEdge> target
               = new CloneableVertexGraphExplorerAlgorithm<TVertex, TEdge>(visitedGraph);
            return target;
            // TODO: add assertions to method CloneableVertexGraphExplorerAlgorithmTVertexTEdgeTest.Constructor(IMutableVertexAndEdgeListGraph`2<!!0,!!1>)
        }
        
        [PexMethod]
        public CloneableVertexGraphExplorerAlgorithm<TVertex, TEdge> Constructor01<TVertex,TEdge>(
            IAlgorithmComponent host,
            IMutableVertexAndEdgeListGraph<TVertex, TEdge> visitedGraph
        )
            where TVertex : ICloneable, IComparable<TVertex>
            where TEdge : IEdge<TVertex>
        {
            CloneableVertexGraphExplorerAlgorithm<TVertex, TEdge> target
               = new CloneableVertexGraphExplorerAlgorithm<TVertex, TEdge>
                  (host, visitedGraph);
            return target;
            // TODO: add assertions to method CloneableVertexGraphExplorerAlgorithmTVertexTEdgeTest.Constructor01(IAlgorithmComponent, IMutableVertexAndEdgeListGraph`2<!!0,!!1>)
        }
        
        [PexMethod]
        public void ExploreVertexPredicateGetSet<TVertex,TEdge>(
            [PexAssumeUnderTest]CloneableVertexGraphExplorerAlgorithm<TVertex, TEdge> target,
            VertexPredicate<TVertex> value
        )
            where TVertex : ICloneable, IComparable<TVertex>
            where TEdge : IEdge<TVertex>
        {
            target.ExploreVertexPredicate = value;
            VertexPredicate<TVertex> result = target.ExploreVertexPredicate;
            PexStore.ValueForValidation<VertexPredicate<TVertex>>("result", result);
            // TODO: add assertions to method CloneableVertexGraphExplorerAlgorithmTVertexTEdgeTest.ExploreVertexPredicateGetSet(CloneableVertexGraphExplorerAlgorithm`2<!!0,!!1>, VertexPredicate`1<!!0>)
        }
        
        [PexMethod]
        public void FinishedPredicateGetSet<TVertex,TEdge>(
            [PexAssumeUnderTest]CloneableVertexGraphExplorerAlgorithm<TVertex, TEdge> target,
            Predicate<CloneableVertexGraphExplorerAlgorithm<TVertex, TEdge>> value
        )
            where TVertex : ICloneable, IComparable<TVertex>
            where TEdge : IEdge<TVertex>
        {
            target.FinishedPredicate = value;
            Predicate<CloneableVertexGraphExplorerAlgorithm<TVertex, TEdge>> result
               = target.FinishedPredicate;
            PexStore.ValueForValidation
                <Predicate<CloneableVertexGraphExplorerAlgorithm<TVertex, TEdge>>>
                ("result", result);
            // TODO: add assertions to method CloneableVertexGraphExplorerAlgorithmTVertexTEdgeTest.FinishedPredicateGetSet(CloneableVertexGraphExplorerAlgorithm`2<!!0,!!1>, Predicate`1<CloneableVertexGraphExplorerAlgorithm`2<!!0,!!1>>)
        }
        
        [PexMethod]
        public void FinishedSuccessfullyGet<TVertex,TEdge>(
            [PexAssumeUnderTest]CloneableVertexGraphExplorerAlgorithm<TVertex, TEdge> target
        )
            where TVertex : ICloneable, IComparable<TVertex>
            where TEdge : IEdge<TVertex>
        {
            bool result = target.FinishedSuccessfully;
            PexStore.ValueForValidation<bool>("result", result);
            // TODO: add assertions to method CloneableVertexGraphExplorerAlgorithmTVertexTEdgeTest.FinishedSuccessfullyGet(CloneableVertexGraphExplorerAlgorithm`2<!!0,!!1>)
        }
        
        [PexMethod]
        public void TransitionFactoriesGet<TVertex,TEdge>(
            [PexAssumeUnderTest]CloneableVertexGraphExplorerAlgorithm<TVertex, TEdge> target
        )
            where TVertex : ICloneable, IComparable<TVertex>
            where TEdge : IEdge<TVertex>
        {
            IList<ITransitionFactory<TVertex, TEdge>> result = target.TransitionFactories;
            PexStore.ValueForValidation<IList<ITransitionFactory<TVertex, TEdge>>>
                ("result", result);
            // TODO: add assertions to method CloneableVertexGraphExplorerAlgorithmTVertexTEdgeTest.TransitionFactoriesGet(CloneableVertexGraphExplorerAlgorithm`2<!!0,!!1>)
        }
        
        [PexMethod]
        public void UnexploredVerticesGet<TVertex,TEdge>(
            [PexAssumeUnderTest]CloneableVertexGraphExplorerAlgorithm<TVertex, TEdge> target
        )
            where TVertex : ICloneable, IComparable<TVertex>
            where TEdge : IEdge<TVertex>
        {
            IEnumerable<TVertex> result = target.UnexploredVertices;
            PexStore.ValueForValidation<IEnumerable<TVertex>>("result", result);
            // TODO: add assertions to method CloneableVertexGraphExplorerAlgorithmTVertexTEdgeTest.UnexploredVerticesGet(CloneableVertexGraphExplorerAlgorithm`2<!!0,!!1>)
        }
        
    }
}
