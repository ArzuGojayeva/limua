using Microsoft.AspNetCore.Http.Metadata;
using Microsoft.AspNetCore.Mvc;

namespace Simple.Utilities.Extension
{
    public static class FileExtension
    {
       public static  bool CheckFileType(this IFormFile file,string type)
       {
            return file.ContentType.Contains(type);
       }
      public static bool CheckFileSize(this IFormFile file,int size)
      {
            return file.Length / 1024 < size;
       }
        public static async Task<string> SaveFile(this IFormFile file,string root)
        {
            string uniquefile = Guid.NewGuid().ToString()+ "_"+ file.FileName;
            string path = Path.Combine(root, "assets/img",uniquefile);
            FileStream stream = new FileStream(path,FileMode.Create);
            await stream.CopyToAsync(stream);
            return uniquefile;
        }
        

    }
}
