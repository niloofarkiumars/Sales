
using System.Text.RegularExpressions;

namespace ApplicationService.Validators
{
    /// <summary>
    /// Validates the input data used to create or update a person.
    /// </summary>
    public static class PersonValidator
    {
        private static readonly Regex NamePattern =
            new(@"^[\p{L}]+(?:[ .][\p{L}]+)*$");

        private static readonly Regex NationalIdPattern =
            new(@"^[0-9]{10}$");

        public static void Validate(
            string? nationalId,
            string? firstName,
            string? lastName)
        {
            if (string.IsNullOrWhiteSpace(nationalId) ||
                !NationalIdPattern.IsMatch(nationalId))
            {
                throw new ArgumentException(
                    "National ID must contain exactly 10 digits without spaces.");
            }

            if (string.IsNullOrWhiteSpace(firstName) ||
                !NamePattern.IsMatch(firstName.Trim()))
            {
                throw new ArgumentException(
                    "First name must contain letters, spaces or dots only.");
            }

            if (string.IsNullOrWhiteSpace(lastName) ||
                !NamePattern.IsMatch(lastName.Trim()))
            {
                throw new ArgumentException(
                    "Last name must contain letters, spaces or dots only.");
            }
        }
    }
}
