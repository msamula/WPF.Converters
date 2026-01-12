using System.Collections;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace WPF.Converters.ValueConverters.BooleanConverters
{
    /// <summary>
    /// Evaluates a collection and returns true if it is empty.
    /// Returns false if the collection contains one or more items.
    /// </summary>
    [ValueConversion(typeof(ICollection), typeof(bool))]
    public class CollectionEmptyToBooleanConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return value is not ICollection iCollection ? DependencyProperty.UnsetValue : iCollection.Count == 0;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return Binding.DoNothing;
        }
    }
}
