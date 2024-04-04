using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDCSharpModels.Models.Video
{
    public class VideoDownloadModel
    {
        public string UniqueID { get; set; } = string.Empty;
        public string WebPageURL { get; set; } = string.Empty;
        public string WebPageFilePath { get; set; } = string.Empty;
        public string WebPageTemplatePath { get; set; } = string.Empty;
        public string VideoTitle { get; set; } = string.Empty;
        public string VideoDescription { get; set; } = string.Empty;
        public string VideoFileURL { get; set; } = string.Empty;
        public string VideoFilePath { get; set; } = string.Empty;
        public byte[] VideoBytes { get; set; } = new byte[0];
        public string PreviewImageURL { get; set; } = string.Empty;
        public string PreviewImagePath { get; set; } = string.Empty;
        public byte[] PreviewImageBytes { get; set; } = new byte[0];
        public string OriginalDownloadURL { get; set; } = string.Empty;
        public bool Error { get; set; } = false;
        public string ErrorMessage { get; set; } = string.Empty;
    }
}
