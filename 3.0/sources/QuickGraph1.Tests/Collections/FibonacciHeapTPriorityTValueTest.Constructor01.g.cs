// This file contains automatically generated unit tests.
// Do NOT modify this file manually.
// 
// When Pex is invoked again,
// it might remove or update any previously generated unit tests.
// 
// If the contents of this file becomes outdated, e.g. if it does not
// compile anymore, you may delete this file and invoke Pex again.
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.Pex.Framework.Generated;

namespace QuickGraph.Collections
{
    public partial class FibonacciHeapTPriorityTValueTest
    {
        [TestMethod]
        [PexGeneratedBy(typeof(FibonacciHeapTPriorityTValueTest))]
        public void Constructor0101()
        {
            FibonacciHeap<int, int> fibonacciHeap;
            fibonacciHeap = this.Constructor01<int, int>(HeapDirection.Increasing);
            // validation of result values is supported for primitive types only
        }

        [TestMethod]
        [PexGeneratedBy(typeof(FibonacciHeapTPriorityTValueTest))]
        public void Constructor0102()
        {
            FibonacciHeap<int, int> fibonacciHeap;
            fibonacciHeap = this.Constructor01<int, int>(HeapDirection.Decreasing);
            // validation of result values is supported for primitive types only
        }

    }
}
