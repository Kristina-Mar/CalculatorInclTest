namespace Calculator.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void TestAdd()
        {
            //Arrange
            Calculator myCalculator = new Calculator();

            //Act
            double result = myCalculator.Add(1, 5);

            //Assert
            Assert.Equal(6, result);

            result = myCalculator.Add(0.3, 0.2);
            Assert.Equal(0.5, result, 0.00001);
        }
        [Fact]
        public void TestSubtract()
        {
            //Arrange
            Calculator myCalculator = new Calculator();

            //Act
            double result = myCalculator.Subtract(6, 4);

            //Assert
            Assert.Equal(2, result);

            result = myCalculator.Subtract(0.3, 0.2);
            Assert.Equal(0.1, result, 0.00001);
        }
        [Fact]
        public void TestMultiply()
        {
            //Arrange
            Calculator myCalculator = new Calculator();

            //Act
            double result = myCalculator.Multiply(6, 4);

            //Assert
            Assert.Equal(24, result);

            result = myCalculator.Multiply(0.3, 0.2);
            Assert.Equal(0.06, result, 0.00001);
        }
        [Fact]
        public void TestDivide()
        {
            //Arrange
            Calculator myCalculator = new Calculator();

            //Act
            double result = myCalculator.Divide(6, 4);

            //Assert
            Assert.Equal(1.5, result);

            result = myCalculator.Divide(0.3, 0.2);
            Assert.Equal(1.5, result, 0.00001);
        }
    }
}