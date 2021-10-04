using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFStyles.Converters
{
    public class GameStateToBoolConverter : IValueConverter
    {
        #region IValueConverter Members

        public object Convert(object value, Type targetType, object trueValue, CultureInfo culture)
        {
            if (value != null && value.GetType().IsEnum)
                return Equals(value, trueValue);
            else
                return DependencyProperty.UnsetValue;
        }

        public object ConvertBack(object value, Type targetType, object trueValue, CultureInfo culture)
        {
            if (value is bool && (bool)value)
                return trueValue;
            else
                return DependencyProperty.UnsetValue;
        }

        #endregion IValueConverter Members
    }
}
