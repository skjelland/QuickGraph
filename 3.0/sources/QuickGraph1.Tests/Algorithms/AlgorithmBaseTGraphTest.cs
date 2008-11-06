using Microsoft.Pex.Framework;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using QuickGraph.Algorithms;
using QuickGraph.Algorithms.Services;
using System;

namespace QuickGraph.Algorithms
{
    /// <summary>
    /// This class contains parameterized unit tests for AlgorithmBase`1
    /// </summary>
    [TestClass]
    [PexClass(typeof(AlgorithmBase<>))]
    public partial class AlgorithmBaseTGraphTest
    {
        [PexMethod]
        [PexGenericArguments(new Type[]{typeof(int)})]
        public void Abort<TGraph>([PexAssumeNotNull]AlgorithmBase<TGraph> target)
        {
            target.Abort();
            // TODO: add assertions to method AlgorithmBaseTGraphTest.Abort(AlgorithmBase`1<!!0>)
        }
        
        [PexMethod]
        [PexGenericArguments(new Type[]{typeof(int)})]
        public void Compute<TGraph>([PexAssumeNotNull]AlgorithmBase<TGraph> target)
        {
            target.Compute();
            // TODO: add assertions to method AlgorithmBaseTGraphTest.Compute(AlgorithmBase`1<!!0>)
        }
        
        [PexMethod]
        public void GetService<TGraph,T>([PexAssumeNotNull]AlgorithmBase<TGraph> target)
            where T : IService
        {
            T result = target.GetService<T>();
            PexStore.ValueForValidation<T>("result", result);
            // TODO: add assertions to method AlgorithmBaseTGraphTest.GetService(AlgorithmBase`1<!!0>)
        }
        
        [PexMethod]
        [PexGenericArguments(new Type[]{typeof(int)})]
        public void ServicesGet<TGraph>([PexAssumeNotNull]AlgorithmBase<TGraph> target)
        {
            IAlgorithmServices result = target.Services;
            PexStore.ValueForValidation<IAlgorithmServices>("result", result);
            // TODO: add assertions to method AlgorithmBaseTGraphTest.ServicesGet(AlgorithmBase`1<!!0>)
        }
        
        [PexMethod]
        [PexGenericArguments(new Type[]{typeof(int)})]
        public void StateGet<TGraph>([PexAssumeNotNull]AlgorithmBase<TGraph> target)
        {
            ComputationState result = target.State;
            PexStore.ValueForValidation<ComputationState>("result", result);
            // TODO: add assertions to method AlgorithmBaseTGraphTest.StateGet(AlgorithmBase`1<!!0>)
        }
        
        [PexMethod]
        [PexGenericArguments(new Type[]{typeof(int)})]
        public void SyncRootGet<TGraph>([PexAssumeNotNull]AlgorithmBase<TGraph> target)
        {
            object result = target.SyncRoot;
            PexStore.ValueForValidation<object>("result", result);
            // TODO: add assertions to method AlgorithmBaseTGraphTest.SyncRootGet(AlgorithmBase`1<!!0>)
        }
        
        [PexMethod]
        public bool TryGetService<TGraph,T>([PexAssumeNotNull]AlgorithmBase<TGraph> target, out T service)
            where T : IService
        {
            bool result = target.TryGetService<T>(out service);
            return result;
            // TODO: add assertions to method AlgorithmBaseTGraphTest.TryGetService(AlgorithmBase`1<!!0>, !!1&)
        }
        
        [PexMethod]
        [PexGenericArguments(new Type[]{typeof(int)})]
        public void VisitedGraphGet<TGraph>([PexAssumeNotNull]AlgorithmBase<TGraph> target)
        {
            TGraph result = target.VisitedGraph;
            PexStore.ValueForValidation<TGraph>("result", result);
            // TODO: add assertions to method AlgorithmBaseTGraphTest.VisitedGraphGet(AlgorithmBase`1<!!0>)
        }
        
    }
}
