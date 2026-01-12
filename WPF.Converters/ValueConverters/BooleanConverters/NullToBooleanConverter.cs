using System.Globalization;
using System.Windows.Data;

namespace WPF.Converters.ValueConverters.BooleanConverters
{
    /// <summary>
    /// Converts a reference to a boolean. 
    /// Returns true if the value is null; otherwise, false.
    /// </summary>
    [ValueConversion(typeof(object), typeof(bool))]
    public class NullToBooleanConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return value == null;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return Binding.DoNothing;
        }
    }
}
