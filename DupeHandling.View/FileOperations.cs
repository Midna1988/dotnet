using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Microsoft.VisualBasic.FileIO;

namespace DupeHandling
{
    class FileOperations
    {
        public string path;
        public string fileName;

        public void DeleteFileToBin(string file)
        {
            FileSystem.DeleteFile(file, UIOption.OnlyErrorDialogs, RecycleOption.SendToRecycleBin);
        }

        public void DeleteFile(string file)
        {
            File.Delete(file);

        }
    }
}
