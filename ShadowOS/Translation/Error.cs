using System;
using Sys = Cosmos.System;
using Shadow_OS.Core;

namespace Shadow_OS.Translation
{
    //Contains the translations of error and crash texts
    class Error
    {
        // Crash text for System (kernel) crashes
        public static void SystemCrash()
        {
            switch (Kernel.Lang)
            {
                case "en_us":
                    Console.Clear();
                    Console.WriteLine(Kernel.CrashLogo + " \n   Something went wrong!!");
                    Console.WriteLine("Press any key to reboot");
                    Console.ReadLine();
                    Sys.Power.Reboot();
                    break;

                case "da":
                    Console.Clear();
                    Console.WriteLine(Kernel.CrashLogo + " \n   Noget gik galt!!");
                    Console.WriteLine("Tryk på en vilkårlig tast for at genstarte");
                    Console.ReadLine();
                    Sys.Power.Reboot();
                    break;

                case "so":
                    Console.Clear();
                    Console.WriteLine(Kernel.CrashLogo + " \n   Waxbaa khaldamay!!");
                    Console.WriteLine("Badhan taabo sidaad dib u daartid");
                    Console.ReadLine();
                    Sys.Power.Reboot();
                    break;
            }
        }

        // Crash text for System (non-kernel) crashes
        public static void SystemError(string errorCode)
        {
            switch (Kernel.Lang)
            {
                case "en_us":
                    Console.Clear();
                    Console.Write("[ERROR: " + errorCode + "] ", Console.ForegroundColor = ConsoleColor.Red);
                    Console.WriteLine("Something went wrong while fetching the information", Console.ForegroundColor = ConsoleColor.White);
                    Console.WriteLine("Press any key to reboot");
                    Console.ReadLine();
                    Sys.Power.Reboot();
                    break;

                case "da":
                    Console.Clear();
                    Console.Write("[ERROR: " + errorCode + "] ", Console.ForegroundColor = ConsoleColor.Red);
                    Console.WriteLine("Noget gik galt mens oplysningerne blev hentet", Console.ForegroundColor = ConsoleColor.White);
                    Console.WriteLine("Tryk på en vilkårlig tast for at genstarte");
                    Console.ReadLine();
                    Sys.Power.Reboot();
                    break;

                case "so":
                    Console.Clear();
                    Console.Write("[ERROR: " + errorCode + "] ", Console.ForegroundColor = ConsoleColor.Red);
                    Console.WriteLine("Waxbaa khaldamay anagoo macluumaadka soo xiganayna", Console.ForegroundColor = ConsoleColor.White);
                    Console.WriteLine("Badhan taabo sidaad dib u daartid");
                    Console.ReadLine();
                    Sys.Power.Reboot();
                    break;
            }
        }

        // Crash text for Filesytem related crashes
        public static void FileSystemError(string errorCode)
        {
            switch (Kernel.Lang)
            {
                case "en_us":
                    Console.Clear();
                    Console.Write("[ERROR: " + errorCode + "] ", Console.ForegroundColor = ConsoleColor.Red);
                    Console.WriteLine("Something went wrong with the Filesystem", Console.ForegroundColor = ConsoleColor.White);
                    Console.WriteLine("Press any key to reboot");
                    Console.ReadLine();
                    Sys.Power.Reboot();
                    break;

                case "da":
                    Console.Clear();
                    Console.Write("[ERROR: " + errorCode + "] ", Console.ForegroundColor = ConsoleColor.Red);
                    Console.WriteLine("Noget gik galt med Filsystemet", Console.ForegroundColor = ConsoleColor.White);
                    Console.WriteLine("Tryk på en vilkårlig tast for at genstarte");
                    Console.ReadLine();
                    Sys.Power.Reboot();
                    break;

                case "so":
                    Console.Clear();
                    Console.Write("[ERROR: " + errorCode + "] ", Console.ForegroundColor = ConsoleColor.Red);
                    Console.WriteLine("Waxbaa ka khaldamay system ka faylasha", Console.ForegroundColor = ConsoleColor.White);
                    Console.WriteLine("Badhan taabo sidaad dib u daartid");
                    Console.ReadLine();
                    Sys.Power.Reboot();
                    break;
            }
        }

        public static void CommandFileArgumentException(string command)
        {
            switch (Kernel.Lang)
            {
                case "en_us":
                    Console.WriteLine(command + ": missing file name");
                    break;

                case "da":
                    Console.WriteLine(command + ": mangler filnavn");
                    break;

                case "so":
                    Console.WriteLine(command + ": Magaca faylka ayaa ka dhiman");
                    break;
            }
        }

        public static void CommandPathArgumentException(string command)
        {
            switch (Kernel.Lang)
            {
                case "en_us":
                    Console.WriteLine(command + ": missing path");
                    break;

                case "da":
                    Console.WriteLine(command + ": mangler sti");
                    break;

                case "so":
                    Console.WriteLine(command + ": meesha faylasha ka ayaa dhiman");
                    break;
            }
        }

        public static void CommandFileNotFoundException(string command)
        {
            switch (Kernel.Lang)
            {
                case "en_us":
                    Console.WriteLine(command + ": File not found");
                    break;

                case "da":
                    Console.WriteLine(command + ": Fil ikke fundet");
                    break;

                case "so":
                    Console.WriteLine(command + ": Fayl ma helin");
                    break;
            }
        }

        public static void CommandDirectoryNotFoundException(string command)
        {
            switch (Kernel.Lang)
            {
                case "en_us":
                    Console.WriteLine(command + ": Directory not found");
                    break;

                case "da":
                    Console.WriteLine(command + ": Sti ikke fundet");
                    break;

                case "so":
                    Console.WriteLine(command + ": Meesha faylasha ma helin  ");
                    break;
            }
        }

        // crash text for app crashes
        public static void AppError(string appName)
        {
            switch (Kernel.Lang)
            {
                case "en_us":
                    Console.WriteLine($"Something went wrong with {appName}");
                    break;

                case "da":
                    Console.WriteLine($"Noget gik galt med {appName}");
                    break;

                case "so":
                    Console.WriteLine($"Waxbaa ka khaldamay {appName}");
                    break;
            }
        }

    }
}