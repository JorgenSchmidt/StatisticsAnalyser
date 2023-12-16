using EStatAnalyser.Web.User.Desktop.Core.Configuration;
using EStatAnalyser.Web.User.Desktop.Core.Entities.DataEntities;
using EStatAnalyser.Web.User.Desktop.Core.Entities.GraphicsShellEntities;
using EStatAnalyser.Web.User.Desktop.Model.MessageService.MessageClasses;

namespace EStatAnalyser.Web.User.Desktop.Model.GraphicsShell
{
    public class GraphicsSketchers
    {

        public static List<Sphere> GetSpheres (List<SimpleData> Data)
        {
            var Result = new List<Sphere> ();

            foreach(var item in Data)
            {
                Result.Add(
                    new Sphere
                    {
                        X = item.X,
                        Y = item.Y
                    }
                );
            }

            return Result;
        }

        public static List<TextLabel> GetLabels (double x_min, double x_max, double y_min, double y_max)
        {
            try
            {
                var Result = new List<TextLabel>();

                int XFieldInitPoints = (GraphicsShellConfiguration.ExternalCanvasWidth - GraphicsShellConfiguration.InternalCanvasWidth) / 2;
                int YFieldInitPoints = (GraphicsShellConfiguration.ExternalCanvasHeight - GraphicsShellConfiguration.InternalCanvasHeight) / 2;

                var xStep = Math.Sqrt(
                        Math.Pow(x_max - x_min, 2)
                    )
                    / GraphicsShellConfiguration.XLabelCount;

                for (double x = x_min; x <= x_max; x += Math.Round(xStep, 8))
                {
                    var kx = (GraphicsShellConfiguration.InternalCanvasWidth)
                        / Math.Sqrt(Math.Pow(x_max - x_min, 2));

                    var XCoord = Convert.ToInt32((x - x_min) * kx);

                    Result.Add(
                        new TextLabel
                        {
                            X = XCoord + XFieldInitPoints + 30,
                            Y = YFieldInitPoints / 4,
                            Content = Math.Round(x, 2).ToString()
                        }
                    );
                }

                var yStep = Math.Sqrt(
                        Math.Pow(y_max - y_min, 2)
                    )
                    / GraphicsShellConfiguration.YLabelCount;

                for (double y = y_min; y <= y_max; y += Math.Round(yStep, 8))
                {
                    var ky = (GraphicsShellConfiguration.InternalCanvasHeight)
                        / Math.Sqrt(Math.Pow(y_max - y_min, 2));

                    var YCoord = Convert.ToInt32((y - y_min) * ky);

                    Result.Add(
                        new TextLabel
                        {
                            X = XFieldInitPoints / 4,
                            Y = YCoord + YFieldInitPoints,
                            Content = Math.Round(y, 2).ToString()
                        }
                    );
                }

                return Result;
            }
            catch (Exception ex)
            {
                MessageObjects.Sender.SendMessage("Ошибка: \n" + ex.Message);
                return new List<TextLabel>();
            }
        }

        public static List<Line> GetRegressionLines(RegressionData data, DescriptionStatistics desc_stat)
        {
            List<Line> Result = new List<Line>();

            var kx = (GraphicsShellConfiguration.InternalCanvasWidth)
                / Math.Sqrt(Math.Pow(desc_stat.X_max - desc_stat.X_min, 2));

            var ky = (GraphicsShellConfiguration.InternalCanvasHeight)
                / Math.Sqrt(Math.Pow(desc_stat.Y_max - desc_stat.Y_min, 2));

            for (var c = 0; c <= data.RegressionValues.Count() - 2; c++)
            {
                var X1 =  Convert.ToInt32((data.RegressionValues[c].X - desc_stat.X_min) * kx);
                var X2 =  Convert.ToInt32((data.RegressionValues[c + 1].X - desc_stat.X_min) * kx);

                var Y1 = GraphicsShellConfiguration.InternalCanvasHeight
                    - Convert.ToInt32((data.RegressionValues[c].Y - desc_stat.Y_min) * ky);
                var Y2 = GraphicsShellConfiguration.InternalCanvasHeight
                    - Convert.ToInt32((data.RegressionValues[c + 1].Y - desc_stat.Y_min) * ky);

                Result.Add(
                    new Line { X1 = X1, X2 = X2, Y1 = Y1, Y2 = Y2, Color = GraphicsShellConfiguration.RegressionLinesColor }
                );
            }

            for (var c = 0; c <= data.TrustMinValues.Count() - 2; c++)
            {
                var X1 =  Convert.ToInt32((data.TrustMinValues[c].X - desc_stat.X_min) * kx);
                var X2 =  Convert.ToInt32((data.TrustMinValues[c + 1].X - desc_stat.X_min) * kx);

                var Y1 = GraphicsShellConfiguration.InternalCanvasHeight
                    - Convert.ToInt32((data.TrustMinValues[c].Y - desc_stat.Y_min) * ky);
                var Y2 = GraphicsShellConfiguration.InternalCanvasHeight
                    - Convert.ToInt32((data.TrustMinValues[c + 1].Y - desc_stat.Y_min) * ky);

                Result.Add(
                    new Line { X1 = X1, X2 = X2, Y1 = Y1, Y2 = Y2, Color = GraphicsShellConfiguration.TrustLinesColor }
                );
            }

            for (var c = 0; c <= data.TrustMaxValues.Count() - 2; c++)
            {
                var X1 = Convert.ToInt32((data.TrustMaxValues[c].X - desc_stat.X_min) * kx);
                var X2 =  Convert.ToInt32((data.TrustMaxValues[c + 1].X - desc_stat.X_min) * kx);
                var Y1 = GraphicsShellConfiguration.InternalCanvasHeight
                    - Convert.ToInt32((data.TrustMaxValues[c].Y - desc_stat.Y_min) * ky);
                var Y2 = GraphicsShellConfiguration.InternalCanvasHeight
                    - Convert.ToInt32((data.TrustMaxValues[c + 1].Y - desc_stat.Y_min) * ky);

                Result.Add(
                    new Line { X1 = X1, X2 = X2, Y1 = Y1, Y2 = Y2, Color = GraphicsShellConfiguration.TrustLinesColor }
                );
            }

            return Result;
        }
    }
}