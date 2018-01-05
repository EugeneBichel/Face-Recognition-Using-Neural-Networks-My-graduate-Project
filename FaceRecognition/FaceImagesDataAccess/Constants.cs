using System.Collections.Generic;

namespace FaceImagesDataAccess
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
