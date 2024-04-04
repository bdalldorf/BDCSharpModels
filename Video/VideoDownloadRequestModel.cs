using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDCSharpModels.Video
{
    public class VideoDownloadRequestModel
    {
        public string APIRequestURL { get; set; } = string.Empty;
        public string DownloadURL { get; set; } = string.Empty;
        public string User { get; set; } = string.Empty;
    }
}
