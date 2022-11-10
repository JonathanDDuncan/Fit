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

        [TestMethod]
        public void TestMethod3()
        {
            var (width3, height3) = Fit.Calculate.GetSize(10, 10, 5, 5);
            Assert.AreEqual(10, height3);
        }

        [TestMethod]
        public void TestMethod4()
        {
            var (width3, height3) = Fit.Calculate.GetSize(10, 10, 5, 5);
            Assert.AreEqual(10, height3);
        }

        [TestMethod]
        public void TestMethod5()
        {
            var (width3, height3) = Fit.Calculate.GetSize(10, 10, 20, 5);
            Assert.AreEqual(10, width3);
        }

        [TestMethod]
        public void TestMethod6()
        {
            var aspect = 20 / 5;
            var (width3, height3) = Fit.Calculate.GetSize(10, 10, 20, 5);
            Assert.AreEqual(aspect, width3/height3);

        }
    }
}