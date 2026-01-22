using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace WPF.Converters.ValueConverters.MediaConverters
{
    /// <summary>
    /// Converts a boolean to an opacity value (double).
    /// True returns 1.0. False returns a value defined in the ConverterParameter (default 0.0).
    /// </summary>
    [ValueConversion(typeof(bool), typeof(double))]
    public class BooleanToOpacityConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is not bool boolValue)
            {
                return DependencyProperty.UnsetValue;
            }

            double falseOpacity = double.TryParse(parameter?.ToString(), NumberStyles.Any, CultureInfo.InvariantCulture, out var p) ? p : 0.0;

            return boolValue ? 1.0 : falseOpacity;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return Binding.DoNothing;
        }
    }
}
