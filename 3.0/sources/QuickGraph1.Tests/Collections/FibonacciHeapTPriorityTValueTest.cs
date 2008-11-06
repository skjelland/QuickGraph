using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Wizard;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using QuickGraph.Collections;
using System;
using System.Collections;
using System.Collections.Generic;

namespace QuickGraph.Collections
{
    /// <summary>
    /// This class contains parameterized unit tests for FibonacciHeap`2
    /// </summary>
    [TestClass]
    [PexClass(typeof(FibonacciHeap<, >))]
    public partial class FibonacciHeapTPriorityTValueTest
    {
        [PexMethod]
        [PexGenericArguments(new Type[]{typeof(int), typeof(int)})]
        public void ChangeKey<TPriority,TValue>(
            [PexAssumeUnderTest]FibonacciHeap<TPriority, TValue> target,
            FibonacciHeapCell<TPriority, TValue> Node,
            TPriority NewKey
        )
        {
            target.ChangeKey(Node, NewKey);
            // TODO: add assertions to method FibonacciHeapTPriorityTValueTest.ChangeKey(FibonacciHeap`2<!!0,!!1>, FibonacciHeapCell`2<!!0,!!1>, !!0)
        }
        
        [PexMethod]
        [PexGenericArguments(new Type[]{typeof(int), typeof(int)})]
        public FibonacciHeap<TPriority, TValue> Constructor<TPriority,TValue>()
        {
            FibonacciHeap<TPriority, TValue> target = new FibonacciHeap<TPriority, TValue>()
              ;
            PexEnumerablePatterns.ForEach<FibonacciHeapCell<TPriority, TValue>>
                ((IEnumerable<FibonacciHeapCell<TPriority, TValue>>)target);
            PexEnumerablePatterns.ForEach((IEnumerable)target);
            PexEnumerablePatterns.DoubleForEach<FibonacciHeapCell<TPriority, TValue>>
                ((IEnumerable<FibonacciHeapCell<TPriority, TValue>>)target);
            PexEnumerablePatterns.MoveNextAndReset<FibonacciHeapCell<TPriority, TValue>>
                ((IEnumerable<FibonacciHeapCell<TPriority, TValue>>)target);
            return target;
            // TODO: add assertions to method FibonacciHeapTPriorityTValueTest.Constructor()
        }
        
        [PexMethod]
        [PexGenericArguments(new Type[]{typeof(int), typeof(int)})]
        public FibonacciHeap<TPriority, TValue> Constructor01<TPriority,TValue>(HeapDirection Direction)
        {
            FibonacciHeap<TPriority, TValue> target
               = new FibonacciHeap<TPriority, TValue>(Direction);
            PexEnumerablePatterns.ForEach<FibonacciHeapCell<TPriority, TValue>>
                ((IEnumerable<FibonacciHeapCell<TPriority, TValue>>)target);
            PexEnumerablePatterns.ForEach((IEnumerable)target);
            PexEnumerablePatterns.DoubleForEach<FibonacciHeapCell<TPriority, TValue>>
                ((IEnumerable<FibonacciHeapCell<TPriority, TValue>>)target);
            PexEnumerablePatterns.MoveNextAndReset<FibonacciHeapCell<TPriority, TValue>>
                ((IEnumerable<FibonacciHeapCell<TPriority, TValue>>)target);
            return target;
            // TODO: add assertions to method FibonacciHeapTPriorityTValueTest.Constructor01(HeapDirection)
        }
        
        [PexMethod]
        [PexGenericArguments(new Type[]{typeof(int), typeof(int)})]
        public void CountGet<TPriority,TValue>([PexAssumeUnderTest]FibonacciHeap<TPriority, TValue> target)
        {
            int result = target.Count;
            PexStore.ValueForValidation<int>("result", result);
            // TODO: add assertions to method FibonacciHeapTPriorityTValueTest.CountGet(FibonacciHeap`2<!!0,!!1>)
        }
        
        [PexMethod]
        [PexGenericArguments(new Type[]{typeof(int), typeof(int)})]
        public void Delete<TPriority,TValue>(
            [PexAssumeUnderTest]FibonacciHeap<TPriority, TValue> target,
            FibonacciHeapCell<TPriority, TValue> Node
        )
        {
            target.Delete(Node);
            // TODO: add assertions to method FibonacciHeapTPriorityTValueTest.Delete(FibonacciHeap`2<!!0,!!1>, FibonacciHeapCell`2<!!0,!!1>)
        }
        
        [PexMethod]
        [PexGenericArguments(new Type[]{typeof(int), typeof(int)})]
        public void Dequeue<TPriority,TValue>([PexAssumeUnderTest]FibonacciHeap<TPriority, TValue> target)
        {
            target.Dequeue();
            // TODO: add assertions to method FibonacciHeapTPriorityTValueTest.Dequeue(FibonacciHeap`2<!!0,!!1>)
        }
        
