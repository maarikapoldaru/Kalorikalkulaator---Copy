using System;
using System.Collections.Generic;
using System.Text;
//using Windows.Storage;
//using Kalorikalkulaator.UWP;
using System.IO;
using Xamarin.Forms;
using Kalorikalkulaator;
using Windows.Storage;

[assembly: Dependency(typeof(LocalFileHelper))]
namespace Kalorikalkulaator
{
    public class LocalFileHelper : IStdLocHelper
    {
        public string GetLocalFilePath(string filename)
        {
            string docFolder = ApplicationData.Current.LocalFolder.Path;
            string libFolder = Path.Combine(docFolder, "Databases");
            if (!Directory.Exists(libFolder))
            {
                Directory.CreateDirectory(libFolder);
            }
            return Path.Combine(libFolder, filename);
        }
    }
}

