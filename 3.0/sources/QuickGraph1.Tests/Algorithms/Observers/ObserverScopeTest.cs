using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Wizard;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using QuickGraph.Algorithms.Observers;
using System;

namespace QuickGraph.Algorithms.Observers
{
    /// <summary>
    /// This class contains parameterized unit tests for ObserverScope
    /// </summary>
    [TestClass]
    [PexClass(typeof(ObserverScope))]
    public partial class ObserverScopeTest
    {
        [PexMethod]
        [PexGenericArguments(new Type[]{typeof(int)})]
        public void Create<TAlgorithm>(TAlgorithm algorithm, IObserver<TAlgorithm> observer)
        {
            IDisposable result = ObserverScope.Create<TAlgorithm>(algorithm, observer);
            PexStore.ValueForValidation<IDisposable>("result", result);
            PexDisposablePatterns.DisposeTwice(result);
            // TODO: add assertions to method ObserverScopeTest.Create(!!0, IObserver`1<!!0>)
        }
        
    }
}
