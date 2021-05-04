using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassTestApp
{
    class Cat : Animal
    {
        // public string Name { get; set; }
        public string Color { get; set; }        
        public int Age { get; set; }

        public Cat() { /*Nothing*/}  // 기본 생성자 (선언하지 않아도 컴파일러에서 생성자를 만들어줌!)

        public Cat(string name, string color, int age) // 추가 생성자 
        {
            // Initalization (초기화) 
            this.Name = name;
            this.Color = color;
            this.Age = age;
        }

        public Cat (string name, string color)
        {
            // 초기화
            this.Name = name;
            this.Color = color;
        }

        public Cat(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }
            public void Meow() { Console.WriteLine($"{this.Color}{this.Name},야옹!"); }

        public override void Sleep()
        {
            base.Sleep();  // 부모의 Sleep() 실행 : 부모 메서드 사용 하고 싶을 때만 사용
            // 이후 자식 클래스의 Sleep 내용 실행
            Console.WriteLine($"{this.Color} 고양이 {this.Name}이(가) ZZ 잡니다/");  // 재정의
        }
    }
}
