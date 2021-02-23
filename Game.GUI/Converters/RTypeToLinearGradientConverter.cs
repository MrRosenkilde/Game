using Game.Resources;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using System.Windows;
using System.Windows.Data;
using System.Windows.Media;

namespace Game.GUI.Converters
{
    public class RTypeToLinearGradientConverter : IValueConverter
    {
        private static readonly ColorConverter colorConverter = new ColorConverter();
        private static Color ColorFor(RAttr attr) 
            => attr switch
            {
                RAttr.None => Colors.Black,
                RAttr.Crafting => Colors.Blue,
                RAttr.Burnable => Colors.OrangeRed,
                RAttr.Editable => Colors.Green,
                RAttr.Plant => Colors.ForestGreen,
                RAttr.Dangerous => Colors.Red,
                RAttr.Shroom => Colors.RosyBrown,
                RAttr.Meat => Colors.MediumVioletRed,
            };
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is RType type)
            {
                var gsc = new GradientStopCollection();

                var attr = type.Attributes();
                var flags = attr.GetFlags();
                int count = 0;
                foreach (var flag in flags)
                {
                    gsc.Add(
                    new GradientStop(ColorFor(flag), 0));
                    count++;
                }
                for (int i = 0; i < count; i++)
                    gsc[i].Offset = i / (float)count;

                return new LinearGradientBrush(gsc, 45d);
            }
            else return default;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return value;
        }
    }
}
