using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace WPF.Converters.MultiValueConverters.VisibilityConverters
{
    /// <summary>
    /// A multi-value converter that performs a logical AND operation to determine visibility.
    /// Returns Visible only if all input values are true.
    /// Returns Collapsed if any input value is false or null.
    /// </summary>
    public class AndBooleanToVisibilityMultiConverter : IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            return values?.All(x => x is bool b && b) == true ? Visibility.Visible : Visibility.Collapsed;
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
