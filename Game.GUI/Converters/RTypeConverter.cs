using Game.Resources;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Windows.Data;

namespace Game.GUI.Converters
{
    public class RTypeConverter : IValueConverter
    {
        private string MakePretty(string text) {
            if (string.IsNullOrEmpty(text))
                return text;
            Span<char> result = stackalloc char[25];
            result[0] = text[0];
            for (int i = 1, spaces = 0; i < text.Length; i++) {
                if (char.IsUpper(text[i]))
                {
                    result[i + spaces++] = ' ';
                    result[i + spaces] = text[i];
                }
                else result[i + spaces] = text[i];
            }

            return new string(result);
        }
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is RType type)
                return MakePretty(type.ToString());
            else return value.ToString();
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return value;
        }
    }
}
