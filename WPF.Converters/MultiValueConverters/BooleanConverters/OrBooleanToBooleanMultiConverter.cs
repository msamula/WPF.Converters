using System.Globalization;
using System.Windows.Data;

namespace WPF.Converters.MultiValueConverters.BooleanConverters
{
    /// <summary>
    /// A multi-value converter that returns true if any of the input values are boolean true.
    /// Acts as a logical OR gate.
    /// </summary>
    public class OrBooleanToBooleanMultiConverter : IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            return values != null && values.Any(x => x is bool boolValue && boolValue);
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
