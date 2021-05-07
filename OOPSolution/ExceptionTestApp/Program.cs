using System;

namespace ExceptionTestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("!!! 예외발생 !!!\n");

            int[] array = new int[5];
           
            try
            {
            for (int i = 0; i <= 5; i++)
                array[i] = (i + 1);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message); // 메세지만 출력 
            }
            Console.WriteLine("다른 로직 수행");
        }
    }
}
