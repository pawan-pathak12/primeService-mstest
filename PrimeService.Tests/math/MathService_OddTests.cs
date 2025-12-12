using PrimeServices.Services;

namespace PrimeServices.Tests.math
{
    [TestClass]
    public class MathService_OddTests
    {
        public readonly MathService _mathService;
        public MathService_OddTests()
        {
            _mathService = new MathService();
        }
        [TestMethod]
        public void IsOdd_Input1_ReturnTrue()
        {
            int input = 1;
            //Act 
            bool result = _mathService.IsOdd(input);

            //Assert 
            Assert.IsTrue(result);
        }


    }
}
