namespace Fit_Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var (width3, height3) = Fit.Calculate.GetSize(10, 5, 10, 5);
            Assert.AreEqual(10, width3);
        }
		[TestMethod]
		public void TestMethod2()
		{
			var (width3, height3) = Fit.Calculate.GetSize(10, 5, 10, 5);
			Assert.AreEqual(5, height3);
		}
	}
}