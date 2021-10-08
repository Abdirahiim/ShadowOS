using System;
using System.IO;
using Shadow_OS.Core;
using Shadow_OS.Translation;

namespace Shadow_OS.FileSystem
{
    class CommandDir
    {
        //Gets the files and Directories of a specific Directory
        public static void GetDirectoryFiles()
        {
            string[] filePaths = Directory.GetFiles(Kernel.CurrentDirectory);

            for (int i = 0; i < filePaths.Length; ++i)
            {
                string path = filePaths[i];
                Console.WriteLine(Path.GetFileName(path));
            }
            foreach (var d in Directory.GetDirectories(Kernel.CurrentDirectory))
            {
                var dir = new DirectoryInfo(d);
                var dirName = dir.Name;

                Console.WriteLine(dirName + " <DIR>");

            }
        }

        public static void PrintHelp()
        {
            Help.CommandDir();
        }
    }
}
