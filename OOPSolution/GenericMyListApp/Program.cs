using System;

namespace GenericMyListApp
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<int> list = new MyList<int>(); // 사용하고 싶은 type 여기서 지정!
            for (int i = 0; i < list.Length; i++)
            {
                list[i] = 100;
            }

            for (int i = 0; i < list.Length; i++)
            {
                Console.Write($"{list[i]}\t");
            }

            MyList<string> strList = new MyList<string>(); // 사용하고 싶은 type 여기서 지정!
            for (int i = 0; i < strList.Length; i++)
            {
                strList[i] = "Hello_" + (i + 1);
            }
            for (int i = 0; i < strList.Length; i++)
            {
                Console.Write($"{strList[i]}\t");
            }
        }
    }
}
