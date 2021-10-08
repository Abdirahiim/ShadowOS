using System;
using System.Text;
using Sys = Cosmos.System;
using Shadow_OS.Translation;

namespace Shadow_OS.FileSystem
{
    class CommandCat
    {
        //Shows the content of the specified file
        public static string ReadFile(string file)
        {
            var TheFile = Sys.FileSystem.VFS.VFSManager.GetFile(file);
            var TheFileStream = TheFile.GetFileStream();

            if (TheFileStream.CanRead)
            {
                byte[] text_to_read = new byte[TheFileStream.Length];
                TheFileStream.Read(text_to_read, 0, (int)TheFileStream.Length);
                Console.WriteLine(Encoding.Default.GetString(text_to_read));
            }
            return "";
        }

        public static void PrintHelp()
        {
            Help.CommandCD();
        }
    }
}
