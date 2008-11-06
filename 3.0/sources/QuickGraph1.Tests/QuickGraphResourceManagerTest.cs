using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Wizard;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using QuickGraph;
using System;
using System.Drawing;

namespace QuickGraph
{
    /// <summary>
    /// This class contains parameterized unit tests for QuickGraphResourceManager
    /// </summary>
    [TestClass]
    [PexClass(typeof(QuickGraphResourceManager))]
    public partial class QuickGraphResourceManagerTest
    {
        [PexMethod]
        public void DumpResources(string path)
        {
            QuickGraphResourceManager.DumpResources(path);
            // TODO: add assertions to method QuickGraphResourceManagerTest.DumpResources(String)
        }
        
        [PexMethod]
        public void GetBanner()
        {
            Image result = QuickGraphResourceManager.GetBanner();
            PexStore.ValueForValidation<Image>("result", result);
            PexDisposablePatterns.DisposeTwice((IDisposable)result);
            // TODO: add assertions to method QuickGraphResourceManagerTest.GetBanner()
        }
        
        [PexMethod]
        public void GetLogo()
        {
            Image result = QuickGraphResourceManager.GetLogo();
            PexStore.ValueForValidation<Image>("result", result);
            PexDisposablePatterns.DisposeTwice((IDisposable)result);
            // TODO: add assertions to method QuickGraphResourceManagerTest.GetLogo()
        }
        
    }
}
