using System;
using System.Data;

namespace 연습문제
{
    class EX13_1
    {
        delegate int MyDelegate(int a, int b);

        static void Main(string[] args)
        {
            MyDelegate CallBack;

            CallBack = delegate (int a, int b) { return a + b; };
            Console.WriteLine(CallBack(3, 4));

            CallBack = delegate (int a, int b) { return a - b; };
            Console.WriteLine(CallBack(7, 5));
        }
    }
}
