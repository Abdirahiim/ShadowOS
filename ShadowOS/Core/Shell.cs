using System;
using System.IO;
using Shadow_OS.FileSystem;
using Shadow_OS.ErrorHandler;
using Shadow_OS.System;
using Shadow_OS.Apps.TextEditor;
using Shadow_OS.Apps.Games;
using Shadow_OS.Translation;
using Shadow_OS.Apps;

namespace Shadow_OS.Core
{
    class Shell
    {

        public static void Prompt(string cmdline)
        {

            string commandLower = cmdline.ToLower();
            string command = commandLower.Trim();

            if (command == "ver")
            {
                try
                {
                    Console.WriteLine(Kernel.CurrentVersion);
                }
                catch (Exception)
                {

                }

            }
            else if (command.StartsWith("systeminfo"))
            {
                try
                {
                    if (command.Contains("--help"))
                    {
                        SystemInfo.PrintHelp();
                    }
                    else
                    {
                        SystemInfo.GetSystemInfo();                       
                    }

                }
                catch (Exception ex)
                {
                    Log.Crash(errorMessage: ex, errorCode: ErrorHandler.System.SystemInfoErrorCode, errorType: "System");
                    CrashHandler.SystemError(errorCode: ErrorHandler.System.SystemInfoErrorCode);
                }
            }
            else if (command.StartsWith("clear"))
            {
                try
                {
                    if (command.Contains("--help"))
                    {
                        Help.CommandClear();
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine(Kernel.Logo);

                    }
                }
                catch (Exception ex)
                {

                    Log.Crash(errorMessage: ex, errorCode: Terminal.ClearCommandErrorCode, errorType: "Terminal");
                }

            }
            else if (command.StartsWith("help"))
            {
                try
                {
                    Text.Help(); 
                }
                catch (Exception ex)
                {

                    Log.Crash(errorMessage: ex, errorCode: Terminal.HelpCommandErrorCode, errorType: "Terminal");
                }

            }
            else if (command.StartsWith("dir"))
            {
                try
                {
                    if (command.Contains("--help"))
                    {
                        CommandDir.PrintHelp();
                    }
                    else
                    {
                        CommandDir.GetDirectoryFiles();

                    }

                }
                catch (Exception ex)
                {
                    Log.Crash(errorMessage: ex, errorCode: ErrorHandler.FileSystem.DirCommandErrorCode, errorType: "Filesystem");
                    CrashHandler.FileSystemError(errorCode: ErrorHandler.FileSystem.DirCommandErrorCode);                   
                }

            }
            else if (command.StartsWith("del"))
            {
                try
                {
                    if (command.Contains("--help"))
                    {
                        CommandDel.PrintHelp();
                    }
                    else
                    {
                        CommandDel.DelFile(Kernel.CurrentDirectory + command.Substring(4));
                    }
                }
                catch (Exception ex)
                {
                    if (ex is ArgumentException)
                    {
                        Error.CommandFileArgumentException(command);
                    }
                    else if (ex is FileNotFoundException)
                    {
                        Error.CommandFileNotFoundException(command);
                    }
                    else
                    {
                        Log.Crash(errorMessage: ex, errorCode: ErrorHandler.FileSystem.DeleteFileErrorCode, errorType: "Filesystem");
                        CrashHandler.FileSystemError(errorCode: ErrorHandler.FileSystem.DeleteFileErrorCode);
                    }
                }

            }
            else if (command.StartsWith("touch"))
            {
                try
                {
                    if (command.Contains("--help"))
                    {
                        CommandTouch.PrintHelp();
                    }
                    else
                    {
                        CommandTouch.CreateFile(Kernel.CurrentDirectory + command.Substring(6));

                    }
                }
                catch (Exception ex)
                {
                    if (ex is ArgumentException)
                    {
                        Error.CommandFileNotFoundException(command);
                    }
                    else
                    {
                        Log.Crash(errorMessage: ex, errorCode: ErrorHandler.FileSystem.CreateFileErrorCode, errorType: "Filesystem");
                        CrashHandler.FileSystemError(errorCode: ErrorHandler.FileSystem.CreateFileErrorCode);

                    }



                }

            }

            else if (command.StartsWith("mkdir"))
            {

                try
                {
                    if (command.Contains("--help"))
                    {
                        CommandMkdir.PrintHelp();
                    }
                    else
                    {
                        CommandMkdir.CreateDirectory(Kernel.CurrentDirectory + command.Substring(6));

                    }
                }
                catch (Exception ex)
                {
                    if (ex is ArgumentException)
                    {
                        Error.CommandPathArgumentException(command);
                    }
                    else
                    {
                        Log.Crash(errorMessage: ex, errorCode: ErrorHandler.FileSystem.CreateDirectoryErrorCode, errorType: "Filesystem");
                        CrashHandler.FileSystemError(errorCode: ErrorHandler.FileSystem.CreateDirectoryErrorCode);
                    }
                }
            }

            else if (command.StartsWith("rmdir"))
            {
                try
                {
                    if (command.Contains("--help"))
                    {
                        CommandRmdir.PrintHelp();
                    }
                    else
                    {
                        CommandRmdir.DeleteDirectory(Kernel.CurrentDirectory + command.Substring(6) + @"\");
                    }
                }
                catch (Exception ex)
                {
                    if (ex is ArgumentException)
                    {
                        Error.CommandPathArgumentException(command);
                    }
                    else
                    {
                        Log.Crash(errorMessage: ex, errorCode: ErrorHandler.FileSystem.DeleteDirectoryErrorCode, errorType: "Filesystem");
                        CrashHandler.FileSystemError(errorCode: ErrorHandler.FileSystem.DeleteDirectoryErrorCode);
                    }

                }

            }

            else if (command.StartsWith("cd"))
            {
                try
                {
                    if (command.Contains(@"/"))
                    {
                        CommandCD.NavigateToPrimaryDrive();
                    }
                    else if (command.Contains(".."))
                    {
                        CommandCD.NavigateToParentDir(command.Substring(4));
                    }
                    else if (Directory.Exists(Kernel.CurrentDirectory + command.Substring(3)))
                    {
                        CommandCD.NavigateToDir(command.Substring(3));
                    }
                    else if (command.Contains("--help"))
                    {
                        CommandCD.PrintHelp();
                    }


                }
                catch (Exception ex)
                {
                    if (ex is ArgumentException)
                    {
                        Error.CommandPathArgumentException(command);

                    }
                    else if (ex is DirectoryNotFoundException)
                    {
                        Error.CommandDirectoryNotFoundException(command);
                    }
                    else
                    {
                        Log.Crash(errorMessage: ex, errorCode: ErrorHandler.FileSystem.CDCommandErrorCode, errorType: "Filesystem");
                        CrashHandler.FileSystemError(errorCode: ErrorHandler.FileSystem.CDCommandErrorCode);
                    }
                }
            }

            else if (command.StartsWith("diskinfo"))
            {
                try
                {
                    if (command.Contains("--help"))
                    {
                        DiskInfo.PrintHelp();
                    }
                    else
                    {
                        DiskInfo.GetDiskInfo();

                    }
                }
                catch (Exception ex)
                {
                    Log.Crash(errorMessage: ex, errorCode: ErrorHandler.System.DiskInfoErrorCode, errorType: "System");
                    CrashHandler.SystemError(errorCode: ErrorHandler.System.DiskInfoErrorCode);
                }

            }

            else if (command.StartsWith("cat"))
            {
                try
                {
                    if (command.Contains("--help"))
                    {
                        CommandCat.PrintHelp();
                    }
                    else
                    {
                        CommandCat.ReadFile(Kernel.CurrentDirectory + @"\" + command.Substring(4));
                    }
                }
                catch (Exception ex)
                {
                    if (ex is ArgumentException)
                    {
                        Error.CommandFileArgumentException(command);
                    }
                    else if (ex is FileNotFoundException)
                    {
                        Error.CommandFileNotFoundException(command);
                    }
                    else
                    {
                        Log.Crash(errorMessage: ex, errorCode: ErrorHandler.FileSystem.CatCommandErrorCode, errorType: "Filesystem");
                        CrashHandler.FileSystemError(errorCode: ErrorHandler.FileSystem.CatCommandErrorCode);
                    }

                }

            }

            else if (command.StartsWith("log"))
            {
                try
                {
                    if (command.Contains("--help"))
                    {
                        Log.PrintHelp();
                    }
                    else if(command.Contains("--system"))
                    {
                        Log.PrintSystemCrash();

                    }
                    else if (command.Contains("--normal"))
                    {
                        Log.PrintCrash();
                    }
                    else if (command.Contains("--app"))
                    {
                        Log.PrintAppCrash();
                    }
                }
                catch (Exception ex)
                {
                    Log.Crash(errorMessage: ex, errorCode: ErrorHandler.System.LogErrorCode, errorType: "System");
                    CrashHandler.SystemError(errorCode: ErrorHandler.System.LogErrorCode);

                }
            }

            else if (command.StartsWith("shutdown"))
            {
                try
                {

                    if (command.Contains("--help"))
                    {
                        InitShutdown.PrintHelp();
                    }
                    else
                    {
                        InitShutdown.Shutdown();
                    }
                }
                catch (Exception ex)
                {
                    Log.Crash(errorMessage: ex, errorCode: ErrorHandler.System.ShutdownCommandErrorCode, errorType: "System");
                    CrashHandler.SystemError(errorCode: ErrorHandler.System.ShutdownCommandErrorCode);
                }

            }

            else if (command.StartsWith("reboot"))
            {
                try
                {
                    if (command.Contains("--help"))
                    {
                        InitReboot.PrintHelp();
                    }
                    else
                    {
                        InitReboot.Reboot();
                    }
                }
                catch (Exception ex)
                {
                    Log.Crash(errorMessage: ex, errorCode: ErrorHandler.System.RebootCommandErrorCode, errorType: "System");
                    CrashHandler.SystemError(errorCode: ErrorHandler.System.RebootCommandErrorCode);
                }

            }

            else if (command.StartsWith("miv"))
            {
                try
                {
                    if (command.Contains("--help"))
                    {
                        MIV.PrintHelp();
                    }
                    else
                    {
                        MIV.StartMIV();
                    }
                }
                catch (Exception ex)
                {
                    Log.AppCrash(errorMessage: ex, appName: "MIV");
                    CrashHandler.AppError(appName: "MIV");
                }

            }

            else if (command.StartsWith("snake"))
            {
                try
                {
  
                    if (command.Contains("--help"))
                    {
                        Snake.PrintHelp();
                    }
                    else
                    {
                        Snake.SnakeRun();
                    }
                }
                catch (Exception ex)
                {
                    Log.AppCrash(errorMessage: ex, appName: "Snake");
                    CrashHandler.AppError(appName: "Snake");
                }
            }

            else if (command.StartsWith("cryptotool"))
            {
                try
                {

                    if (command.Contains("--help"))
                    {
                        CryptoTool.PrintHelp();
                    }
                    else if(command.Contains("--sha256"))
                    {
                        CryptoTool.GenerateSHA256(command.Substring(20));
                    }
                    else if (command.Contains("--md5"))
                    {
                        CryptoTool.GenerateMD5(command.Substring(17));
                    }
                }
                catch (Exception ex)
                {
                    Log.AppCrash(errorMessage: ex, appName: "CryptoTool");
                    CrashHandler.AppError(appName: "Cryptotool");
                }
            }
            else
            {
                Text.CommandNotFound(command);
            }
        }
    }
}

