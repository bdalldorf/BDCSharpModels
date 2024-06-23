using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDCSharpModels.DataTransferModels.Image
{
    public class ImageDownloadRequestModel
    {
        public string ImageURLForDownload { get; set; } = string.Empty;
        public string User { get; set; } = string.Empty;
        public string ImageType { get; set; } = string.Empty;
        public string ImageOriginalName { get; set; } = string.Empty;
        public byte[] ImageBytes { get; set; } = new byte[0];
    }
}
