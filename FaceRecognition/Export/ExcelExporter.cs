using System;
using System.Collections.ObjectModel;
using System.Data;
using System.Windows.Forms;
using FaceRecognition.RecognitionMethods.MethodModel;
using Microsoft.Office.Interop.Excel;
using Microsoft.Practices.EnterpriseLibrary.ExceptionHandling;
using System.Runtime.InteropServices;

namespace FaceRecognition.Export
{
    public class ExcelExporter
    {
        #region Constructor

        public ExcelExporter()
        {
            
        }

        #endregion //Constructor

        #region ExportDetails

        public void ExportDetails(ObservableCollection<RecognitionMethodModel> methods, string fileName)
        {
            try
            {
                if (methods.Count == 0)
                    throw new Exception("There are no details to export.");

                // Create Dataset
                DataSet ds = new DataSet("Export Recognition Methods");               
                System.Data.DataTable table = new System.Data.DataTable("Recognition Methods");
                table.Columns.Add(new DataColumn("Recognition Method"));
                table.Columns.Add(new DataColumn("Recognition Time (s)"));
                table.Columns.Add(new DataColumn("Recognition Percent (%)"));
                foreach (RecognitionMethodModel method in methods)
                {
                    table.Rows.Add(method.Name, method.TimeRecognize.ToString(), method.RecognitionPercent.ToString());
                }

                ds.Tables.Add(table);

                string data = null;
                object misValue = System.Reflection.Missing.Value;

                Microsoft.Office.Interop.Excel.Application xlApp = new Microsoft.Office.Interop.Excel.Application();
                Workbook xlWorkBook = xlApp.Workbooks.Add(misValue);
                Worksheet xlWorkSheet = (Worksheet)xlWorkBook.Worksheets.get_Item(1);

                    xlWorkSheet.Cells[1, 1] = "Recognition Method";
                xlWorkSheet.Cells[1, 2] = "RecognitionTime (s)";
                xlWorkSheet.Cells[1, 3] = "Recognition Percents (%)";

                for (var i = 0; i <= ds.Tables[0].Rows.Count - 1; i++)
                {
                    for (var j = 0; j <= ds.Tables[0].Columns.Count - 1; j++)
                    {
                        data = ds.Tables[0].Rows[i].ItemArray[j].ToString();
                        xlWorkSheet.Cells[i + 2, j + 1] = data.Replace(',','.');
                    }
                }

                xlWorkBook.SaveAs(fileName, XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue, XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);
                xlWorkBook.Close(true, misValue, misValue);
                xlApp.Quit();

                ReleaseObject(xlWorkSheet);
                ReleaseObject(xlWorkBook);
                ReleaseObject(xlApp);

            }
            catch (Exception ex)
            {
                bool rethrow = ExceptionPolicy.HandleException(ex, "IO Policy");
                if (rethrow)
                    throw;

                MessageBox.Show("Failed export to excel file");
            }
        }

        #endregion // ExportDetails

        private void ReleaseObject(object obj)
        {
            try
            {
                Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch (Exception ex)
            {
                obj = null;

                bool rethrow = ExceptionPolicy.HandleException(ex, "ReleaseData Policy");
                if (rethrow)
                    throw;

                MessageBox.Show("Exception Occured while releasing object " + ex.ToString());
            }
            finally
            {
                GC.Collect();
            }
        }
    }
}