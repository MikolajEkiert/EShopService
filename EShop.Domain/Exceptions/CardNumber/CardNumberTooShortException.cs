namespace EShop.Domain.Exception.CardNumber
{
    public class CardNumberTooShortException : System.Exception
    {
        public CardNumberTooShortException() : base("400")
        {
        }

        public CardNumberTooShortException(string message, System.Exception inner) : base(message, inner)
        {
        }
    }
}