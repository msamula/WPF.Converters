using System.Globalization;
using System.Windows.Data;

namespace WPF.Converters.MultiValueConverters.BooleanConverters
{
    /// <summary>
    /// A multi-value converter that returns true if all input values are boolean true.
    /// Acts as a logical AND gate.
    /// </summary>
    public class AndBooleanToBooleanMultiConverter : IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            return values?.All(x => x is bool b && b) == true;
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
