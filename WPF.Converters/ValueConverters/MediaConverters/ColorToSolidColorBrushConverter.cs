using System.Globalization;
using System.Windows;
using System.Windows.Data;
using System.Windows.Media;

namespace WPF.Converters.ValueConverters.MediaConverters
{
    /// <summary>
    /// Converts a Color structure into a SolidColorBrush.
    /// Useful when the ViewModel stores raw Color data but the View requires a Brush for properties like Background or Foreground.
    /// </summary>
    [ValueConversion(typeof(Color), typeof(SolidColorBrush))]
    public class ColorToSolidColorBrushConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is not Color color)
                return DependencyProperty.UnsetValue;

            var solidColorBrush = new SolidColorBrush(color);
            solidColorBrush.Freeze();
            return solidColorBrush;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return value is not SolidColorBrush solidColorBrush ? DependencyProperty.UnsetValue : solidColorBrush.Color;
        }
    }
}
