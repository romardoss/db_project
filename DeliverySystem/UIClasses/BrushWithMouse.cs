using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace DeliverySystem.UIClasses
{
    public static class BrushWithMouse
    {
        private static readonly SolidColorBrush YellowWhenMouseLeave = new SolidColorBrush(Color.FromRgb(243, 210, 80));
        private static readonly SolidColorBrush YellowWhenMouseEnter = new SolidColorBrush(Color.FromRgb(243, 240, 100));
        private static readonly SolidColorBrush BlueWhenMouseEnter = new SolidColorBrush(Color.FromRgb(93, 162, 213));
        private static readonly SolidColorBrush BlueWhenMouseLeave = new SolidColorBrush(Color.FromRgb(144, 204, 244));



        public static void Brush<T>(Color color, T control) where T : Border
        {
            control.Background = new SolidColorBrush(color);
        }

        public static void Brush<T>(SolidColorBrush color, T border) where T : Border
        {
            border.Background = color;
        }

        public static void BrushColor<T>(bool isEnter, T border, SolidColorBrush colorEnter, SolidColorBrush colorLeave) where T : Border
        {
            if (isEnter)
            {
                Brush(colorEnter, border);
            }
            else
            {
                Brush(colorLeave, border);
            }
        }

        public static void BrushYellow<T>(bool isEnter, T border) where T : Border
        {
            BrushColor(isEnter, border, YellowWhenMouseEnter, YellowWhenMouseLeave);
        }

        public static void BrushBlue<T>(bool isEnter, T border) where T : Border
        {
            BrushColor(isEnter, border, BlueWhenMouseEnter, BlueWhenMouseLeave);
        }
    }
}
