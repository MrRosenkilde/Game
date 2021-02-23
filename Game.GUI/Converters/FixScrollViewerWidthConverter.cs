using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using System.Windows.Data;

namespace Game.GUI.Converters
{
    public class FixScrollViewerWidthConverter : IValueConverter
    {
        private const int VerticalScrollWidth = 13;
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if(int.TryParse(value.ToString(), out int val))
                return val > VerticalScrollWidth ? val - VerticalScrollWidth : 0;
            else return value;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return value;
        }
    }
}
