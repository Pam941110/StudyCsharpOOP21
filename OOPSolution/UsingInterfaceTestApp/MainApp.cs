using System;
using System.Threading;

namespace UsingInterfaceTestApp
{
    class MainApp
    {
        static void Main(string[] args)
        {
            /*
            var monitor = new ExtendedMonitor(new ConsoleLogger(DateTime.Now)); 
            monitor.PrintLog("로그 내용입니다/");
            */

            // 콘솔에 찍히게 만들었더니 ConsoleLogger --> log에 기록해 달라는 변경 사항 발생! FileLogger


            var monitor1 = new ExtendedMonitor(new ConsoleLogger(DateTime.Now));
            monitor1.PrintLog("콘솔로그입니다/");

            var monitor = new ExtendedMonitor(new FileLogger("210504.log"));
            monitor.PrintLog("로그 내용입니다/");

            Thread.Sleep(5000); // 시간딜레이  1000 ms => 1 sec 

            monitor.PrintLog("이하 오류가 발생했습니다.");

            Console.WriteLine("프로그램 종료/");
        }
    }
}
