using System;
using System.Windows;
using System.Windows.Threading;
using Microsoft.Practices.EnterpriseLibrary.Common.Configuration;
using Microsoft.Practices.EnterpriseLibrary.ExceptionHandling;

namespace FaceRecognition
{
    public partial class App : Application
    {
        private void Application_DispatcherUnhandledException(object sender, DispatcherUnhandledExceptionEventArgs e)
        {
            // Handle unhandled exceptions
            Current.DispatcherUnhandledException +=
                new DispatcherUnhandledExceptionEventHandler(Current_DispatcherUnhandledException);

            AppDomain.CurrentDomain.UnhandledException +=
                new UnhandledExceptionEventHandler(CurrentDomain_UnhandledException);

            e.Handled = true;
        }

        private static void Current_DispatcherUnhandledException(object sender, DispatcherUnhandledExceptionEventArgs e)
        {
            HandleException(e.Exception, "Unhandled Policy");
        }

        private static void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            if (e.ExceptionObject is System.Exception)
            {
                HandleException((System.Exception)e.ExceptionObject, "Unhandled Policy");
            }
        }

        private static void HandleException(Exception ex, string policy)
        {
            var rethrow = false;

            var exManager = EnterpriseLibraryContainer.Current.GetInstance<ExceptionManager>();

            try
            {
                rethrow = exManager.HandleException(ex, policy);
            }
            catch (Exception innerEx)
            {
                string errorMsg = "An unexpected exception occured while " +
                    "calling HandleException with policy '" + policy + "'. ";
                errorMsg += Environment.NewLine + innerEx.ToString();

                MessageBox.Show(errorMsg, "Application Error",
                    MessageBoxButton.OK, MessageBoxImage.Stop);

                throw ex;
            }

            if (rethrow)
            {
                throw ex;
            }
            else
            {
                MessageBox.Show("An unhandled exception occurred and has " +
                    "been logged.");
            }
        }
    }
}
