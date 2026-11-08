
using System.Globalization;

namespace View.Helpers
{
    /// <summary>
    /// Provides input restrictions for Windows Forms text boxes.
    /// </summary>
    public static class InputValidationHelper
    {
        /// <summary>
        /// Allows only English digits and control characters.
        /// </summary>
        public static void AllowDigitsOnly(
            object? sender, KeyPressEventArgs e)
        {
            e.Handled =
                !char.IsControl(e.KeyChar) &&
                (e.KeyChar < '0' || e.KeyChar > '9');
        }

        /// <summary>
        /// Allows English digits and one decimal separator.
        /// </summary>
        public static void AllowDecimal(
            object? sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar))
                return;

            string separator =
                CultureInfo.CurrentCulture.NumberFormat
                    .NumberDecimalSeparator;

            bool isDigit = e.KeyChar >= '0' && e.KeyChar <= '9';

            bool isDecimalSeparator =
                e.KeyChar.ToString() == separator;

            bool alreadyHasSeparator =
                sender is TextBox textBox &&
                textBox.Text.Contains(separator);

            e.Handled =
                !isDigit &&
                !(isDecimalSeparator && !alreadyHasSeparator);
        }

        public static void AllowLettersSpacesAndDots(
    object? sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar))
                return;

            e.Handled =
                !char.IsLetter(e.KeyChar) &&
                e.KeyChar != ' ' &&
                e.KeyChar != '.';
        }
    }
}
