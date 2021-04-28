using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_TongHopCode
{
    /*
    class MyIntClass
    {
        public int Data { get; set; }
    }
    class MyDoubleClass
    {
        public double Data { get; set; }
    }

    */

    class MyGenericClass<T>
    {
        public T Data { get; set; }
    }
    class MyArray<T>
    {
        private T[] arr { get; set; }

        public void Init(int N)
        {
            this.arr = new T[N];
        }

        public void Set(int index, T value)
        {
            this.arr[index] = value;
        }
        public T Get(int index)
        {
            return this.arr[index];
        }
        public void Show()
        {
            for (int i = 0; i < this.arr.Length; i++)
            {
                Console.WriteLine(this.arr[i]);
            }
        }
    }
}
