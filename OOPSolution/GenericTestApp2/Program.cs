using System;

namespace GenericTestApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("일반화 !!!!! \n");

            int[] sourceInt = { 1, 2, 3, 4, 5 };
            int[] targetInt = new int[sourceInt.Length];
            Console.WriteLine("복사 전 targetInt 값 =======>");
            foreach (var item in targetInt)
            {
                Console.Write($"{item}\t");
            }
            Console.WriteLine();

            CopyArray<int>(sourceInt, targetInt);

            Console.WriteLine("복사 후 targetInt 값 =======>");
            foreach (var item in targetInt)
            {
                Console.Write($"{item}\t");
            }
            Console.WriteLine();

            string[] sourceString = { "하나", "둘", "셋", "넷", "다섯", "여섯" };
            string[] targetString = new string[sourceString.Length];

            Console.WriteLine("복사 전 targetString 값 =======>");
            foreach (var item in targetString)
            {
                Console.Write($"{item}\t");
            }
            Console.WriteLine();

            CopyArray<string>(sourceString, targetString);

            Console.WriteLine("복사 후 targetString 값 =======>");
            foreach (var item in targetString)
            {
                Console.Write($"{item}\t");
            }
            Console.WriteLine();
        }
        // 일반화 메서드 통일 
        private static void CopyArray<T>(T[] source, T[] target)
        {
            for (int i = 0; i < source.Length; i++)
                target[i] = source[i];
        }
    }
}
