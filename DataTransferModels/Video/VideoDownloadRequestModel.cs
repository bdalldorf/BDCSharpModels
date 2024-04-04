using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDCSharpModels.DataTransferModels.Video
{
    public class VideoDownloadRequestModel
    {
        public string VideoURLForDownload { get; set; } = string.Empty;
        public string User { get; set; } = string.Empty;
    }
}
