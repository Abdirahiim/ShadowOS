using Shadow_OS.Translation;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Shadow_OS.FileSystem
{
    class CommandMkdir
    {
        //Creates a Directory
        public static void CreateDirectory(string path)
        {
            Directory.CreateDirectory(path);
        }

        public static void PrintHelp()
        {
            Help.CommandMkdir();
        }
    }
}
