using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trezeo_Assignment
{
    public class Lifo<T>
    {
        int capacity;
        T[] stack;
        int top;

        public Lifo(int size)
        {
            capacity = size;
            stack = new T[capacity];
        }

        public void Push(T item)
        {
            if (top != capacity - 1)
            {
                top = top + 1;
                stack[top] = item;
            }
        }
        public T Pop()
        {
            T RemovedElement;
            T temp = default(T);
            if (!(top <= 0))
            {
                RemovedElement = stack[top];
                top = top - 1;
                return RemovedElement;
            }
            return temp;
        }

        public int Count()
        {
            return top;
        }
    }

    public class Fifo<T>
    {
        private Lifo<T> _lifo1;
        private Lifo<T> _lifo2;
        public Fifo(int size)
        {
            _lifo1 = new Lifo<T>(size);
            _lifo2 = new Lifo<T>(size);
        }

        public void Enqueue(T item)
        {
            _lifo1.Push(item);
        }

        public T Dequeue()
        {
            if (_lifo1.Count() > 0)
            {
                _lifo2.Push(_lifo1.Pop());
            }
            return _lifo2.Pop();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Fifo<int> queue = new Fifo<int>(100);
            queue.Enqueue(100);
            queue.Enqueue(200);
            Console.WriteLine(queue.Dequeue());
            queue.Enqueue(300);
            queue.Enqueue(400);
            Console.WriteLine(queue.Dequeue());
            Console.WriteLine(queue.Dequeue());
            Console.WriteLine(queue.Dequeue());
            Console.WriteLine(queue.Dequeue());
            Console.ReadLine();
        }
    }
}
