namespace SeleniumLearning
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
            TestContext.Progress.WriteLine("Setting up the method");
        }

        [Test]
        public void Test1()
        {
            TestContext.Progress.WriteLine("Setting up the test1");

        }

        [Test]
        public void Test2()

        {
            TestContext.Progress.WriteLine("Setting up the test2");

            TestContext.Progress.WriteLine("New print method");
        }

        [TearDown]
        public void TearDown()
        {
            TestContext.Progress.WriteLine("Teardown method");
        }
    }
}
