using System.Globalization;
using System.Windows;
using System.Windows.Data;
using System.Windows.Media;

namespace WPF.Converters.ValueConverters.MediaConverters
{
    /// <summary>
    /// Extracts the Color from a SolidColorBrush.
    /// Useful for binding a Brush property to an effect or animation that requires a Color type.
    /// </summary>
    [ValueConversion(typeof(SolidColorBrush), typeof(Color))]
    public class SolidColorBrushToColorConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is not SolidColorBrush solidColorBrush)
                return DependencyProperty.UnsetValue;

            byte a = (byte)(solidColorBrush.Opacity * solidColorBrush.Color.A);
            return Color.FromArgb(a, solidColorBrush.Color.R, solidColorBrush.Color.G, solidColorBrush.Color.B);
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is Color color)
            {
                SolidColorBrush result = new SolidColorBrush(color);
                result.Freeze();
                return result;
            }

            return DependencyProperty.UnsetValue;
        }
    }
}
