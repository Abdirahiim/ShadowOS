using Shadow_OS.Translation;

namespace Shadow_OS.System
{
    class InitReboot
    {
        public static void Reboot()
        {
            Cosmos.System.Power.Reboot();
        }

        public static void PrintHelp()
        {
            Help.SystemInfo();
        }
    }
}
