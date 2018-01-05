using System;
using Emgu.CV;
using Emgu.CV.Structure;
using FaceImagesModel;
using Microsoft.Practices.EnterpriseLibrary.ExceptionHandling;
using System.Windows.Forms;

namespace FaceRecognition.RecognitionMethods
{
    public class EigenFaceMethod : RecognitionMethodBase
    {
        #region Fields

        private EigenObjectRecognizer imgRecognizer;
        private Image<Gray, Byte>[] emguImages;
        private MCvTermCriteria termCrit;
        private String[] emguImagesLabels;

        #endregion //Fields

        #region Constructor

        public EigenFaceMethod():base()
        {
            
        }

        #endregion //Constructor

        #region Implemetation of FaceRecognitionAlgorithm

        public override bool Train()
        {
            try
            {
                if (_trainFaces != null && _trainFaces.Count != 0)
                {
                    emguImages = new Image<Gray, byte>[_trainFaces.Count];
                    for (var i = 0; i < _trainFaces.Count; i++)
                    {
                        emguImages[i] = new Image<Gray, Byte>(_trainFaces[i].FullName);
                    }

                    emguImagesLabels = new String[_trainFaces.Count];
                    for (var i = 0; i < _trainFaces.Count; i++)
                    {
                        emguImagesLabels[i] = _trainFaces[i].PersonId;
                    }


                    termCrit = new MCvTermCriteria(0.001);
                    imgRecognizer = new EigenObjectRecognizer(
                        emguImages,
                        emguImagesLabels,
                        5000,
                        ref termCrit);

                    return true;
                }
            }
            catch (Exception ex)
            {
                bool rethrow = ExceptionPolicy.HandleException(ex, "BusinessLogic Policy");
                if (rethrow)
                    throw;

                MessageBox.Show("Failed to train faces");
            }
            return false;
        }

        public override object Recognize(object testFace)
        {
            var face = testFace as FaceImage;

            if (face != null)
            {
                try
                {
                    var image = new Image<Bgr, Byte>(face.FullName);
                    var faceLabel = imgRecognizer.Recognize(image.Convert<Gray, Byte>());

                    return faceLabel;
                }
                catch (Exception ex)
                {
                    bool rethrow = ExceptionPolicy.HandleException(ex, "BisunessLogic Policy");
                    if (rethrow)
                        throw;

                    MessageBox.Show(string.Format("Failed recognize face"));
                }
            }

            return null;
        }

        #endregion //Implemetation of FaceRecognitionAlgorithms
    }
}