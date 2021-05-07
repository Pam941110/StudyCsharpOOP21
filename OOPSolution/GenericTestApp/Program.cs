using System;

namespace GenericTestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // int배열을 int배열로 복사 
            int[] sourceInt = { 1, 2, 3, 4, 5 };
            int[] targetInt = new int[sourceInt.Length]; // 5개 int 배열
            // { 0,0,0,0,0}

            // 복사전
            Console.WriteLine("복사 전 targetInt 값 =======>");
            foreach (var item in targetInt)
            {
                Console.Write($"{item}\t");
            }
            Console.WriteLine();

            CopyArray(sourceInt, targetInt);

            // 복사 후 
            // {1,2,3,4,5}
            Console.WriteLine("복사 후 targetInt 값 =======>");
            foreach (var item in targetInt)
            {
                Console.Write($"{item}\t");
            }
            Console.WriteLine();

            // ====================================================
            float[] sourceFloat = { 1.2f, 2.3f, 3.4f, 5.6f, 7.8f };
            float[] targetFloat = new float[sourceInt.Length];

            // 복사전 
            Console.WriteLine("복사 전 targetFloat 값 =======>");
            foreach (var item in targetFloat)
            {
                Console.Write($"{item}\t");
            }
            Console.WriteLine();

            CopyArray(sourceFloat, targetFloat);

            // 복사 후 
            Console.WriteLine("복사 후 targetFloat 값 =======>");
            foreach (var item in targetFloat)
            {
                Console.Write($"{item}\t");
            }
            Console.WriteLine();

            //=================================================
            string[] sourceString = { "하나", "둘", "셋", "넷", "다섯", "여섯" };
            string[] targetString= new string[sourceString.Length];

            // 복사전
            // 문자열 초기값 == 없음
            Console.WriteLine("복사 전 targetString 값 =======>");
            foreach (var item in targetString)
            {
                Console.Write($"{item}\t");
            }
            Console.WriteLine();

            CopyArray(sourceString, targetString);

            // 복사 후 
            Console.WriteLine("복사 후 targetString 값 =======>");
            foreach (var item in targetString)
            {
                Console.Write($"{item}\t");
            }
            Console.WriteLine();

        }

        private static void CopyArray(int[] source, int[] target)
        {
            for (int i = 0; i < source.Length; i++)
                target[i] = source[i];
        }
        private static void CopyArray(float[] source, float[] target) // 오버로딩 (type이 달라)
        {
            for (int i = 0; i < source.Length; i++)
                target[i] = source[i];
        }
        private static void CopyArray(string[] source, string[] target) // 오버로딩 (type이 달라)
        {
            for (int i = 0; i < source.Length; i++)
                target[i] = source[i];
        }
    }
}
