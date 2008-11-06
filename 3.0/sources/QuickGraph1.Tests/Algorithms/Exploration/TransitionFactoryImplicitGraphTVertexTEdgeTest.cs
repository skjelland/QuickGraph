using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Wizard;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using QuickGraph;
using QuickGraph.Algorithms.Exploration;
using System;
using System.Collections;
using System.Collections.Generic;

namespace QuickGraph.Algorithms.Exploration
{
    /// <summary>
    /// This class contains parameterized unit tests for TransitionFactoryImplicitGraph`2
    /// </summary>
    [TestClass]
    [PexClass(typeof(TransitionFactoryImplicitGraph<, >))]
    public partial class TransitionFactoryImplicitGraphTVertexTEdgeTest
    {
        [PexMethod]
        public void AllowParallelEdgesGet<TVertex,TEdge>(
            [PexAssumeUnderTest]TransitionFactoryImplicitGraph<TVertex, TEdge> target
        )
            where TVertex : ICloneable
            where TEdge : IEdge<TVertex>
        {
            bool result = target.AllowParallelEdges;
            PexStore.ValueForValidation<bool>("result", result);
            // TODO: add assertions to method TransitionFactoryImplicitGraphTVertexTEdgeTest.AllowParallelEdgesGet(TransitionFactoryImplicitGraph`2<!!0,!!1>)
        }
        
        [PexMethod]
        public TransitionFactoryImplicitGraph<TVertex, TEdge> Constructor<TVertex,TEdge>()
            where TVertex : ICloneable
            where TEdge : IEdge<TVertex>
        {
            TransitionFactoryImplicitGraph<TVertex, TEdge> target
               = new TransitionFactoryImplicitGraph<TVertex, TEdge>();
            return target;
            // TODO: add assertions to method TransitionFactoryImplicitGraphTVertexTEdgeTest.Constructor()
        }
        
        [PexMethod]
        public void IsDirectedGet<TVertex,TEdge>(
            [PexAssumeUnderTest]TransitionFactoryImplicitGraph<TVertex, TEdge> target
        )
            where TVertex : ICloneable
            where TEdge : IEdge<TVertex>
        {
            bool result = target.IsDirected;
            PexStore.ValueForValidation<bool>("result", result);
            // TODO: add assertions to method TransitionFactoryImplicitGraphTVertexTEdgeTest.IsDirectedGet(TransitionFactoryImplicitGraph`2<!!0,!!1>)
        }
        
        [PexMethod]
        public bool IsOutEdgesEmpty<TVertex,TEdge>(
            [PexAssumeUnderTest]TransitionFactoryImplicitGraph<TVertex, TEdge> target,
            TVertex v
        )
            where TVertex : ICloneable
            where TEdge : IEdge<TVertex>
        {
            bool result = target.IsOutEdgesEmpty(v);
            return result;
            // TODO: add assertions to method TransitionFactoryImplicitGraphTVertexTEdgeTest.IsOutEdgesEmpty(TransitionFactoryImplicitGraph`2<!!0,!!1>, !!0)
        }
        
        [PexMethod]
        public int OutDegree<TVertex,TEdge>(
            [PexAssumeUnderTest]TransitionFactoryImplicitGraph<TVertex, TEdge> target,
            TVertex v
        )
            where TVertex : ICloneable
            where TEdge : IEdge<TVertex>
        {
            int result = target.OutDegree(v);
            return result;
            // TODO: add assertions to method TransitionFactoryImplicitGraphTVertexTEdgeTest.OutDegree(TransitionFactoryImplicitGraph`2<!!0,!!1>, !!0)
        }
        
        [PexMethod]
        public void OutEdge<TVertex,TEdge>(
            [PexAssumeUnderTest]TransitionFactoryImplicitGraph<TVertex, TEdge> target,
            TVertex v,
            int index
        )
            where TVertex : ICloneable
            where TEdge : IEdge<TVertex>
        {
            TEdge result = target.OutEdge(v, index);
            PexStore.ValueForValidation<TEdge>("result", result);
            // TODO: add assertions to method TransitionFactoryImplicitGraphTVertexTEdgeTest.OutEdge(TransitionFactoryImplicitGraph`2<!!0,!!1>, !!0, Int32)
        }
        
        [PexMethod]
        public void OutEdges<TVertex,TEdge>(
            [PexAssumeUnderTest]TransitionFactoryImplicitGraph<TVertex, TEdge> target,
            TVertex v
        )
            where TVertex : ICloneable
            where TEdge : IEdge<TVertex>
        {
            IEnumerable<TEdge> result = target.OutEdges(v);
            PexStore.ValueForValidation<IEnumerable<TEdge>>("result", result);
            PexEnumerablePatterns.ForEach<TEdge>(result);
            PexEnumerablePatterns.ForEach((IEnumerable)result);
            PexEnumerablePatterns.DoubleForEach<TEdge>(result);
            PexEnumerablePatterns.MoveNextAndReset<TEdge>(result);
            // TODO: add assertions to method TransitionFactoryImplicitGraphTVertexTEdgeTest.OutEdges(TransitionFactoryImplicitGraph`2<!!0,!!1>, !!0)
        }
        
        [PexMethod]
        public void SuccessorEdgePredicateGetSet<TVertex,TEdge>(
            [PexAssumeUnderTest]TransitionFactoryImplicitGraph<TVertex, TEdge> target,
            EdgePredicate<TVertex, TEdge> value
        )
            where TVertex : ICloneable
            where TEdge : IEdge<TVertex>
        {
            target.SuccessorEdgePredicate = value;
            EdgePredicate<TVertex, TEdge> result = target.SuccessorEdgePredicate;
            PexStore.ValueForValidation<EdgePredicate<TVertex, TEdge>>("result", result);
            // TODO: add assertions to method TransitionFactoryImplicitGraphTVertexTEdgeTest.SuccessorEdgePredicateGetSet(TransitionFactoryImplicitGraph`2<!!0,!!1>, EdgePredicate`2<!!0,!!1>)
        }
        
        [PexMethod]
        public void SuccessorVertexPredicateGetSet<TVertex,TEdge>(
            [PexAssumeUnderTest]TransitionFactoryImplicitGraph<TVertex, TEdge> target,
            VertexPredicate<TVertex> value
        )
            where TVertex : ICloneable
            where TEdge : IEdge<TVertex>
        {
            target.SuccessorVertexPredicate = value;
            VertexPredicate<TVertex> result = target.SuccessorVertexPredicate;
            PexStore.ValueForValidation<VertexPredicate<TVertex>>("result", result);
            // TODO: add assertions to method TransitionFactoryImplicitGraphTVertexTEdgeTest.SuccessorVertexPredicateGetSet(TransitionFactoryImplicitGraph`2<!!0,!!1>, VertexPredicate`1<!!0>)
        }
        
        [PexMethod]
        public void TransitionFactoriesGet<TVertex,TEdge>(
            [PexAssumeUnderTest]TransitionFactoryImplicitGraph<TVertex, TEdge> target
        )
            where TVertex : ICloneable
            where TEdge : IEdge<TVertex>
        {
            IList<ITransitionFactory<TVertex, TEdge>> result = target.TransitionFactories;
            PexStore.ValueForValidation<IList<ITransitionFactory<TVertex, TEdge>>>
                ("result", result);
            // TODO: add assertions to method TransitionFactoryImplicitGraphTVertexTEdgeTest.TransitionFactoriesGet(TransitionFactoryImplicitGraph`2<!!0,!!1>)
        }
        
    }
}
