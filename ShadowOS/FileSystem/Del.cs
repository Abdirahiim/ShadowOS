using Shadow_OS.Translation;
using System.IO;

namespace Shadow_OS.FileSystem
{
    class CommandDel
    {
        // Deletes a specified file
        public static void DelFile(string file)
        {
            File.Delete(file);
        }

        public static void PrintHelp()
        {
            Help.CommandDel();
        }
    }
}
