using System;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace AsyncTestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Caller();
        }

        private static void Caller()
        {
            Console.WriteLine("Caller A");
            Console.WriteLine("Caller B");

            MyMethodAsync(3); // 비동기처리 

            Console.WriteLine("Caller E");
            Console.WriteLine("Caller F");
        }

        // private static void MyMethodAsync(int count) // 동기처리
        private async static void MyMethodAsync(int count) // 비동기처리 
        {
            Console.WriteLine("My C");
            Console.WriteLine("My D");

            await Task.Run(async () =>
            {
                for (int i = 1; i <= count; i++)
                {
                    Console.WriteLine($"{i}/{count} ...");
                    await Task.Delay(10);
                }
            });

            Console.WriteLine("My G");
            Console.WriteLine("My H");
        }
    }
}
