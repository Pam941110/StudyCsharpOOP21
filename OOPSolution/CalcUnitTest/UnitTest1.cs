using Microsoft.VisualStudio.TestTools.UnitTesting;
using AttributeTestApp;

namespace CalcUnitTest
{
    [TestClass] // attribute
    public class UnitTest1
    {
        [TestMethod] // attribute
        public void TestMethod1()
        {
            MyClass myClass = new MyClass();
            int a = 3; int b = 5;
            var result = myClass.Plus(a, b);

            Assert.AreEqual(8, result);  // 테스트 결과 

        }
    }
}
