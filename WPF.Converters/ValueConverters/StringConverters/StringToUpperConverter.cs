using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace WPF.Converters.ValueConverters.StringConverters
{
    /// <summary>
    /// Transforms the string to uppercase.
    /// </summary>
    [ValueConversion(typeof(string), typeof(string))]
    public class StringToUpperConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return value is string s ? s.ToUpper(culture ?? CultureInfo.CurrentCulture) : DependencyProperty.UnsetValue;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return Binding.DoNothing;
        }
    }
}
