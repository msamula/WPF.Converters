using System.Globalization;
using System.Windows.Data;

namespace WPF.Converters.ValueConverters.BooleanConverters
{
    /// <summary>
    /// Evaluates a string and returns false if it is null, empty, or whitespace.
    /// Returns true only if the string contains actual non-whitespace characters.
    /// </summary>
    [ValueConversion(typeof(string), typeof(bool))]
    public class StringNullOrWhiteSpaceToInverseBooleanConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return !string.IsNullOrWhiteSpace(value as string);
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return Binding.DoNothing;
        }
    }
}
