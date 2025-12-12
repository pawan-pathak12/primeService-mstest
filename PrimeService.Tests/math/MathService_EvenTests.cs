
using PrimeServices.Services;
namespace PrimeServices.Tests.math
{
    [TestClass]
    public class MathService_EvenTests
    {
        //Arrange 
        public readonly MathService _mathService;
        public MathService_EvenTests()
        {
            _mathService = new MathService();
        }
        [TestMethod]
        public void IsEven_Input4_ReturnTrue()
        {

            int input = 4;

            //Act
            bool result = _mathService.IsEven(input);

            //Assert 
            Assert.IsTrue(result, "Enter number is even");

        }

    }
}
