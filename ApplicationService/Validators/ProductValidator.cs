
namespace ApplicationService.Validators
{
    /// <summary>
    /// Validates product data before creating or updating a product.
    /// </summary>
    public static class ProductValidator
    {
        public static void Validate(
            string? code,
            string? title,
            decimal unitPrice,
            int quantity)
        {
            if (string.IsNullOrWhiteSpace(code))
                throw new ArgumentException("Product code is required.");

            if (string.IsNullOrWhiteSpace(title))
                throw new ArgumentException("Product title is required.");

            if (unitPrice < 0)
                throw new ArgumentException(
                    "Unit price cannot be negative.");

            if (quantity < 0)
                throw new ArgumentException(
                    "Quantity cannot be negative.");
        }
    }
}
