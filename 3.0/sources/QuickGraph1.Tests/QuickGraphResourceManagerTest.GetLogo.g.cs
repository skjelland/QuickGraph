// This file contains automatically generated unit tests.
// Do NOT modify this file manually.
// 
// When Pex is invoked again,
// it might remove or update any previously generated unit tests.
// 
// If the contents of this file becomes outdated, e.g. if it does not
// compile anymore, you may delete this file and invoke Pex again.
using System;
using Microsoft.Pex.Framework;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.Pex.Framework.Generated;

namespace QuickGraph
{
    public partial class QuickGraphResourceManagerTest
    {
        [TestMethod]
        [PexGeneratedBy(typeof(QuickGraphResourceManagerTest))]
        public void GetLogo01()
        {
            PexStore.Generated.Clear();
            this.GetLogo();
            PexStore.Generated.Validate("result", "new Bitmap{}");
        }

    }
}
