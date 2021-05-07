using System;

namespace DelegateChainApp
{
    class Program
    {
        static void Main(string[] args)
        {
            FireStation station = new FireStation();
            ThereIsAFire fireHouse = new ThereIsAFire(station.Call119);
            fireHouse += new ThereIsAFire(station.ShoutOut);
            fireHouse += new ThereIsAFire(station.Escape);
            // 대리자 실행
            fireHouse("우리집");
            Console.WriteLine();

            ThereIsAFire fireWoorim = new ThereIsAFire(station.Call119);
            fireWoorim += new ThereIsAFire(station.Escape);
            //대리자 실행
            fireWoorim("우림라이온밸리A");

        }
    }
}
