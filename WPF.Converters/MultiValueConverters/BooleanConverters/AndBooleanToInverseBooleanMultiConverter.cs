using System.Globalization;
using System.Windows.Data;

namespace WPF.Converters.MultiValueConverters.BooleanConverters
{
    /// <summary>
    /// A multi-value converter that performs a logical NAND operation.
    /// Returns false only if all input values are true.
    /// Returns true if at least one input value is false.
    /// </summary>
    public class AndBooleanToInverseBooleanMultiConverter : IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            return values == null || !values.All(x => x is bool boolValue && boolValue);
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
