using System.IO;
using Shadow_OS.Translation;
using Shadow_OS.Core;

namespace Shadow_OS.FileSystem
{
    class CommandCD
    {
        //Navigates to a specified Directory
        public static void NavigateToDir(string path)
        {
            Directory.SetCurrentDirectory(Kernel.CurrentDirectory + path + @"\");
            Kernel.CurrentDirectory = Kernel.CurrentDirectory + path + @"\";
        }

        //Navigates back to the PrimaryDrive
        public static void NavigateToPrimaryDrive()
        {
            Directory.SetCurrentDirectory(Kernel.PrimaryDrive.ToString());
            Kernel.CurrentDirectory = Kernel.PrimaryDrive.ToString();
        }

        //navigates to the previous directory
        public static void NavigateToParentDir(string path)
        {
            path = Directory.GetParent(Kernel.CurrentDirectory).FullName;
            Directory.SetCurrentDirectory(path);
            Kernel.CurrentDirectory = path;
        }

          public static void PrintHelp()
          {
            Help.CommandCD();
          }
    }
}
