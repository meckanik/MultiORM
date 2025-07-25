namespace MultiORM.Unit.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            var coll = new List<int>() { 1, 2, 3, 4, 5 }.AsEnumerable();

            var result = coll.MWhere(c => c == 1);

            Assert.Pass();
        }
    }
}