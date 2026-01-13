using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace WPF.Converters.ValueConverters.VisibilityConverters
{
    /// <summary>
    /// Flips a Visibility value. 
    /// Visible becomes Collapsed; Collapsed/Hidden becomes Visible.
    /// </summary>
    [ValueConversion(typeof(Visibility), typeof(Visibility))]
    public class InverseVisibilityConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return value is not Visibility visibility
                    ? DependencyProperty.UnsetValue
                    : visibility == Visibility.Visible
                        ? Visibility.Collapsed
                        : Visibility.Visible;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return Convert(value, targetType, parameter, culture);
        }
    }
}
