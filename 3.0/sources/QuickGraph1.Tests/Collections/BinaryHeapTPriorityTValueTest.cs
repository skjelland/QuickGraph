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
    /// This class contains parameterized unit tests for BinaryHeap`2
    /// </summary>
    [TestClass]
    [PexClass(typeof(BinaryHeap<, >))]
    public partial class BinaryHeapTPriorityTValueTest
    {
        [PexMethod]
        [PexGenericArguments(new Type[]{typeof(int), typeof(int)})]
        public void Add<TPriority,TValue>(
            [PexAssumeUnderTest]BinaryHeap<TPriority, TValue> target,
            TPriority priority,
            TValue value
        )
        {
            target.Add(priority, value);
            // TODO: add assertions to method BinaryHeapTPriorityTValueTest.Add(BinaryHeap`2<!!0,!!1>, !!0, !!1)
        }
        
        [PexMethod]
        [PexGenericArguments(new Type[]{typeof(int), typeof(int)})]
        public void CapacityGet<TPriority,TValue>([PexAssumeUnderTest]BinaryHeap<TPriority, TValue> target)
        {
            int result = target.Capacity;
            PexStore.ValueForValidation<int>("result", result);
            // TODO: add assertions to method BinaryHeapTPriorityTValueTest.CapacityGet(BinaryHeap`2<!!0,!!1>)
        }
        
        [PexMethod]
        [PexGenericArguments(new Type[]{typeof(int), typeof(int)})]
        public BinaryHeap<TPriority, TValue> Constructor<TPriority,TValue>()
        {
            BinaryHeap<TPriority, TValue> target = new BinaryHeap<TPriority, TValue>();
            PexEnumerablePatterns.ForEach<KeyValuePair<TPriority, TValue>>
                ((IEnumerable<KeyValuePair<TPriority, TValue>>)target);
            PexEnumerablePatterns.ForEach((IEnumerable)target);
            PexEnumerablePatterns.DoubleForEach<KeyValuePair<TPriority, TValue>>
                ((IEnumerable<KeyValuePair<TPriority, TValue>>)target);
            PexEnumerablePatterns.MoveNextAndReset<KeyValuePair<TPriority, TValue>>
                ((IEnumerable<KeyValuePair<TPriority, TValue>>)target);
            return target;
            // TODO: add assertions to method BinaryHeapTPriorityTValueTest.Constructor()
        }
        
        [PexMethod]
        [PexGenericArguments(new Type[]{typeof(int), typeof(int)})]
        public void CountGet<TPriority,TValue>([PexAssumeUnderTest]BinaryHeap<TPriority, TValue> target)
        {
            int result = target.Count;
            PexStore.ValueForValidation<int>("result", result);
            // TODO: add assertions to method BinaryHeapTPriorityTValueTest.CountGet(BinaryHeap`2<!!0,!!1>)
        }
        
        [PexMethod]
        [PexGenericArguments(new Type[]{typeof(int), typeof(int)})]
        public void GetEnumerator<TPriority,TValue>([PexAssumeUnderTest]BinaryHeap<TPriority, TValue> target)
        {
            IEnumerator<KeyValuePair<TPriority, TValue>> result = target.GetEnumerator();
            PexStore.ValueForValidation<IEnumerator<KeyValuePair<TPriority, TValue>>>
                ("result", result);
            PexDisposablePatterns.DisposeTwice((IDisposable)result);
            // TODO: add assertions to method BinaryHeapTPriorityTValueTest.GetEnumerator(BinaryHeap`2<!!0,!!1>)
        }
        
        [PexMethod]
        [PexGenericArguments(new Type[]{typeof(int), typeof(int)})]
        public int IndexOf<TPriority,TValue>([PexAssumeUnderTest]BinaryHeap<TPriority, TValue> target, TValue value)
        {
            int result = target.IndexOf(value);
            return result;
            // TODO: add assertions to method BinaryHeapTPriorityTValueTest.IndexOf(BinaryHeap`2<!!0,!!1>, !!1)
        }
        
        [PexMethod]
        [PexGenericArguments(new Type[]{typeof(int), typeof(int)})]
        public void Minimum<TPriority,TValue>([PexAssumeUnderTest]BinaryHeap<TPriority, TValue> target)
        {
            KeyValuePair<TPriority, TValue> result = target.Minimum();
            PexStore.ValueForValidation<KeyValuePair<TPriority, TValue>>("result", result);
            // TODO: add assertions to method BinaryHeapTPriorityTValueTest.Minimum(BinaryHeap`2<!!0,!!1>)
        }
        
        [PexMethod]
        [PexGenericArguments(new Type[]{typeof(int), typeof(int)})]
        public void ObjectInvariant<TPriority,TValue>([PexAssumeUnderTest]BinaryHeap<TPriority, TValue> target)
        {
            target.ObjectInvariant();
            // TODO: add assertions to method BinaryHeapTPriorityTValueTest.ObjectInvariant(BinaryHeap`2<!!0,!!1>)
        }
        
        [PexMethod]
        [PexGenericArguments(new Type[]{typeof(int), typeof(int)})]
        public void PriorityComparisonGet<TPriority,TValue>([PexAssumeUnderTest]BinaryHeap<TPriority, TValue> target)
        {
            Comparison<TPriority> result = target.PriorityComparison;
            PexStore.ValueForValidation<Comparison<TPriority>>("result", result);
            // TODO: add assertions to method BinaryHeapTPriorityTValueTest.PriorityComparisonGet(BinaryHeap`2<!!0,!!1>)
        }
        
        [PexMethod]
        [PexGenericArguments(new Type[]{typeof(int), typeof(int)})]
        public void RemoveAt<TPriority,TValue>([PexAssumeUnderTest]BinaryHeap<TPriority, TValue> target, int index)
        {
            KeyValuePair<TPriority, TValue> result = target.RemoveAt(index);
            PexStore.ValueForValidation<KeyValuePair<TPriority, TValue>>("result", result);
            // TODO: add assertions to method BinaryHeapTPriorityTValueTest.RemoveAt(BinaryHeap`2<!!0,!!1>, Int32)
        }
        
        [PexMethod]
        [PexGenericArguments(new Type[]{typeof(int), typeof(int)})]
        public void RemoveMinimum<TPriority,TValue>([PexAssumeUnderTest]BinaryHeap<TPriority, TValue> target)
        {
            KeyValuePair<TPriority, TValue> result = target.RemoveMinimum();
            PexStore.ValueForValidation<KeyValuePair<TPriority, TValue>>("result", result);
            // TODO: add assertions to method BinaryHeapTPriorityTValueTest.RemoveMinimum(BinaryHeap`2<!!0,!!1>)
        }
        
        [PexMethod]
        [PexGenericArguments(new Type[]{typeof(int), typeof(int)})]
        public void ToValueArray<TPriority,TValue>([PexAssumeUnderTest]BinaryHeap<TPriority, TValue> target)
        {
            TValue[] result = target.ToValueArray();
            PexStore.ValueForValidation<TValue[]>("result", result);
            // TODO: add assertions to method BinaryHeapTPriorityTValueTest.ToValueArray(BinaryHeap`2<!!0,!!1>)
        }
        
        [PexMethod]
        [PexGenericArguments(new Type[]{typeof(int), typeof(int)})]
        public void Update<TPriority,TValue>(
            [PexAssumeUnderTest]BinaryHeap<TPriority, TValue> target,
            TPriority priority,
            TValue value
        )
        {
            target.Update(priority, value);
            // TODO: add assertions to method BinaryHeapTPriorityTValueTest.Update(BinaryHeap`2<!!0,!!1>, !!0, !!1)
        }
        
    }
}
