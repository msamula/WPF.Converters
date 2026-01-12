using System.Collections;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace WPF.Converters.ValueConverters.VisibilityConverters
{
    /// <summary>
    /// Evaluates a collection and returns Visibility.Visible if it contains items.
    /// Returns Visibility.Collapsed if the collection is empty.
    /// </summary>
    [ValueConversion(typeof(ICollection), typeof(Visibility))]
    public class CollectionEmptyToInverseVisibilityConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return value is not ICollection iCollection ? DependencyProperty.UnsetValue :
                   iCollection.Count == 0 ? Visibility.Collapsed : Visibility.Visible;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return Binding.DoNothing;
        }
    }
}
