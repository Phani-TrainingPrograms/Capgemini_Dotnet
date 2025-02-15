namespace TestProject1
{
    [TestFixture]
    public class CalculatorTests
    {
        private Calculator _calculator;

        [SetUp]
        public void Setup()
        {
            _calculator = new Calculator();
        }

        [Test]
        public void Add_ShouldReturnSum()
        {
            Assert.AreEqual(8, _calculator.Add(3, 5));
        }

        [TestCase(2, 3, 6)]
        [TestCase(-1, 5, -5)]
        [TestCase(0, 10, 0)]
        public void Multiply_ShouldReturnProduct(int a, int b, int expected)
        {
            Assert.AreEqual(expected, _calculator.Multiply(a, b));
        }

        [Test]
        public void Divide_ByZero_ShouldThrowException()
        {
            Assert.Throws<DivideByZeroException>(() => _calculator.Divide(10, 0));
        }
    }

}