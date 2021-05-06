using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyTestApp
{
    class Dog
    {
        private int Age;
        private string Name;

        // 자동구현 프로퍼티
        public string name { get; set; } = "멍멍이"; // 초기값 지정 
        public string color { get; set; } = "누런";

        public int age
        {
            get
            {
                return this.Age;
            }
            set
            {
                if (value<0)
                {
                    this.Age = 1;
                }
                else if (value>15)
                {
                    this.Age = 15;
                }
                else
                {
                    this.Age = value;
                }
                this.Age = value;
            }
        }
        /*
        public string GetName() { return this.Name; }

        public void SetName(string name) { this.Name = name; }

        // 값을 사용
        public int GetAge() { return this.Age; }

        // 값을 설정 
        public void SetAge(int age) 
        {
            // 잘못된 값이 들어가지 않도록 설정 
            if (age < 0)
            {
                this.Age = 1;
            }
            else if (age > 15)
            {
                this.Age = 15;
            }
            else
            {
                this.Age = age;
            }
        
        }
        */
    }
}
