using Shadow_OS.Translation;

namespace Shadow_OS.ErrorHandler
{
    class CrashHandler
    {
        // The BSOD equivalent of Shadow OS (System [Kernel] crashes)
        public static string SystemCrash()
        {
            Error.SystemCrash();
            
            return "";
        }

        // Crash handler for Filesystem related crashes
        public static string FileSystemError(string errorCode)
        {
            Error.FileSystemError(errorCode);

            return "";
        }

       // System (non-Kernel) crashes
        public static string SystemError(string errorCode)
        {
            Error.SystemError(errorCode);

            return "";
        }

        // app crashes
        public static string AppError(string appName)
        {

            Error.AppError(appName);

            return "";
        }
    }
}
