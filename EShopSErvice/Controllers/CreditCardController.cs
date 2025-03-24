using System.Net;
using ClassLibrary1;
using Microsoft.AspNetCore.Mvc;
using EShop.Domain.Exception.CardNumber;

namespace EShopService.Controllers;

[ApiController]
[Route("api/[controller]")]
public class CreditCardController : ControllerBase
{
    private readonly CreditCardService _creditCardService = new();

    [HttpPost("validate/{cardNumber}")]
    public IActionResult ValidateCardNumber([FromRoute] string cardNumber)
    {
        try
        {
            bool isValid = _creditCardService.ValidateCard(cardNumber);
            return Ok(new { Valid = isValid });
        }
        catch (CardNumberInvalidException )
        {
            return StatusCode(406 ,new { code = HttpStatusCode.NotAcceptable});
        }
        catch (CardNumberTooShortException e)
        {
            return StatusCode(400 ,new { Error = e.Message, code = HttpStatusCode.BadRequest });
        }
        catch (CardNumberTooLongException e)
        {
            return StatusCode(414 ,new { Error = e.Message, code = HttpStatusCode.RequestUriTooLong });
        }
      
    }

    [HttpPost("getCardType/{cardNumber}")]
    public IActionResult GetCardType([FromRoute] string cardNumber)
    {
        try
        {
            string validCardProvider = _creditCardService.GetCardType(cardNumber);
            return Ok(new { Valid = validCardProvider });
        }
        catch (CardNumberInvalidException )
        {
            return BadRequest(new {  code = HttpStatusCode.NotAcceptable });
        }
    }


}