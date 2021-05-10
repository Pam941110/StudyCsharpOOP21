using System;
using System.Reflection;

namespace ReflectionTestApp
{
    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public void PrintProfile() { Console.WriteLine($"{Age},{Name}"); }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            Type type = a.GetType(); // Int32
            Console.WriteLine("Field 타입 리스트 : ");
            FieldInfo[] fields = type.GetFields();

            foreach (var item in fields)
            {
                Console.WriteLine($"Type:{item.FieldType.Name}, Name:{item.Name}");
            }


        }
    }
}
