using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace WPF.Converters.ValueConverters.BooleanConverters
{
    /// <summary>
    /// Converts a Visibility enum value to a boolean.
    /// Visible maps to True; Collapsed and Hidden map to False.
    /// </summary>
    [ValueConversion(typeof(Visibility), typeof(bool))]
    public class VisibilityToBooleanConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return value is not Visibility visibility ? DependencyProperty.UnsetValue : visibility == Visibility.Visible;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return value is not bool boolean ? DependencyProperty.UnsetValue : boolean ? Visibility.Visible : Visibility.Collapsed;
        }
    }
}
