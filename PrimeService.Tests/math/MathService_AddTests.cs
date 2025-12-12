using PrimeServices.Services;

namespace PrimeServices.Tests.math
{
    [TestClass]
    public class MathService_AddTests
    {
        public readonly MathService _mathService;
        public MathService_AddTests()
        {
            _mathService = new MathService();
        }
        [TestMethod]

        public void Add_2And3_Result5()
        {
            int a = 2, b = 3;
            var result = _mathService.Add(a, b);

            Assert.AreEqual(5, result);

        }
    }
}
