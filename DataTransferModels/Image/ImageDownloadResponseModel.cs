using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace BDCSharpModels.DataTransferModels.Image
{
    public class ImageDownloadResponseModel
    {
        public string UniqueID { get; set; } = string.Empty;
        public string WebPageURL { get; set; } = string.Empty;
        public string WebPageFilePath { get; set; } = string.Empty;
        public string ImageTitle { get; set; } = string.Empty;
        public string ImageDescription { get; set; } = string.Empty;
        public string ImageFileTags { get; set; } = string.Empty;
        public int ImagePreviewStartTime { get; set; } = 0;
        public string ImageFileURL { get; set; } = string.Empty;
        public string ImageFileStreamURL { get; set; } = string.Empty;
        public byte[] ImageBytes { get; set; } = new byte[0];
        public string PreviewImageURL {  get; set; } = string.Empty;
        public byte[] PreviewImageBytes { get; set; } = new byte[0];
        public string WebPageTemplatePath { get; set; } = string.Empty;
        public string OriginalDownloadURL { get; set; } = string.Empty;
        public string APIFileDownloadURL { get; set; } = string.Empty;
        public string APIUpdateImageImageURL { get; set; } = string.Empty;
        public string APIUpdateHTMLPageURL { get; set; } = string.Empty;
        public bool IsImageDownloaded { get; set; } = false;
        public bool Error { get; set; } = false;
        public string ErrorMessage { get; set; } = string.Empty;
    }
}
