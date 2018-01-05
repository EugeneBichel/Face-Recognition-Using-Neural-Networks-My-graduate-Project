// Type: OpenCvSharp.IplImage
// Assembly: OpenCvSharp, Version=2.0.4105.38749, Culture=neutral, PublicKeyToken=6adad1e807fea099
// Assembly location: D:\DiplomProjects\DiplomProject\FaceDetection\dlls\OpenCvSharp.dll

using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Runtime.Serialization;

namespace OpenCvSharp
{
    [Serializable]
    public class IplImage : CvArr, ICloneable, ISerializable
    {
        public static readonly int SizeOf;
        public IplImage();
        public IplImage(string filename);
        public IplImage(string filename, LoadMode flags);
        public IplImage(CvSize size, BitDepth depth, int channels);
        public IplImage(int width, int height, BitDepth depth, int channels);
        public IplImage(IntPtr ptr);
        public IplImage(IntPtr ptr, bool isEnabledDispose);
        protected IplImage(SerializationInfo info, StreamingContext context);

        [Obsolete]
        public int Align { get; }

        [Obsolete]
        public int AlphaChannel { get; }

        [Obsolete]
        public IntPtr BorderMode { get; }

        [Obsolete]
        public IntPtr BorderConst { get; }

        [Obsolete]
        public IntPtr ColorModel { get; }

        [Obsolete]
        public IntPtr ChannelSeq { get; }

        public int DataOrder { get; }
        public BitDepth Depth { get; }
        public int Height { get; }
        public int ID { get; }
        public IntPtr ImageData { get; set; }
        public byte* ImageDataPtr { get; set; }
        public IntPtr ImageDataOrigin { get; private set; }
        public int ImageSize { get; }

        [Obsolete]
        public IntPtr MaskROI { get; }

        public int NChannels { get; }
        public int NSize { get; }
        public ImageOrigin Origin { get; }
        public IntPtr ROIPointer { get; }
        public int Width { get; }
        public int WidthStep { get; }
        public IntPtr TileInfo { get; }
        public CvSize Size { get; }
        public int COI { get; set; }
        public CvRect ROI { get; set; }
        public override int Dims { get; }
        public int Bpp { get; }

        #region ICloneable Members

        object ICloneable.Clone();

        #endregion

        #region ISerializable Members

        public void GetObjectData(SerializationInfo info, StreamingContext context);

        #endregion

        public static IplImage operator +(IplImage a);
        public static IplImage operator -(IplImage a);
        public static IplImage operator ~(IplImage a);
        public static IplImage operator +(IplImage a, IplImage b);
        public static IplImage operator +(IplImage a, CvScalar b);
        public static IplImage operator -(IplImage a, IplImage b);
        public static IplImage operator -(IplImage a, CvScalar b);
        public static IplImage operator *(IplImage a, IplImage b);
        public static IplImage operator *(IplImage a, double b);
        public static IplImage operator /(IplImage a, double b);
        public static IplImage operator &(IplImage a, IplImage b);
        public static IplImage operator &(IplImage a, CvScalar b);
        public static IplImage operator |(IplImage a, IplImage b);
        public static IplImage operator |(IplImage a, CvScalar b);
        public static IplImage operator ^(IplImage a, IplImage b);
        public static IplImage operator ^(IplImage a, CvScalar b);
        protected override void Dispose(bool disposing);
        public static IplImage FromFile(string fileName);
        public static IplImage FromFile(string fileName, LoadMode flags);
        public static IplImage FromBitmap(Bitmap bmp);
        public static IplImage FromPixelData(CvSize size, int channels, IntPtr data);
        public static IplImage FromPixelData(int width, int height, int channels, IntPtr data);
        public static IplImage FromPixelData(CvSize size, BitDepth depth, int channels, Array data);
        public static IplImage FromPixelData(int width, int height, BitDepth depth, int channels, Array data);
        public static IplImage FromPixelData(CvSize size, int channels, byte[] data);
        public static IplImage FromPixelData(int width, int height, int channels, byte[] data);
        public static IplImage FromPixelData(CvSize size, int channels, short[] data);
        public static IplImage FromPixelData(int width, int height, int channels, short[] data);
        public int CheckChessboard(CvSize size);
        public IplImage Clone();
        public static IplImage CreateHeader(CvSize size, BitDepth depth, int channels);
        public void DeleteMoire();
        public CvSeq<CvFaceData> FindFace(CvMemStorage storage);
        public int GetCOI();
        public CvRect GetROI();
        public static IplImage InitImageHeader(CvSize size, BitDepth depth, int channels);
        public static IplImage InitImageHeader(CvSize size, BitDepth depth, int channels, ImageOrigin origin);
        public static IplImage InitImageHeader(CvSize size, BitDepth depth, int channels, ImageOrigin origin, int align);
        public CvSeq<CvFaceData> PostBoostingFindFace(CvMemStorage storage);
        public void PyrSegmentation(IplImage dst, int level, double threshold1, double threshold2);

        public void PyrSegmentation(IplImage dst, CvMemStorage storage, out CvSeq comp, int level, double threshold1,
                                    double threshold2);

        public void ResetROI();
        public void SetImageCOI(int coi);
        public void SetROI(CvRect rect);

        public void SnakeImage(CvPoint[] points, float alpha, float beta, float gamma, CvSize win,
                               CvTermCriteria criteria);

        public void SnakeImage(CvPoint[] points, float alpha, float beta, float gamma, CvSize win,
                               CvTermCriteria criteria, bool calc_gradient);

        public void SnakeImage(CvPoint[] points, float[] alpha, float[] beta, float[] gamma, CvSize win,
                               CvTermCriteria criteria);

        public void SnakeImage(CvPoint[] points, float[] alpha, float[] beta, float[] gamma, CvSize win,
                               CvTermCriteria criteria, bool calc_gradient);

        public IplImage[] Split();
        public IplImage Transpose();
        public IplImage T();
        public void CopyFrom(Bitmap bmp);
        public void CopyPixelData(Array data);
        public void CopyPixelData(IntPtr data);
        public Bitmap ToBitmap();
        public Bitmap ToBitmap(PixelFormat pf);
        public void ToBitmap(Bitmap dst);
        public void DrawToHDC(IntPtr hdc, CvRect dstRect);
        public void DrawToHDC(IntPtr hdc, int x, int y, int w, int h, int from_x, int from_y);
        public void DrawToGraphics(Graphics g, CvRect dstRect);
        public void DrawToGraphics(Graphics g, int x, int y, int w, int h, int from_x, int from_y);
        public IplImage GetSubImage(CvRect rect);
    }
}
