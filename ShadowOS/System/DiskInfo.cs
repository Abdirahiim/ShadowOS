using Shadow_OS.Translation;

namespace Shadow_OS.System
{
    class DiskInfo
    {
        //fetches the disk information
        public static void GetDiskInfo()
        {
            Text.DiskInfoTL();
        }

        public static void PrintHelp()
        {
            Help.DiskInfo();
        }
    }
}
