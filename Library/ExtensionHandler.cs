using System;
using System.IO;
using System.Linq;

namespace Thumbnail_Generator_Library
{
    public static class ExtensionHandler
    {
        public static string[] GetExtensions(string configFile)
        {
            string[] defaultExts =
            {
                "jpg", "jpeg", "png", "mp4", "mov", "wmv", "avi", "mkv"
            };

            var file = Path.Combine(AppContext.BaseDirectory, configFile);
            if (File.Exists(file))
            {
                var config = File.ReadAllText(file).Replace(" ","").TrimEnd();
                var exts = config.Split(',');
                if (exts.Any())
                {
                    return exts;
                }
            }

            return defaultExts;
        }
    }
}
