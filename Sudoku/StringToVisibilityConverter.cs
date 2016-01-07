using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;

namespace Sudoku
{
    public class StringToVisibilityConverter : DependencyObject, IValueConverter
    {
        public object Convert(object value, Type targetType,
                          object parameter, CultureInfo culture)
        {
            return (value == null) || ((string)value).Length == 0 ? Visibility.Collapsed : Visibility.Visible;
        }

        public object ConvertBack(object value, Type targetType,
                                  object parameter, CultureInfo culture)
        {
            return Binding.DoNothing;
        }
    }
}
