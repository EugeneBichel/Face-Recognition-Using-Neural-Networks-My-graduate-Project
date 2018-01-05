using System;
using System.Windows;
using System.Windows.Controls;
using FaceRecognition.Export;
using FaceRecognition.Properties;
using FaceRecognition.ViewModel;
using Utility;
using Microsoft.Practices.EnterpriseLibrary.ExceptionHandling;

namespace FaceRecognition.Controls
{
    public partial class ResultsFaceRecognitionControl : UserControl
    {
        #region Fields

        private ResultsFaceRecognitionViewModel _resultsFaceRecViewModel;

        #endregion //Fields

        #region Constructor

        public ResultsFaceRecognitionControl()
        {
            _resultsFaceRecViewModel = new ResultsFaceRecognitionViewModel();
            this.DataContext = _resultsFaceRecViewModel;

            InitializeComponent();
        }

        #endregion //Constructor

        private void exportExcelButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var objExport = new ExcelExporter();
                objExport.ExportDetails(_resultsFaceRecViewModel.RecognitionMethods, System.IO.Path.Combine(Helper.GetExecutedDirectory(), Strings.FileName_ExcelResults));
            }
            catch (Exception ex)
            {
                bool rethrow = ExceptionPolicy.HandleException(ex, "UI Policy");
                if (rethrow)
                    throw;

                MessageBox.Show("Error export data");
            }
        }

        private void lstResultRecognitionMethods_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
