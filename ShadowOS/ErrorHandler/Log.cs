using System;
using System.Text;
using System.IO;
using Shadow_OS.Core;
using Sys = Cosmos.System;
using Shadow_OS.Translation;

namespace Shadow_OS.ErrorHandler
{
    class Log
    {
        //prints the desired log
        private static void PrintLog(string logFile)
        {
            var theFile = Sys.FileSystem.VFS.VFSManager.GetFile(logFile);
            var theFileStream = theFile.GetFileStream();

            if (theFileStream.CanRead)
            {
                byte[] text_to_read = new byte[theFileStream.Length];
                theFileStream.Read(text_to_read, 0, (int)theFileStream.Length);
                Console.WriteLine(Encoding.Default.GetString(text_to_read));
            }
        }

        // Logs kernel (BSOD) crashes
        public static Exception SystemCrash(Exception errorMessage)
        {
            string error = "ErrorCode\n" + "-----\n NAN \n";

            string errorType = "\nError Type\n" + "-------------\n Kernel \n";

            string currentDateTime = $"\nDate & Time \n-----------\n{Kernel.CurrentDay}:{Kernel.CurrentMonth}:{Kernel.CurrentYear}, {Kernel.CurrentHour}:{Kernel.CurrentMinute}:{Kernel.CurrentSecond}\n";

            string errorMsg = "\n" + "Error message" + "\n----------\n" + errorMessage.ToString();

            string completeContent = error + errorType + currentDateTime + errorMsg;

            Directory.CreateDirectory(@"0:\System\Logs");
            File.WriteAllText(@"0:\System\Logs\SystemCrash.log", completeContent);
            return errorMessage;
        }

        // Logs normal crashes
        public static Exception Crash(Exception errorMessage, string errorCode, string errorType)
        {
            string error = "ErrorCode\n" + "-----\n" + errorCode + "\n";

            string errorTpe = "\nError Type\n" + "-------------\n" + errorType + "\n";

            string currentDateTime = $"\nDate & Time \n-----------\n{Kernel.CurrentDay}:{Kernel.CurrentMonth}:{Kernel.CurrentYear}, {Kernel.CurrentHour}:{Kernel.CurrentMinute}:{Kernel.CurrentSecond}\n";

            string errorMsg = "\n" + "Error message" + "\n----------\n" + errorMessage.ToString();

            string completeContent = error + errorTpe + currentDateTime + errorMsg;

            Directory.CreateDirectory(@"0:\System\Logs");
            File.WriteAllText(@"0:\System\Logs\Crash.log", completeContent);
            return errorMessage;
        }

        // Logs app crashes
        public static Exception AppCrash(Exception errorMessage, string appName)
        {
            string app = "App Name\n" + "-----\n" + appName + "\n";

            string errorType = "\nError Type\n" + "-------------\n Apps \n";

            string currentDateTime = $"\nDate & Time \n-----------\n{Kernel.CurrentDay}:{Kernel.CurrentMonth}:{Kernel.CurrentYear}, {Kernel.CurrentHour}:{Kernel.CurrentMinute}:{Kernel.CurrentSecond}\n";

            string errorMsg = "\n" + "Error message" + "\n----------\n" + errorMessage.ToString();

            string completeContent = app + errorType + currentDateTime + errorMsg;

            Directory.CreateDirectory(@"0:\System\Logs");
            File.WriteAllText(@"0:\System\Logs\AppCrash.log", completeContent);
            return errorMessage;
        }

        // prints the log of a kernel crash
        public static void PrintSystemCrash()
        {
            if (Directory.Exists(@"0:\System\logs"))
            {
                if (File.Exists(@"0:\System\logs\SystemCrash.log"))
                {
                    PrintLog(@"0:\System\logs\SystemCrash.log");
                }
                else
                {
                    Text.LogNotFound();
                }
            }
        }

        //prints the log of a normal crash
        public static void PrintCrash()
        {
            if (Directory.Exists(@"0:\System\logs"))
            {
                if (File.Exists(@"0:\System\logs\Crash.log"))
                {
                    PrintLog(@"0:\System\logs\Crash.log");
                }
                else
                {
                    Text.LogNotFound();
                }
            }
        }

        //prints the log of an app crash
        public static void PrintAppCrash()
        {
            if (Directory.Exists(@"0:\System\logs"))
            {
                if (File.Exists(@"0:\System\logs\AppCrash.log"))
                {
                    PrintLog(@"0:\System\logs\AppCrash.log"); 
                }
                else
                {
                    Text.LogNotFound();
                }
            }
        }

        public static void PrintHelp()
        {
            Help.Log();
        }
    }
}
