using NUnit.Framework;
 
namespace TestProject
{
    public class Tests
    {
        [Test]
        public void Test1()
        {
            Assert.Pass();
        }
 
        [Test]
        public void Test2()
        {
            Assert.Fail();
        }
    }
}
