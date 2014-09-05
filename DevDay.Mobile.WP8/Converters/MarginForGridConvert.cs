using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;

namespace DevDay.Mobile.WP8.Converters
{
    public class MarginForGridConvert : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            string itemVal = value as String;
            if (String.IsNullOrWhiteSpace(itemVal))
            {
                return new Thickness(0, -50, 0, 0);
            }

            else
            {
                return new Thickness(0, 8, 0, 0);
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
