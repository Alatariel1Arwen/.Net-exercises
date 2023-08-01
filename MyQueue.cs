using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyQueueTests.ProjecMyQueue
{
    public class MyQueue<T>
    {
        private List<T> queueList;

        public MyQueue()
        {
            queueList = new List<T>();
        }

        public void Enqueue(T Item)
        {
            queueList.Add(Item);
        }

        public T Dequeue()
        {
            if (queueList.Count == 0)
            {
                throw new InvalidOperationException("The queue is empty.");
            }
            T item = queueList[0];
            queueList.RemoveAt(0);
            return item;
        }

        public T Peek()
        {
            if (queueList.Count == 0)
            {
                throw new InvalidOperationException("The queue is empty.");
            }

            return queueList[0];
        }
        public int Count
        {
            get { return queueList.Count; }
        }

        public void Clear()
        {
            queueList.Clear();
        }
    }
}
