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

        [TestMethod]
        public void TestMethod7()
        {
            var (width3, height3) = Fit.Calculate.GetSize(10, 10, 5, 20);
            Assert.AreEqual(2.5, width3);
        }

        [TestMethod]
        public void TestMethod8()
        {
            double width2 = 5;
            double height2 = 10;
            var aspect = width2 / height2;
            var (width3, height3) = Fit.Calculate.GetSize(10, 10, width2, height2);
            Assert.AreEqual(aspect, width3 / height3);

        }

        [TestMethod]
        public void TestMethod9()
        {
            double width2 = 5;
            double height2 = 2;
            var aspect = width2 / height2;
            var (width3, height3) = Fit.Calculate.GetSize(10, 10, width2, height2);
            Assert.AreEqual(4, height3);

        }

        [TestMethod]
        public void TestMethod10()
        {
            double width2 = 2;
            double height2 = 5;
            var aspect = width2 / height2;
            var (width3, height3) = Fit.Calculate.GetSize(10, 10, width2, height2);
            Assert.AreEqual(4, width3);

        }
    }
}