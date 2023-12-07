using System.Windows.Media;

namespace EStatAnalyser.Web.User.Desktop.Core.Configuration
{
    public class GraphicsShellConfiguration
    {
        // Размеры окна данных
        public static readonly int InternalCanvasWidth = 500;
        public static readonly int InternalCanvasHeight = 500;
        public static readonly int ExternalCanvasWidth = 550;
        public static readonly int ExternalCanvasHeight = 550;

        // Конфигурация точек
        public static readonly int PointRadius = 4;
        public static readonly int PointThickness = 1;
        public static readonly SolidColorBrush PointColor = Brushes.Red;

        // Конфигурация численных подписей (по осям X, Y)
        public static readonly int NumLabelFontSize = 10;

        // Конфигурация линий
        public static readonly int LineStrokeThickness = 1;
    }
}