using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FaceImagesModel;
using FaceRecognition.ViewModel.CustomEventArgs;
using FaceRecognition.RecognitionMethods;
using System.Threading;
using Microsoft.Practices.EnterpriseLibrary.ExceptionHandling;

namespace FaceRecognition.ViewModel.RecognitionMethodsViewModel
{
    public class EigenFaceViewModel : RecognizeMethodsViewModelBase
    {
        #region Constructor

        public EigenFaceViewModel()
        {

        }

        #endregion //Constructor

        #region Public Methods

        public override void Train()
        {
            _faceRecognitionMethod = new EigenFaceMethod();

            var t = new Thread(ThreadPoolTrain);
            t.IsBackground = true;
            t.Start();

            if (_isTrainSuccess == true)
                _trainStatus = RecognizeMethodsViewModelBase.TrainResults[Constants.SUCCESS];
            else
                _trainStatus = TrainResults[Constants.FAILED];
            OnPropertyChanged("TrainStatus");
        }

        public override void Recognize()
        {
            if (_faceRecognitionMethod == null)
                MessageBox.Show("Please, click 'Train' button before 'Recognize' image", "'Recognize' before 'Train'", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                try
                {
                    using (_timer = new System.Timers.Timer(10))
                    {
                        LoadTrainFaces();
                        LoadTestFaces();

                        _timer.Elapsed += new System.Timers.ElapsedEventHandler(_recTimer_Elapsed);
                        _timer.Enabled = true;
                        _timer.Start();

                        foreach (FaceImage face in _testFaces)
                        {
                            var imageClass = _faceRecognitionMethod.Recognize(face) as string;
                            if (imageClass != null)
                                _imageClasses.Add(imageClass);
                        }

                        GetRecognizeFace();
                    }
                }
                catch (Exception ex)
                {
                    bool rethrow = ExceptionPolicy.HandleException(ex, "BisunessLogic Policy");
                    if (rethrow)
                        throw;

                    MessageBox.Show("Failed recognize process");
                }
            }
        }

        #endregion //Public Methods

        #region Event Handlers

        private void _trainTimer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            //TimeChanged(0.1);
            _trainTimeValue += 0.01;
            OnPropertyChanged("TrainTimeValue");
        }
        private void _recTimer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            //TimeChanged(0.1);
            _recTimeValue += 0.01;
            OnPropertyChanged("RecognizeTimeValue");
        }

        #endregion //Event Handlers

        #region ThreadPoolTrain

        private void ThreadPoolTrain()
        {
            try
            {
                using (_timer = new System.Timers.Timer(10))
                {
                    _timer.Elapsed += new System.Timers.ElapsedEventHandler(_trainTimer_Elapsed);
                    _timer.Enabled = true;
                    _timer.Start();
                    _isTrainSuccess = _faceRecognitionMethod.Train();
                }
            }
            catch (Exception ex)
            {
                bool rethrow = ExceptionPolicy.HandleException(ex,"BisunessLogic Policy");
                if (rethrow)
                    throw;

                MessageBox.Show("Failed train process");
            }
        }

        #endregion //ThreadPoolTrain
    }
}