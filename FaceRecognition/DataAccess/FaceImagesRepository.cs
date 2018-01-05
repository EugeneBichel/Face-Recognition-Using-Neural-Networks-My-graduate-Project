using System;
using System.IO;
using System.Reflection;
using Utility;
using FaceImagesModel;
using FaceDetection;
using FaceImagesModel.Properties;
using System.Windows.Forms;
using System.Collections.Generic;
using FaceRecognition.Model.FaceImagesModel;

namespace FaceRecognition.DataAccess
{
    public class FaceImagesRepository
    {
        #region Fields

        private FaceDataBases _imageDataBases;
        private FaceDataBases _faceDataBases;

        #endregion //Fields

        #region Constructor

        public FaceImagesRepository()
        {
            FdFaceDetection.FacesAdded += new EventHandler<FacesAddedEventArgs>(FaceDataBasesRepository_FaceAdded);
        }

        #endregion //Constructor

        #region Public Properties

        public FaceDataBases ImageDataBases 
        { 
            get 
            {
                if (_imageDataBases == null)
                    LoadImagesDataBases(Strings.Images_Database_Folder_Name);
                return _imageDataBases; 
            } 
        }
        public FaceDataBases FaceDataBases
        {
            get
            {
                if (_faceDataBases == null)
                    LoadImagesDataBases(Strings.Face_Database_Folder_Name);
                return _faceDataBases;
            }
        }

        #endregion //Public Properties

        #region Handlers

        private void FaceDataBasesRepository_FaceAdded(object sender, FacesAddedEventArgs e)
        {
            AddFaces(e.NewFaces);
        }

        #endregion //Handlers

        #region Private Methods

        private void AddFaces(IEnumerable<FaceImage> faces)
        {
            if (_faceDataBases == null || _faceDataBases.Count == 0)
                LoadImagesDataBases(Strings.Face_Database_Folder_Name);
            else
            {
                foreach (FaceImage face in faces)
                {
                    if (_faceDataBases[face.ShortNameDb].FaceImages.Contains(face) == false)
                        _faceDataBases[face.ShortNameDb].FaceImages.Add(face);
                }
            }
        }

        private void LoadImagesDataBases(string dbFolderName)
        {
            var dirPath = GetImagesDataBasesRepository(dbFolderName);

            if (dbFolderName == Strings.Face_Database_Folder_Name)
            {
                _faceDataBases = LoadFolders(dirPath);
                LoadImages(_faceDataBases);
            }
            else if (dbFolderName == Strings.Images_Database_Folder_Name)
            {
                _imageDataBases = LoadFolders(dirPath);
                LoadImages(_imageDataBases);
            }
        }

        private string GetImagesDataBasesRepository(string dbFolderName)
        {
            var dirPath = Path.Combine(Helper.GetExecutedDirectory(), dbFolderName);

            if (Directory.Exists(dirPath) == false)
                Directory.CreateDirectory(dirPath);

            return dirPath;
        }
        private FaceDataBases LoadFolders(string dbRepository)
        {
            var dbList = Directory.EnumerateDirectories(dbRepository);
            var dataBasesRep = new FaceDataBases();

            foreach (var fullName in dbList)
            {
                var shortName = Helper.GetShortName(fullName);
                var dataBase = new FaceDataBase { FullName = fullName, ShortName = shortName };
                dataBasesRep.Add(dataBase);
            }

            return dataBasesRep;
        }
        private void LoadImages(FaceDataBases selectedDataBasesRep)
        {
            int iDb = -1;

            foreach (FaceDataBase faceDataBase in selectedDataBasesRep)
            {
                iDb++;

                var nameImageDataBase = Helper.GetShortName(faceDataBase.FullName);
                var imageDirs = Directory.EnumerateDirectories(faceDataBase.FullName);
                var faceImages = new FaceImages();
                foreach (var imageDir in imageDirs)
                {
                    foreach (var fullName in Directory.EnumerateFiles(imageDir))
                    {
                        foreach (var extension in Constants.ValidExtensions)
                        {
                            if (fullName.EndsWith(extension))
                            {
                                var shortName = Helper.GetShortName(fullName);
                                var personId = Helper.GetShortName(imageDir);
                                var faceImage = new FaceImage(shortName, fullName, personId, nameImageDataBase);
                                faceImages.Add(faceImage);
                                break;
                            }
                        }
                    }
                }

                selectedDataBasesRep[iDb].Add(faceImages);
            }
        }

        #endregion //Private Methods
    }
}