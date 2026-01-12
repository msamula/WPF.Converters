using System.Globalization;
using System.Windows.Data;

namespace WPF.Converters.ValueConverters.BooleanConverters
{
    /// <summary>
    /// Returns true if the object is not null; returns false if the object is null.
    /// </summary>
    [ValueConversion(typeof(object), typeof(bool))]
    public class NullToInverseBooleanConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return value != null;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return Binding.DoNothing;
        }
    }
}
