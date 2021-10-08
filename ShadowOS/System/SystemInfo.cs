using Shadow_OS.Translation;

namespace Shadow_OS.System
{
    class SystemInfo
    {
        //fetches the system information
        public static string GetSystemInfo()
        {
            Text.SystemInfoTL();
            return "";
        }

        public static string GetAmountRAM()
        {
            return Cosmos.Core.CPU.GetAmountOfRAM() + "MB";
        }

        public static string GetCPUDetails()
        {
            return Cosmos.Core.CPU.GetCPUBrandString();
        }

        public static void PrintHelp()
        {
            Help.SystemInfo();
        }
    }
}
