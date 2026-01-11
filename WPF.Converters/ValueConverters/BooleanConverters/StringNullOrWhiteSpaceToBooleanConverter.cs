using System.Globalization;
using System.Windows.Data;

namespace WPF.Converters.ValueConverters.BooleanConverters
{
    /// <summary>
    /// Converts a string to a boolean. 
    /// Returns true if the string is null, empty, or consists only of white-space characters; otherwise, false.
    /// </summary>
    [ValueConversion(typeof(string), typeof(bool))]
    public class StringNullOrWhiteSpaceToBooleanConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return string.IsNullOrWhiteSpace(value as string);
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return Binding.DoNothing;
        }
    }
}
