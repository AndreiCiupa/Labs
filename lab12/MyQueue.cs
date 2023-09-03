using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab12
{
    public class MyQueue<T>
    {
        private T[] array;
        private int currentCount = 0;
        private readonly int capacity;

        public MyQueue(int capacity)
        {
            this.capacity = capacity;
            this.array = new T[capacity];
            currentCount = 0;
        }

        public int Count() { return this.currentCount; }

        public void Enqueue(T objectToAdd)
        {
            if (this.currentCount == this.capacity)
                return;

            this.array[currentCount] = objectToAdd;
            this.currentCount++;

        }

        public T Dequeue()
        {
            T theOneToDrop = this.array[0];

            for(int i = 0; i < this.capacity-1; ++i)
            {
                this.array[i] = this.array[i + 1];
            }
            this.currentCount--;
            return theOneToDrop;
        }

        //public void Afisare()
        //{
        //    for(int i = 0; i < this.capacity; ++i)
        //    {
        //        Console.WriteLine(this.array[i]);
        //    }
        //}
       
    }
}
