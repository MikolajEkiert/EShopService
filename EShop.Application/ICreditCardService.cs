namespace ClassLibrary1
{
    public interface ICreditCardService
    {
        bool ValidateCard(string cardNumber);
        string GetCardType(string cardNumber);
    }
}