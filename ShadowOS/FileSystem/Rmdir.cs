using System.IO;
using Shadow_OS.Translation;

namespace Shadow_OS.FileSystem
{
    class CommandRmdir
    {
        //Deletes a directory and its contents
        public static void DeleteDirectory(string path)
        {
            Directory.Delete(path, true);
        }

        public static void PrintHelp()
        {
            Help.CommandRmdir();
        }
    }
}
