using System.Collections.Generic;

namespace FaceRecognition.DataAccess
{
    public class Constants
    {
        public static readonly IEnumerable<string> ValidExtensions = new List<string>
                                                                         {
                                                                             ".bmp",
                                                                             ".gif",
                                                                             ".jpg",
                                                                             ".jpeg",
                                                                             ".tif",
                                                                             ".tiff"
                                                                         };
    }
}
