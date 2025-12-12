using PrimeServices.Services;

namespace PrimeServices.Tests.math
{
    [TestClass]
    public class MathService_MaxTests
    {
        public readonly MathService _mathService;
        public MathService_MaxTests()
        {
            _mathService = new MathService();
        }

        [TestMethod]
        public void FindMax_Input2And3_Return3()
        {
            //act
            int a = 2, b = 3;
            var result = _mathService.FindMax(a, b);

            //Assert 
            Assert.AreEqual(3, result);

        }
        [TestMethod]
        public void FindMax_Input10And5_Return10()
        {
            //act
            int a = 10, b = 5;
            var result = _mathService.FindMax(a, b);

            //Assert 
            Assert.AreEqual(a, result);

        }
    }
}
