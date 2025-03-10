using ClassLibrary1;
using Xunit;

namespace EShop.Application.Tests
{
    public class CreditCardServiceTests
    {
        [Fact]
        public void ValidateCard_ValidCardNumber_ReturnsTrue()
        {
            var creditCardService = new CreditCardService();
            string validCardNumber = "4111111111111111";

            bool result = creditCardService.ValidateCard(validCardNumber);

            Assert.True(result);
        }

        [Fact]
        public void ValidateCard_InvalidCardNumber_ReturnsFalse()
        {
            var creditCardService = new CreditCardService();
            string invalidCardNumber = "1234567890123456";

            bool result = creditCardService.ValidateCard(invalidCardNumber);

            Assert.False(result);
        }

        [Fact]
        public void ValidateCard_CheckLength_ReturnFalse()
        {
            var creditCardService = new CreditCardService();
            string cardNumber = "1234567890123";

            bool result = creditCardService.ValidateCard(cardNumber);

            Assert.False(result);
        }

        [Fact]
        public void ValidateCard_EmptyCardNumber_ReturnFalse()
        {
            var creditCardService = new CreditCardService();
            string cardNumber = "";

            bool result = creditCardService.ValidateCard(cardNumber);

            Assert.False(result);
        }

        [Fact]
        public void ValidateCard_NonDigitCharacters_ReturnTrue()
        {
            var creditCardService = new CreditCardService();
            string cardNumber = "4111-1111-1111-1111";

            bool result = creditCardService.ValidateCard(cardNumber);

            Assert.True(result);
        }
        
        [Fact]
        public void GetCardType_VisaCardNumber_ReturnsVisa()
        {
            var creditCardService = new CreditCardService();
            string visaCardNumber = "4111111111111111";

            string result = creditCardService.GetCardType(visaCardNumber);

            Assert.Equal("Visa", result);
        }
        
        [Fact]
        public void GetCardType_MasterCardNumber_ReturnsMasterCard()
        {
            var creditCardService = new CreditCardService();
            string masterCardNumber = "5555555555554444";

            string result = creditCardService.GetCardType(masterCardNumber);

            Assert.Equal("MasterCard", result);
        }
        
        [Fact]
        public void GetCardType_AmericanExpressCardNumber_ReturnsAmericanExpress()
        {
            var creditCardService = new CreditCardService();
            string americanExpressCardNumber = "378282246310005";

            string result = creditCardService.GetCardType(americanExpressCardNumber);

            Assert.Equal("American Express", result);
        }
        
        [Fact]
        public void GetCardType_DiscoverCardNumber_ReturnsDiscover()
        {
            var creditCardService = new CreditCardService();
            string discoverCardNumber = "6011111111111117";

            string result = creditCardService.GetCardType(discoverCardNumber);

            Assert.Equal("Discover", result);
        }
        
        [Fact]
        public void GetCardType_JCBCardNumber_ReturnsJCB()
        {
            var creditCardService = new CreditCardService();
            string jcbCardNumber = "3530111333300000";

            string result = creditCardService.GetCardType(jcbCardNumber);

            Assert.Equal("JCB", result);
        }
        
        [Fact]
        public void GetCardType_DinersClubCardNumber_ReturnsDinersClub()
        {
            var creditCardService = new CreditCardService();
            string dinersClubCardNumber = "30569309025904";

            string result = creditCardService.GetCardType(dinersClubCardNumber);

            Assert.Equal("Diners Club", result);
        }
        
        [Fact]
        public void GetCardType_MaestroCardNumber_ReturnsMaestro()
        {
            var creditCardService = new CreditCardService();
            string maestroCardNumber = "6759649826438453";

            string result = creditCardService.GetCardType(maestroCardNumber);

            Assert.Equal("Maestro", result);
        }
        
        [Fact]
        public void GetCardType_UnknownCardNumber_ReturnsUnknown()
        {
            var creditCardService = new CreditCardService();
            string unknownCardNumber = "1234567890123456";

            string result = creditCardService.GetCardType(unknownCardNumber);

            Assert.Equal("Unknown", result);
        }

        [Theory]
        [InlineData("American Express", "349779658312797")]
        [InlineData("American Express", "345470784783010")]
        [InlineData("American Express", "378523393817437")]
        [InlineData("Visa", "4024007165401778")]
        [InlineData("Visa", "4532208021504434")]
        [InlineData("Visa", "4532289052809181")]
        [InlineData("MasterCard", "5530016454538418")]
        [InlineData("MasterCard", "5551561443896215")]
        [InlineData("MasterCard", "5131208517986691")]
        public void GetCardType_ValidCardNumbers_ReturnsExpectedType(string expectedType, string cardNumber)
        {
            var creditCardService = new CreditCardService();

            string result = creditCardService.GetCardType(cardNumber);

            Assert.Equal(expectedType, result);
        }
        
    }
}