namespace EShop.Domain.Exception.CardNumber
{
    public class CardNumberInvalidException : System.Exception
    {
        public CardNumberInvalidException() : base("406")
        {
        }

        public CardNumberInvalidException(string message, System.Exception inner) : base(message, inner)
        {
        }
    }
}