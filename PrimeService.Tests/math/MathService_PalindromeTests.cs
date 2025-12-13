using PrimeServices.Services;

namespace PrimeServices.Tests.math
{
    [TestClass]
    public class MathService_PalindromeTests
    {
        public readonly MathService _mathService;
        public MathService_PalindromeTests()
        {
            _mathService = new MathService();
        }
        [TestMethod]
        public void IsPalindrome_Inputmam_RetrunTrue()
        {
            string input = "mam";
            var result = _mathService.IsPalindrome(input);

            Assert.IsTrue(result);
        }
    }
}
