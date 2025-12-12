using PrimeServices.Services;

namespace PrimeServices.Tests.math
{
    [TestClass]
    public class MathService_SquareTests
    {

        public readonly MathService _mathService;
        public MathService_SquareTests()
        {
            _mathService = new MathService();
        }
        [TestMethod]
        public void DoesSquare_Of5_Result25()
        {
            int a = 5;
            var result = _mathService.Square(a);

            Assert.AreEqual(25, result);
        }
    }
}
