using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace WPF.Converters.MultiValueConverters.VisibilityConverters
{
    /// <summary>
    /// A multi-value converter that performs a logical NAND operation to determine visibility.
    /// Returns Collapsed only if all input values are true.
    /// Returns Visible if any input value is false, null, or unset.
    /// </summary>
    public class AndBooleanToInverseVisibilityMultiConverter : IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            return values?.All(x => x is bool b && b) == true ? Visibility.Collapsed : Visibility.Visible;
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
