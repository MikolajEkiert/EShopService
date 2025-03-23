namespace EShop.Domain.Exception.CardNumber
{
    public class CardNumberTooLongException : System.Exception
    {
        public CardNumberTooLongException() : base("414")
        {
        }

        public CardNumberTooLongException(System.Exception inner) : base("414", inner)
        {
        }
    }
}