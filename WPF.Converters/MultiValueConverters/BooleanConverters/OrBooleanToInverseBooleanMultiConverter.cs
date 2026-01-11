using System.Globalization;
using System.Windows.Data;

namespace WPF.Converters.MultiValueConverters.BooleanConverters
{
    /// <summary>
    /// Returns true only if all input values are false. 
    /// Returns false if at least one input value is true.
    /// </summary>
    public class OrBooleanToInverseBooleanMultiConverter : IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            return values == null || !values.Any(x => x is bool boolValue && boolValue);
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
