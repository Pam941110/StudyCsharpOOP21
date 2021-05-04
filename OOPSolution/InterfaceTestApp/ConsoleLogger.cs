using System;
using System.Diagnostics; // Debug

namespace InterfaceTestApp
{
    class ConsoleLogger : ILogger // Ver 1.0개발
    {
        public void WriteError(string error)
        {
            Debug.WriteLine($"에러 : {error}");
        }

        public void WriteLog(string messsage)
        {
            Console.WriteLine($"로그 {DateTime.Now}: {messsage}");
            
            //throw new NotImplementedException();  // 구현 전이므로 일부러 '예외'를 발생

        }
    }
}
