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

        public static void Brush<T>(Color color, T control) where T : Border
        {
            control.Background = new SolidColorBrush(color);
        }

        public static void Brush<T>(SolidColorBrush color, T border) where T : Border
        {
            border.Background = color;
        }

        public static void BrushYellow<T>(bool isEnter, T border) where T : Border
        {
            if(isEnter)
            {
                Brush(YellowWhenMouseEnter, border);
            }
            else
            {
                Brush(YellowWhenMouseLeave, border);
            }
        }
    }
}
