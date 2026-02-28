using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace WPF.Converters.ValueConverters.VisibilityConverters
{
    /// <summary>
    /// Converts a boolean to a Visibility value in reverse.
    /// True -> Collapsed/Hidden, False -> Visible.
    /// </summary>
    [ValueConversion(typeof(bool), typeof(Visibility))]
    public class InverseBooleanToVisibilityConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is not bool boolean)
            {
                return DependencyProperty.UnsetValue;
            }

            return boolean ? Visibility.Collapsed : Visibility.Visible;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is not Visibility visibility)
            {
                return DependencyProperty.UnsetValue;
            }

            return visibility != Visibility.Visible;
        }
    }
}
