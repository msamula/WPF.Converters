using System.Collections;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace WPF.Converters.ValueConverters.VisibilityConverters
{
    /// <summary>
    /// Evaluates a collection and returns Visibility.Visible if it is empty.
    /// Returns Visibility.Collapsed if it contains items.
    /// </summary>
    [ValueConversion(typeof(ICollection), typeof(Visibility))]
    public class CollectionEmptyToVisibilityConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return value is not ICollection iCollection ? DependencyProperty.UnsetValue : 
                   iCollection.Count == 0 ? Visibility.Visible : Visibility.Collapsed;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return Binding.DoNothing;
        }
    }
}
