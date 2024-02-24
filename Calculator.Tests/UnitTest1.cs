namespace Calculator.Tests
{
    public class UnitTest1
    {
        double result = 0;
        Calculator myCalculator = new Calculator();

        [Theory]
        [InlineData(6 ,4, 10)]
        [InlineData(0.3, 0.2, 0.5)]
        [InlineData(-9, 5, -4)]
        public void TestAdd(double a, double b, double expected)
        {
            result = myCalculator.Add(a, b);
            Assert.Equal(expected, result, 0.0001);
        }

        [Theory]
        [InlineData(6, 4, 2)]
        [InlineData(0.3, 0.2, 0.1)]
        [InlineData(-9, 5, -14)]
        public void TestSubtract(double a, double b, double expected)
        {
            result = myCalculator.Subtract(a, b);
            Assert.Equal(expected, result, 0.0001);
        }

        [Theory]
        [InlineData(6, 4, 24)]
        [InlineData(0.3, 0.2, 0.06)]
        [InlineData(-9, 5, -45)]
        public void TestMultiply(double a, double b, double expected)
        {
            result = myCalculator.Multiply(a, b);
            Assert.Equal(expected, result, 0.0001);
        }

        [Theory]
        [InlineData(6, 4, 1.5)]
        [InlineData(0.3, 0.2, 1.5)]
        [InlineData(-9, 5, -1.8)]
        public void TestDivide(double a, double b, double expected)
        {
            result = myCalculator.Divide(a, b);
            Assert.Equal(expected, result, 0.0001);
        }
    }
}