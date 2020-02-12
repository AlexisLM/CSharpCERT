using System;
using System.Collections.Generic;
using System.Text;

namespace ClasesGenericas
{
    class Stack <T>
    {
        private int position;
        private T[] data;

        public Stack()
        {
            data = new T[10];
        }

        public Stack(int size)
        {
            data = new T[size];
        }

        public void Push(T obj)
        {
            data[position++] = obj;
        }

        public T Pop()
        {
            return data[--position];
        }
    }
}
