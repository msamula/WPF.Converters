using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace WPF.Converters.ValueConverters.VisibilityConverters
{
    /// <summary>
    /// Returns Visible if the value is null; Collapsed if the value has an object.
    /// </summary>
    [ValueConversion(typeof(object), typeof(Visibility))]
    public class NullToVisibilityConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return value == null ? Visibility.Visible : Visibility.Collapsed;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return Binding.DoNothing;
        }
    }
}
