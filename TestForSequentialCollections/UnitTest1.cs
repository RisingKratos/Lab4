using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections;
using SequentialCollections;

namespace TestForSequentialCollections
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Queue myQueue = new Queue();
            myQueue.Enqueue("First");
            myQueue.Enqueue("Second");
            myQueue.Enqueue("Third");
            myQueue.Enqueue("Fourth");
            Assert.IsFalse(myQueue.Contains("C"));            
        }        
    }
}
