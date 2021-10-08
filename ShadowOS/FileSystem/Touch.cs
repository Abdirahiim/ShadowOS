using System.IO;
using Shadow_OS.Translation;

namespace Shadow_OS.FileSystem
{
    class CommandTouch
    {
        //Creates a file
        public static void CreateFile(string file)
        {
            File.Create(file);

        }

        public static void PrintHelp()
        {
            Help.CommandTouch();
        }
    }
}
