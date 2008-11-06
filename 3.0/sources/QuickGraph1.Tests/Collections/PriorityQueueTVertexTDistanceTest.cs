using Microsoft.Pex.Framework;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using QuickGraph.Collections;
using System;
using System.Collections.Generic;

namespace QuickGraph.Collections
{
    /// <summary>
    /// This class contains parameterized unit tests for PriorityQueue`2
    /// </summary>
    [TestClass]
    [PexClass(typeof(PriorityQueue<, >))]
    public partial class PriorityQueueTVertexTDistanceTest
    {
        [PexMethod]
        [PexGenericArguments(new Type[]{typeof(int), typeof(int)})]
        public PriorityQueue<TVertex, TDistance> Constructor<TVertex,TDistance>(IDictionary<TVertex, TDistance> distances)
        {
            PriorityQueue<TVertex, TDistance> target
               = new PriorityQueue<TVertex, TDistance>(distances);
            return target;
            // TODO: add assertions to method PriorityQueueTVertexTDistanceTest.Constructor(IDictionary`2<!!0,!!1>)
        }
        
        [PexMethod]
        [PexGenericArguments(new Type[]{typeof(int), typeof(int)})]
        public bool Contains<TVertex,TDistance>([PexAssumeUnderTest]PriorityQueue<TVertex, TDistance> target, TVertex value)
        {
            bool result = target.Contains(value);
            return result;
            // TODO: add assertions to method PriorityQueueTVertexTDistanceTest.Contains(PriorityQueue`2<!!0,!!1>, !!0)
        }
        
        [PexMethod]
        [PexGenericArguments(new Type[]{typeof(int), typeof(int)})]
        public void CountGet<TVertex,TDistance>([PexAssumeUnderTest]PriorityQueue<TVertex, TDistance> target)
        {
            int result = target.Count;
            PexStore.ValueForValidation<int>("result", result);
            // TODO: add assertions to method PriorityQueueTVertexTDistanceTest.CountGet(PriorityQueue`2<!!0,!!1>)
        }
        
        [PexMethod]
        [PexGenericArguments(new Type[]{typeof(int), typeof(int)})]
        public void Dequeue<TVertex,TDistance>([PexAssumeUnderTest]PriorityQueue<TVertex, TDistance> target)
        {
            TVertex result = target.Dequeue();
            PexStore.ValueForValidation<TVertex>("result", result);
            // TODO: add assertions to method PriorityQueueTVertexTDistanceTest.Dequeue(PriorityQueue`2<!!0,!!1>)
        }
        
        [PexMethod]
        [PexGenericArguments(new Type[]{typeof(int), typeof(int)})]
        public void Enqueue<TVertex,TDistance>([PexAssumeUnderTest]PriorityQueue<TVertex, TDistance> target, TVertex value)
        {
            target.Enqueue(value);
            // TODO: add assertions to method PriorityQueueTVertexTDistanceTest.Enqueue(PriorityQueue`2<!!0,!!1>, !!0)
        }
        
        [PexMethod]
        [PexGenericArguments(new Type[]{typeof(int), typeof(int)})]
        public void Peek<TVertex,TDistance>([PexAssumeUnderTest]PriorityQueue<TVertex, TDistance> target)
        {
            TVertex result = target.Peek();
            PexStore.ValueForValidation<TVertex>("result", result);
            // TODO: add assertions to method PriorityQueueTVertexTDistanceTest.Peek(PriorityQueue`2<!!0,!!1>)
        }
        
        [PexMethod]
        [PexGenericArguments(new Type[]{typeof(int), typeof(int)})]
        public void ToArray<TVertex,TDistance>([PexAssumeUnderTest]PriorityQueue<TVertex, TDistance> target)
        {
            TVertex[] result = target.ToArray();
            PexStore.ValueForValidation<TVertex[]>("result", result);
            // TODO: add assertions to method PriorityQueueTVertexTDistanceTest.ToArray(PriorityQueue`2<!!0,!!1>)
        }
        
        [PexMethod]
        [PexGenericArguments(new Type[]{typeof(int), typeof(int)})]
        public void Update<TVertex,TDistance>([PexAssumeUnderTest]PriorityQueue<TVertex, TDistance> target, TVertex v)
        {
            target.Update(v);
            // TODO: add assertions to method PriorityQueueTVertexTDistanceTest.Update(PriorityQueue`2<!!0,!!1>, !!0)
        }
        
    }
}
