namespace FoodDeliverySystem.ExceptionHandling
{
    public class FoodDeliveryException:Exception
    {
        public int StatusCode { get; }

        public FoodDeliveryException(string message, int statusCode) : base(message)
        {
            StatusCode = statusCode;
        }
    }
}
