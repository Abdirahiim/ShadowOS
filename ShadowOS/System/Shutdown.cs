using Shadow_OS.Translation;

namespace Shadow_OS.System
{
    class InitShutdown
    {
        public static void Shutdown()
        {
            Cosmos.System.Power.Shutdown();
        }

        public static void PrintHelp()
        {
            Help.Shutdown();
        }
    }
}
