using EStatAnalyser.Web.User.Desktop.Core.Configuration;
using EStatAnalyser.Web.User.Desktop.Core.Entities.DataEntities;
using EStatAnalyser.Web.User.Desktop.Core.Entities.GraphicsShellEntities;
using EStatAnalyser.Web.User.Desktop.UI.AppService;
using System.Collections.Generic;
using System.Windows;

namespace EStatAnalyser.Web.User.Desktop.UI.ViewModels
{
    public class DataAnalysisViewModel : NotifyPropertyChanged
    {
        #region Определение размеров графиков (внутренний)

        public int InternalFrameHeight
        {
            get
            {
                return GraphicsShellConfiguration.InternalCanvasHeight + GraphicsShellConfiguration.PointRadius + 2;
            }
        }

        public int InternalCanvasHeight
        {
            get
            {
                return GraphicsShellConfiguration.InternalCanvasHeight + GraphicsShellConfiguration.PointRadius;
            }
        }

        public int InternalFrameWidth
        {
            get
            {
                return GraphicsShellConfiguration.InternalCanvasWidth + GraphicsShellConfiguration.PointRadius + 2;
            }
        }

        public int InternalCanvasWidth
        {
            get
            {
                return GraphicsShellConfiguration.InternalCanvasWidth + GraphicsShellConfiguration.PointRadius;
            }
        }

        #endregion

        #region Определение размеров графиков (внешний)

        public int ExternalFrameHeight
        {
            get
            {
                return GraphicsShellConfiguration.ExternalCanvasHeight + GraphicsShellConfiguration.PointRadius + 2;
            }
        }

        public int ExternalCanvasHeight
        {
            get
            {
                return GraphicsShellConfiguration.ExternalCanvasHeight + GraphicsShellConfiguration.PointRadius;
            }
        }

        public int ExternalFrameWidth
        {
            get
            {
                return GraphicsShellConfiguration.ExternalCanvasWidth + GraphicsShellConfiguration.PointRadius + 2 + 30;
            }
        }

        public int ExternalCanvasWidth
        {
            get
            {
                return GraphicsShellConfiguration.ExternalCanvasWidth + GraphicsShellConfiguration.PointRadius + 30;
            }
        }

        #endregion

        #region Data

        public List<Sphere> mainData;
        public List<Sphere> MainData
        {
            get
            {
                return mainData;
            }
            set
            {
                mainData = value;
                CheckChanges();
            }
        }

        public List<TextLabel> labelData;
        public List<TextLabel> LabelData
        {
            get { return labelData; }
            set
            {
                labelData = value;
                CheckChanges();
            }
        }

        public List<Line> linesData;
        public List<Line> LinesData
        {
            get { return linesData; }
            set
            {
                linesData = value;
                CheckChanges();
            }
        }

        public UploadData analysisData = AppData.AnalysisData;
        public UploadData AnalysisData
        {
            get { return analysisData; }
            set
            {
                analysisData = value;
                CheckChanges();
            }
        }


        #endregion

        #region Diagram data

        public string? xFieldName = AppData.AnalysisData.XFieldName;
        public string? XFieldName
        {
            get { return xFieldName; }
            set
            {
                xFieldName = value;
                CheckChanges();
            }
        }

        public string? yFieldName = AppData.AnalysisData.YFieldName;
        public string? YFieldName
        {
            get { return yFieldName; }
            set
            {
                yFieldName = value;
                CheckChanges();
            }
        }

        #endregion

        #region Main 

        public double thresholdZ;
        public double ThresholdZ
        {
            get { return thresholdZ; }
            set
            {
                thresholdZ = value;
                CheckChanges();
            }
        }

        public Command ZFiltration
        {
            get
            {
                return new Command(
                    obj =>
                    {

                    }    
                );
            }
        }

        public Command ResetFiltration
        {
            get
            {
                return new Command(
                    obj =>
                    {

                    }
                );
            }
        }

        public Command Regression
        {
            get
            {
                return new Command(
                    obj =>
                    {

                    }
                );
            }
        }

        public Command DescStatistics
        {
            get
            {
                return new Command(
                    obj =>
                    {

                    }
                );
            }
        }

        public string? analysisResult;
        public string? AnalysisResult
        {
            get { return analysisResult; }
            set
            {
                analysisResult = value;
                CheckChanges();
            }
        }

        public string? reportName;
        public string? ReportName
        {
            get { return reportName; }
            set
            {
                reportName = value;
                CheckChanges();
            }
        }

        public Command CreateReport
        {
            get
            {
                return new Command(
                    obj =>
                    {

                    }    
                );
            }
        }

        #endregion

        #region

        public Command Help
        {
            get
            {
                return new Command(
                    obj =>
                    {
                        var Content = AppData.AnalysisData.Description;
                        MessageBox.Show(Content);
                    }
                );
            }
        }

        public Command Close
        {
            get
            {
                return new Command(
                    obj =>
                    {
                        AppData.AnalysisData.Id = 0;
                        AppData.AnalysisData.XFieldName = "";
                        AppData.AnalysisData.YFieldName = "";
                        AppData.AnalysisData.DataType = "";
                        AppData.AnalysisData.Description = "";
                        AppData.AnalysisData.Values.Clear();

                        WindowsObjects.DataAnalysisWindow.Close();
                        WindowsObjects.DataAnalysisWindow = null;
                    }
                );
            }
        }

        #endregion
    }
}