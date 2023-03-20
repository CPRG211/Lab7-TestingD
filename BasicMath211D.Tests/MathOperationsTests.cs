namespace BasicMath211D.Tests
{
    public class Tests
    {
        private MathOperations mathOperations;

        [SetUp]
        public void Setup()
        {
            mathOperations = new MathOperations();
        }

        [Test]
        public void TestAddTwoPlusTwo()
        {
            double expected = 4;
            double actual = mathOperations.Add(2, 2);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void TestSubtractThreeFromFive()
        {
            double expected = 2;
            double actual = mathOperations.Subtract(5, 3);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void TestMultiplyTenTimesFive()
        {
            double expected = 50;
            double actual = mathOperations.Multiply(10, 5);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void TestDivideTwelveByFour()
        {
            double expected = 3;
            double actual = mathOperations.Divide(12, 4);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void TestDivideByZero()
        {
            try
            {
                double actual = mathOperations.Divide(10, 0);

                Assert.Fail("Divided by zero");
            }
            catch (DivideByZeroException)
            {
                Assert.Pass();
            }


        }

        [Test]
        public void TestDivideByInfinity()
        {
            double actual = mathOperations.Divide(10, double.PositiveInfinity);
            double expected = 0;

            Assert.AreEqual(expected, actual);


        }
    }
}