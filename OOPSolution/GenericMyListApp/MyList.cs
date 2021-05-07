using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericMyListApp
{
    // 일반화 클래스
    class MyList<T> { 
        private T[] array;

        public MyList()
        {array = new T[3];}

        public T this[int index]
        {
            get { return array[index]; }
            set { array[index] = value;}
        }

        public int Length { get { return array.Length; } }
    }
}
