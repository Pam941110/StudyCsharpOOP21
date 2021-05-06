using System;
using System.Collections;

namespace CollectionTestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // 박싱 & 언박싱
            /*
            int a = 123;
            object obj = a;
            int b = (int)obj; // 언박싱

            Console.WriteLine("a의 값 : " + a);
            Console.WriteLine("obj의 값 : " + obj);
            Console.WriteLine("b의 값 : " + b);


            string str = "문자열임";
            obj = str;

            Console.WriteLine("str의 값 : " + str);
            Console.WriteLine("obj의 값 : " + obj);
            */

            //------
            Console.WriteLine("ArrayList 예제");

            ArrayList list = new ArrayList(); // 사이즈 지정X
            list.Add(3);
            list.Add(67);
            list.Add(1);
            list.Add(30);
            list.Add(14);

            foreach (var item in list)
            {
                Console.Write($"{item}\t");
            }

            list.Sort();  // Sort는 다 같은 타입이어야함
            foreach (var item in list)
            {
                Console.Write($"{item}\t");
            }
            Console.WriteLine();

            list.RemoveAt(5);
            foreach (var item in list)
            {
                Console.Write($"{item}\t");
            }
            Console.WriteLine();

            
        }
    }
}
