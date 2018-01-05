using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using FaceRecognition.ViewModel;

namespace FaceRecognition.Controls
{
    public partial class RecognizeClassControl : UserControl
    {
        #region Fields

        private RecognizeClassViewModel _recognizedClassViewModel;

        #endregion //Fields

        #region Constructor

        public RecognizeClassControl()
        {
            _recognizedClassViewModel = new RecognizeClassViewModel();
            this.DataContext = _recognizedClassViewModel;

            InitializeComponent();
        }

        #endregion //Constructor

        #region Public Properties

        public RecognizeClassViewModel RecognizedClassViewModel
        {
            get { return _recognizedClassViewModel; }
        }

        #endregion //Public Properties
    }
}
