using System;

namespace EventTest
{
    class MyNotifier
    {
        public event EventHandler SomethingHappened;
        public void DoSomething(int number)
        {
            int temp = number % 10;

            if (temp != 0 && temp % 3 == 0)
            {
                SomethingHappened(string.Format("{0} : 짝", number));
            }
        }
    }
}
