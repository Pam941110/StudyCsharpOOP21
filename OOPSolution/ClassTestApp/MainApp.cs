using System;
using System.Runtime.ExceptionServices;

namespace ClassTestApp
{
    class MainApp
    {

        static void Main(string[] args)
        {
            Console.WriteLine("고양아 객체 생성");

            Cat kitty = new Cat("키티",3); // 기본생성자
            //kitty.Name = "키티";
            kitty.Age = 3;
            kitty.Color = "하얀색";
            kitty.Meow();

            /*Cat nero = new Cat  // 기본생성자
            {
                Name = "네로",
                Age = 12,
                Color = "검정색"
            }; 
            nero.Meow();
            */

            Cat nero = new Cat("네로 " , "검정");
            nero.Meow();

            Cat mimi = new Cat("미미 " , "노랑", 3); // 추가생성자
            mimi.Meow();

            Cat coco = new Cat("코코 " , "얼룩이");
            coco.Age = 2; 
            coco.Meow();

            Cat noname = new Cat("야옹이 " , "은색", 10);
            //noname.Name = "야옹아~";
            noname.Meow();
            noname.Sleep();

            

            var list = (First :"Cat", Second :"Dog", "Pig",55);
            Console.Write($"튜플 첫번째 :{list.Item1}");
            Console.Write($"튜플 두번째 :{list.Item2}");
            Console.Write($"튜플 세번째 :{list.Item3}");
            Console.Write($"튜플 네번째 :{list.Item4}");

        }
    }
}
