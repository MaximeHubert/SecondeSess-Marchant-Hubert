using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace ApplicWPF
{
    class ConverterHour : IValueConverter
    {
        object IValueConverter.Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            int hours = ((int)value - (int)value % 60) / 60;

            if (((int)value - hours * 60) < 10)
                return hours + ":0" + ((int)value - hours * 60);
            else
                return hours + ":" + ((int)value - hours * 60);

        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }


    }
}
