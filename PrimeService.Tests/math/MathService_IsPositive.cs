using PrimeServices.Services;

namespace PrimeServices.Tests.math
{
    [TestClass]
    public class MathService_IsPositive
    {
        //Arrange 
        public readonly MathService _mathService;
        public MathService_IsPositive()
        {
            _mathService = new MathService();
        }
        [TestMethod]
        public void IsPositive_ReturnTrue_ForPositiveNumber()
        {
            //Act 
            int a = 2;
            var result = _mathService.IsPositive(a);

            //Assert 
            Assert.IsTrue(result);
        }
        public void IsPositive_ReturnFalse_ForNeativeNumber()
        {
            int a = -2;
            var result = _mathService.IsPositive(a);

            Assert.IsTrue(result);
        }


    }
}

