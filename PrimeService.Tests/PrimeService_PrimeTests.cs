namespace PrimeServices.Tests
{
    [TestClass]
    public class PrimeService_PrimeTests
    {
        private PrimeService _primeService;

        [TestInitialize]
        public void Setup()
        {
            _primeService = new PrimeService();
        }

        [TestMethod]
        public void IsPrime_InputIs1_ReturnFalse()
        {
            //Arrange 
            int input = 1;

            //Act 
            bool result = _primeService.IsPrime(input);

            //Assert 
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void IsPrime_Input7_ReturnTrue()
        {
            //Arrange 
            int input = 7;

            //act 
            bool result = _primeService.IsPrime(input);

            //Assert 
            Assert.IsTrue(result);
        }
    }
}
