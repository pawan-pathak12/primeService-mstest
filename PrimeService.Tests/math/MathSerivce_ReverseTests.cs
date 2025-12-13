using PrimeServices.Services;

namespace PrimeServices.Tests.math
{
    [TestClass]
    public class MathSerivce_ReverseTests
    {
        public readonly MathService _mathService;
        public MathSerivce_ReverseTests()
        {
            _mathService = new MathService();
        }

        [TestMethod]
        public void DoesReverse_Of23_Get32()
        {
            var input = 23;

            var result = _mathService.Reverse(input);

            Assert.AreEqual(32, result);
        }
        [TestMethod]
        public void Reverse_OfHey_IsyeH()
        {
            var input = "Hey";
            var result = _mathService.ReverseString(input);

            Assert.AreEqual("yeH", result);
        }
    }
}
