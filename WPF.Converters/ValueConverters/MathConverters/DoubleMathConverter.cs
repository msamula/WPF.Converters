using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace WPF.Converters.ValueConverters.MathConverters
{
    /// <summary>
    /// Performs basic arithmetic operations on a double value.
    /// Primarily used for dynamic layout adjustments in XAML (e.g., Width - 20).
    /// </summary>
    [ValueConversion(typeof(double), typeof(double))]
    public class DoubleMathConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (!double.TryParse(value?.ToString(), out double doubleValue) || parameter is not DoubleMathParameter calc)
                return DependencyProperty.UnsetValue;

            return calc.Operator switch
            {
                Operator.Add => doubleValue + calc.Value,
                Operator.Subtract => doubleValue - calc.Value,
                Operator.Multiply => doubleValue * calc.Value,
                Operator.Divide => calc.Value != 0 ? doubleValue / calc.Value : DependencyProperty.UnsetValue,
                _ => DependencyProperty.UnsetValue
            };
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (!double.TryParse(value?.ToString(), out double doubleValue) || parameter is not DoubleMathParameter calc)
                return DependencyProperty.UnsetValue;

            return calc.Operator switch
            {
                Operator.Add => doubleValue - calc.Value,
                Operator.Subtract => doubleValue + calc.Value,
                Operator.Multiply => calc.Value != 0 ? doubleValue / calc.Value : DependencyProperty.UnsetValue,
                Operator.Divide => doubleValue * calc.Value,
                _ => DependencyProperty.UnsetValue
            };
        }
    }

    /// <summary>
    /// Holds the configuration for a <see cref="DoubleMathConverter"/>.
    /// </summary>
    public class DoubleMathParameter
    {
        public double Value { get; set; }
        public Operator Operator { get; set; } = Operator.Add;
    }
}
