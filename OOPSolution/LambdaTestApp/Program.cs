using System;

namespace LambdaTestApp
{
    class Program
    {
        delegate void DoSomething(string name);

        static void Main(string[] args)
        {
            DoSomething doit = (name) =>
             {
                 Console.WriteLine("Hello");
                 Console.WriteLine($"{name}~!");
             };
            string name = "Pam";

            doit(name);

            Action<int> area = (r) =>   // return 값이 없음.
            {
                Console.WriteLine($"원의 넓이는 {(double)r * r * Math.PI}");
            };
            area(10);
        }
    }
}
