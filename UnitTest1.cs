using MyQueueTests.ProjecMyQueue;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;

namespace MyQueueTests
{
    [TestClass]
    public class MyQueueTests
    {
        [TestMethod]
        public void Enqueue_AddsItemToQueue()
        {

            var myQueue = new MyQueue<int>();
            int item = 10;

            myQueue.Enqueue(item);

            Assert.AreEqual(1, myQueue.Count);
        }

        [TestMethod]
        public void Dequeue_RemovesAndReturnsItemFromQueue()
        {

            var myQueue = new MyQueue<int>();
            myQueue.Enqueue(10);
            myQueue.Enqueue(20);

            int dequeuedItem = myQueue.Dequeue();

            Assert.AreEqual(10, dequeuedItem);
            Assert.AreEqual(1, myQueue.Count);
        }

        [TestMethod]
        public void Dequeue_EmptyQueue_ThrowsInvalidOperationException()
        {
            var myQueue = new MyQueue<int>();

            Assert.ThrowsException<InvalidOperationException>(() => myQueue.Dequeue());
        }

        [TestMethod]
        public void Peek_ReturnsItemFromQueueWithoutRemovingIt()
        {

            var myQueue = new MyQueue<int>();
            myQueue.Enqueue(10);
            myQueue.Enqueue(20);

            int peekedItem = myQueue.Peek();

            Assert.AreEqual(10, peekedItem);
            Assert.AreEqual(2, myQueue.Count);
        }

        [TestMethod]
        public void Peek_EmptyQueue_ThrowsInvalidOperationException()
        {

            var myQueue = new MyQueue<int>();

            Assert.ThrowsException<InvalidOperationException>(() => myQueue.Peek());
        }

        [TestMethod]
        public void Clear_RemovesAllItemsFromQueue()
        {

            var myQueue = new MyQueue<int>();
            myQueue.Enqueue(10);
            myQueue.Enqueue(20);

            myQueue.Clear();

            Assert.AreEqual(0, myQueue.Count);
        }
    }

}
