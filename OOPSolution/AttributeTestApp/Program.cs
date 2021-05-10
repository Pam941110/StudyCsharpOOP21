using System;
using System.Dynamic;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace AttributeTestApp // attribute는 컴파일러가 쓰는 주석이야
{
    class Program
    {
        public class MyClass
        {
            [Obsolete("OldMethod는 폐기되었습니다. NewMethod를 이용하세요.")]
            public void OldMethod(){Console.WriteLine("I'm old");} // OldMethod 사용하지 x 메세지 전달 (주의! 못 쓰는게 x, 안 쓰는 것 o)
            public void NewMethod(){Console.WriteLine("I'm new");}

            public int Plus (int a, int b) { return a + b; }

        }
        static void Main(string[] args)
        {
            MyClass mine = new MyClass();
            mine.OldMethod(); // 메세지 
            mine.NewMethod();

            var result = mine.Plus(3, 5);
            Console.WriteLine(result);
        }
    }
}
