using Microsoft.AspNetCore.Http;

namespace dosyaApi.Dtos
{
    public class FolderDto
    {
        public int Id { get; set; }
        public string FolderName { get; set; }
        public string DosyaAdı { get; set; }
        public string ContentType { get; set; }

        public string FileSize { get; set; }
        public DateTime Created { get; set; }

        public DateTime Updated { get; set; }
    }
}
