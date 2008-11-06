using Microsoft.Pex.Framework;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using QuickGraph.Algorithms;
using System;

namespace QuickGraph.Algorithms
{
    /// <summary>
    /// This class contains parameterized unit tests for RootedAlgorithmBase`2
    /// </summary>
    [TestClass]
    [PexClass(typeof(RootedAlgorithmBase<, >))]
    public partial class RootedAlgorithmBaseTVertexTGraphTest
    {
        [PexMethod]
        [PexGenericArguments(new Type[]{typeof(int), typeof(int)})]
        public void ClearRootVertex<TVertex,TGraph>([PexAssumeNotNull]RootedAlgorithmBase<TVertex, TGraph> target)
        {
            target.ClearRootVertex();
            // TODO: add assertions to method RootedAlgorithmBaseTVertexTGraphTest.ClearRootVertex(RootedAlgorithmBase`2<!!0,!!1>)
        }
        
        [PexMethod]
        [PexGenericArguments(new Type[]{typeof(int), typeof(int)})]
        public void Compute<TVertex,TGraph>(
            [PexAssumeNotNull]RootedAlgorithmBase<TVertex, TGraph> target,
            TVertex rootVertex
        )
        {
            target.Compute(rootVertex);
            // TODO: add assertions to method RootedAlgorithmBaseTVertexTGraphTest.Compute(RootedAlgorithmBase`2<!!0,!!1>, !!0)
        }
        
        [PexMethod]
        [PexGenericArguments(new Type[]{typeof(int), typeof(int)})]
        public void SetRootVertex<TVertex,TGraph>(
            [PexAssumeNotNull]RootedAlgorithmBase<TVertex, TGraph> target,
            TVertex rootVertex
        )
        {
            target.SetRootVertex(rootVertex);
            // TODO: add assertions to method RootedAlgorithmBaseTVertexTGraphTest.SetRootVertex(RootedAlgorithmBase`2<!!0,!!1>, !!0)
        }
        
        [PexMethod]
        [PexGenericArguments(new Type[]{typeof(int), typeof(int)})]
        public bool TryGetRootVertex<TVertex,TGraph>(
            [PexAssumeNotNull]RootedAlgorithmBase<TVertex, TGraph> target,
            out TVertex rootVertex
        )
        {
            bool result = target.TryGetRootVertex(out rootVertex);
            return result;
            // TODO: add assertions to method RootedAlgorithmBaseTVertexTGraphTest.TryGetRootVertex(RootedAlgorithmBase`2<!!0,!!1>, !!0&)
        }
        
    }
}
