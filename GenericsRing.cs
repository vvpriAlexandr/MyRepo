using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visualka
{
    interface IRing<T>  
    {
        void Push(T item);
        T Head();
        T Get(int index);
        int Count();
    
    }

    interface Itest
    {
        int hello();
    }
    public class GenericsRing<T> : IRing<T>, Itest
    {
        private T[] elements;
        private int position;
        public int colvo;

        public int hello()
        {
           return 1;
        }
        public GenericsRing(int size)
        {
            elements = new T[size];
            position = 0;
        }

        public void Push(T item)
        {
            elements[position] = item;
            position = (position + 1);
            colvo++;
        }

        public T Head()
        {
            int actualIndex = (position - 1);
            return elements[actualIndex];
        }

        public T Get(int index)
        {
            return elements[index - 1];
        }
     
        public int Count()
        {
          return colvo;
        }
    }
}
