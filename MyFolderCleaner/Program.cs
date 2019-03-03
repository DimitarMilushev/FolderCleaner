using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFolderCleaner
{
    class Program
    {
        static void Main(string[] args)
        {
            string user = System.Security.Principal.WindowsIdentity.GetCurrent().Name.Split('\\')[1];
            string path = $@"C:\Users\{user}\Downloads";

            IEnumerable<FileInfo> directoryFiles = new DirectoryInfo(path).EnumerateFiles();

            if (directoryFiles.Count() == 0)
                return;
            else
            {
                foreach (var file in directoryFiles)
                {
                    file.Delete();
                }
            }          
        }
    }
}