        [PexMethod]
        [PexGenericArguments(new Type[]{typeof(int), typeof(int)})]
        public void DirectionGet<TPriority,TValue>([PexAssumeUnderTest]FibonacciHeap<TPriority, TValue> target)
        {
            HeapDirection result = target.Direction;
            PexStore.ValueForValidation<HeapDirection>("result", result);
            // TODO: add assertions to method FibonacciHeapTPriorityTValueTest.DirectionGet(FibonacciHeap`2<!!0,!!1>)
        }
        
        [PexMethod]
        [PexGenericArguments(new Type[]{typeof(int), typeof(int)})]
        public string DrawHeap<TPriority,TValue>([PexAssumeUnderTest]FibonacciHeap<TPriority, TValue> target)
        {
            string result = target.DrawHeap();
            return result;
            // TODO: add assertions to method FibonacciHeapTPriorityTValueTest.DrawHeap(FibonacciHeap`2<!!0,!!1>)
        }
        
        [PexMethod]
        [PexGenericArguments(new Type[]{typeof(int), typeof(int)})]
        public void Enqueue<TPriority,TValue>(
            [PexAssumeUnderTest]FibonacciHeap<TPriority, TValue> target,
            TPriority Priority,
            TValue Value
        )
        {
            FibonacciHeapCell<TPriority, TValue> result = target.Enqueue(Priority, Value);
            PexStore.ValueForValidation<FibonacciHeapCell<TPriority, TValue>>
                ("result", result);
            // TODO: add assertions to method FibonacciHeapTPriorityTValueTest.Enqueue(FibonacciHeap`2<!!0,!!1>, !!0, !!1)
        }
        
        [PexMethod]
        [PexGenericArguments(new Type[]{typeof(int), typeof(int)})]
        public void GetDestructiveEnumerator<TPriority,TValue>([PexAssumeUnderTest]FibonacciHeap<TPriority, TValue> target)
        {
            IEnumerable<FibonacciHeapCell<TPriority, TValue>> result
               = target.GetDestructiveEnumerator();
            PexStore.ValueForValidation<IEnumerable<FibonacciHeapCell<TPriority, TValue>>>
                ("result", result);
            PexEnumerablePatterns.ForEach<FibonacciHeapCell<TPriority, TValue>>(result);
            PexEnumerablePatterns.ForEach((IEnumerable)result);
            PexEnumerablePatterns.DoubleForEach<FibonacciHeapCell<TPriority, TValue>>
                (result);
            PexEnumerablePatterns.MoveNextAndReset<FibonacciHeapCell<TPriority, TValue>>
                (result);
            // TODO: add assertions to method FibonacciHeapTPriorityTValueTest.GetDestructiveEnumerator(FibonacciHeap`2<!!0,!!1>)
        }
        
        [PexMethod]
        [PexGenericArguments(new Type[]{typeof(int), typeof(int)})]
        public void GetEnumerator<TPriority,TValue>([PexAssumeUnderTest]FibonacciHeap<TPriority, TValue> target)
        {
            IEnumerator<FibonacciHeapCell<TPriority, TValue>> result
               = target.GetEnumerator();
            PexStore.ValueForValidation<IEnumerator<FibonacciHeapCell<TPriority, TValue>>>
                ("result", result);
            PexDisposablePatterns.DisposeTwice((IDisposable)result);
            // TODO: add assertions to method FibonacciHeapTPriorityTValueTest.GetEnumerator(FibonacciHeap`2<!!0,!!1>)
        }
        
        [PexMethod]
        [PexGenericArguments(new Type[]{typeof(int), typeof(int)})]
        public void IsEmptyGet<TPriority,TValue>([PexAssumeUnderTest]FibonacciHeap<TPriority, TValue> target)
        {
            bool result = target.IsEmpty;
            PexStore.ValueForValidation<bool>("result", result);
            // TODO: add assertions to method FibonacciHeapTPriorityTValueTest.IsEmptyGet(FibonacciHeap`2<!!0,!!1>)
        }
        
        [PexMethod]
        [PexGenericArguments(new Type[]{typeof(int), typeof(int)})]
        public void Merge<TPriority,TValue>(
            [PexAssumeUnderTest]FibonacciHeap<TPriority, TValue> target,
            FibonacciHeap<TPriority, TValue> Other
        )
        {
            target.Merge(Other);
            // TODO: add assertions to method FibonacciHeapTPriorityTValueTest.Merge(FibonacciHeap`2<!!0,!!1>, FibonacciHeap`2<!!0,!!1>)
        }
        
        [PexMethod]
        [PexGenericArguments(new Type[]{typeof(int), typeof(int)})]
        public void TopGet<TPriority,TValue>([PexAssumeUnderTest]FibonacciHeap<TPriority, TValue> target)
        {
            FibonacciHeapCell<TPriority, TValue> result = target.Top;
            PexStore.ValueForValidation<FibonacciHeapCell<TPriority, TValue>>
                ("result", result);
            // TODO: add assertions to method FibonacciHeapTPriorityTValueTest.TopGet(FibonacciHeap`2<!!0,!!1>)
        }
        
    }
}
