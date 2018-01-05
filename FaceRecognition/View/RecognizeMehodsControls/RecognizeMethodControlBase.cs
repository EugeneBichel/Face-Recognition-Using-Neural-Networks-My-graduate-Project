using System;
using System.Windows.Controls;
using FaceRecognition.ViewModel;

namespace FaceRecognition.Controls.RecognizeMehodsControls
{
    public class RecognizeMethodControlBase : UserControl
    {
        #region Fields

        protected SelectionRecognitionMethodViewModel _selectionRecMethodViewModel;

        #endregion //Fields

        #region Events

        public static event EventHandler RecognizePanelVisibleEvent;
        public static event EventHandler SavedDataEvent;

        #endregion //Events

        #region Constructor

        public RecognizeMethodControlBase()
        {
            
        }

        #endregion //Constructor

        #region Save Data

        protected virtual void OnSavedData()
        {
            var handler = SavedDataEvent;
            if (handler != null)
            {
                var args = new EventArgs();
                handler(this, args);
            }
        }

        #endregion //Save Data

        #region Make Visible RecognizePanel

        protected virtual void OnRecognizePanelVisible()
        {
            var handler = RecognizePanelVisibleEvent;
            if (handler != null)
            {
                var args = new EventArgs();
                handler(this, args);
            }
        }

        #endregion //Make Visible RecognizePanel
    }
}
