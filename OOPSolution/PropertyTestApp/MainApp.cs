using System;

namespace PropertyTestApp
{
    class MainApp
    {
        static void Main(string[] args)
        {
            Console.WriteLine("강아지 객체 생성");
            Dog baekgoo = new Dog(); // 클래스 객체 선언 
            //baekgoo.SetAge(5);  // 5살

            //Console.WriteLine($"백구의 나이는 {baekgoo.GetAge()}살");

            baekgoo.name = "백구";
            baekgoo.age = 25000;
            Console.WriteLine($"{baekgoo.name}의 나이는 {baekgoo.age}살");

            Dog streetDog = new Dog();
            Console.WriteLine($"{streetDog.name}는 {streetDog.color}색 입니다.");

            Dog dog1 = new Dog();
            dog1.name = "황구";
            dog1.color = "노랑";
            dog1.age = 10;

            Dog dog2 = new()
            {
                name = "깜장이",
                age = 5,
                color = "검정"
            };

            var myInstance = new { name = "성명건", age = 44 };
            Console.WriteLine(myInstance.name);
            Console.WriteLine(myInstance.age);
        }
    }
}
