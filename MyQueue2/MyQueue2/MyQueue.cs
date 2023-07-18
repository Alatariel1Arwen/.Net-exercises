using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FixExercise;

namespace FixExercise
{
    public class MyQueue<T>
    {
        public T[] array;
        private int firstElement;

        public MyQueue(int capacity)
        {
            array = new T[capacity];
            firstElement = -1;
        }

        public void Enqueue(T value)
        {
            if (firstElement == array.Length - 1)
            {
                throw new InvalidOperationException("The queue is full.");
            }
            array[++firstElement] = value;
        }

        public T Dequeue()
        {
            if (firstElement == -1)
            {
                throw new InvalidOperationException("The queue is empty.");
            }
            T item = array[0];
            Array.Copy(array, 1, array, 0, firstElement);
            array[firstElement--] = default(T);
            return item;
        }

        public T Peek()
        {
            if (firstElement == -1)
            {
                throw new InvalidOperationException("The queue is empty.");
            }

            return array[0];
        }
    }
}

