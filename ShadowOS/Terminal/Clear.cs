using System;
using Shadow_OS.Translation;
using Shadow_OS.Core;

namespace Shadow_OS.Terminal
{
    class ClearCMD
    {
        public static void Clear()
        {
            Console.Clear();
            Console.WriteLine(Kernel.Logo);
        }

        public static void PrintHelp()
        {
            Help.CommandClear();
        }
    }
}
