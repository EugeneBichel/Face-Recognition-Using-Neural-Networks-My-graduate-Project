using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using FaceImagesModel;
using Microsoft.Practices.EnterpriseLibrary.ExceptionHandling;

namespace ImageView.Themes
{
    public partial class Generic
    {
        #region Constants

        private static readonly List<string> _listViews = new List<string>() { "faceImagesListView", "TrainImageBeforePreprocListView", "TestImageBeforePreprocListView" };

        #endregion //Constants

        #region Fields

        private List<FaceImage> _selectedFaceImages;
        private ListView _listView;

        #endregion //Fields

        #region Constructor

        public Generic()
        {
            
        }

        #endregion //Constructor

        #region Handlers

        private void DragImage(object sender, MouseButtonEventArgs e)
        {
            if ((e.Source as Image) == null)
                throw new ArgumentNullException("e");

            var image = e.Source as Image;

            DependencyObject current = image;
            DependencyObject result = image;

            try
            {

                while (current as ListView == null)
                {
                    result = current;
                    if (current is Visual)
                        current = VisualTreeHelper.GetParent(current);
                }

                _listView = current as ListView;
            }
            catch (Exception ex)
            {
                bool rethrow = ExceptionPolicy.HandleException(ex, "UI Policy");
                if (rethrow)
                    throw;

                MessageBox.Show(string.Format("Failed find ListView"));
            }

            if (_listView == null)
                throw new ArgumentException("_listView");

            if (_listViews.Contains(_listView.Name) == false)
                return;

            _selectedFaceImages = new List<FaceImage>();

            foreach (FaceImage value in _listView.SelectedItems)
                _selectedFaceImages.Add(value);

            var data = new DataObject("myFormat", _selectedFaceImages);
            DragDrop.DoDragDrop(image, data, DragDropEffects.Copy);
        }

        #endregion //Handlers
    }
}
