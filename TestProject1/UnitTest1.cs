using SubModulesPlugin;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var result= Class1.Sum(2,4);
            Assert.AreEqual(6,result);
        }
    }
}