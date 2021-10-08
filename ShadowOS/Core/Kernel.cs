using System;
using Sys = Cosmos.System;
using System.IO;
using Cosmos.System.FileSystem.VFS;
using Cosmos.System.FileSystem;
using Shadow_OS.ErrorHandler;
using Shadow_OS.Translation;

namespace Shadow_OS.Core
{
    public class Kernel : Sys.Kernel
    {
      

        CosmosVFS fs = new CosmosVFS(); //declares the filesystem instance

        #region Global variables

        public static string ComputerName = "shadow-pc";
        public static string CurrentDirectory = @"0:\";
        //public static List<string> Directories = new List<string>();
        public static string CurrentVolume = @"0:\";
        public static string CurrentVersion = @"Shadow OS [v0.0.1]";
        public static DriveInfo PrimaryDrive = new DriveInfo("0");
        public static string PrimaryVolumeLabel = PrimaryDrive.VolumeLabel = "Shadow OS";
        public static string file;
        //The time the OS was booted
        public static string BootHour;
        public static string BootMinute;
        public static string BootSecond;

        // Current Date & Time
        public static byte CurrentDay = Cosmos.HAL.RTC.DayOfTheMonth;
        public static byte CurrentMonth = Cosmos.HAL.RTC.Month;
        public static byte CurrentYear = Cosmos.HAL.RTC.Year;
        public static byte CurrentHour = Cosmos.HAL.RTC.Hour;
        public static byte CurrentMinute = Cosmos.HAL.RTC.Minute;
        public static byte CurrentSecond = Cosmos.HAL.RTC.Second;

        public static string Lang;
        //public static CosmosVFS vFS = new CosmosVFS();
        public static string Logo = (@"  ____  _               _                  ___  ____  
 / ___|| |__   __ _  __| | _____      __  / _ \/ ___| 
 \___ \| '_ \ / _` |/ _` |/ _ \ \ /\ / / | | | \___ \ 
  ___) | | | | (_| | (_| | (_) \ V  V /  | |_| |___) |
 |____/|_| |_|\__,_|\__,_|\___/ \_/\_/    \___/|____/ 
                                                      

                                                            ");

        public static string CrashLogo = @"_/ (  (    )   )  \___
                         /( (  (  )   _    ))  )   )\
                       ((     (   )(    )  )   (   )  )
                     ((/  ( _(   )   (   _) ) (  () )  )
                    ( (  ( (_)   ((    (   )  .((_ ) .  )_
                   ( (  )    (      (  )    )   ) . ) (   )
                  (  (   (  (   ) (  _  ( _) ).  ) . ) ) ( )
                  ( (  (   ) (  )   (  ))     ) _)(   )  )  )
                 ( (  ( \ ) (    (_  ( ) ( )  )   ) )  )) ( )
                  (  (   (  (   (_ ( ) ( _    )  ) (  )  )   )
                 ( (  ( (  (  )     (_  )  ) )  _)   ) _( ( )
                  ((  (   )(    (     _    )   _) _(_ (  (_ )
                   (_((__(_(__(( ( ( |  ) ) ) )_))__))_)___)
                   ((__)        \\||lll|l||///          \_))
                            (   /(/ (  )  ) )\   )
                          (    ( ( ( | | ) ) )\   )
                           (   /(| / ( )) ) ) )) )
                         (     ( ((((_(|)_)))))     )
                          (      ||\(|(|)|/||     )
                        (        |(||(||)||||        )
                          (     //|/l|||)|\\ \     )
                        (/ / //  /|//||||\\  \ \  \ _)";
        #endregion

        protected override void BeforeRun()
        {

            VFSManager.RegisterVFS(fs); //registers the filesystem
           
            Console.WriteLine("Booting Shadow OS...");

            Console.Clear();
            Console.WriteLine(Logo);

        }

        protected override void Run()
        {
            try
            {
               //Gets the System boot time
               BootHour = Cosmos.HAL.RTC.Hour.ToString();
               BootMinute = Cosmos.HAL.RTC.Minute.ToString();
               BootSecond = Cosmos.HAL.RTC.Second.ToString();
        
                //checks if the System folder exists
                if (Directory.Exists(@"0:\System"))
                {
                    //checks what system language is set
                    Init.Translation();

                  if (CurrentDirectory == @"0:\")
                    {
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.Write(" root");

                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write("@" + ComputerName);
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write(":-$ ");

                        Console.ForegroundColor = ConsoleColor.White;

                        string cmd = Console.ReadLine(); //takes the input


                        Shell.Prompt(cmd); //takes the input and processes it in the Shell class
                  }
                  else
                  {
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.Write(" root");

                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write("@" + ComputerName + ":-");

                        string ModifiedCurrentDirectory = CurrentDirectory.Trim('0', '\\', ':');
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.Write(ModifiedCurrentDirectory);

                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write("$ ");

                        Console.ForegroundColor = ConsoleColor.White;

                        string cmd = Console.ReadLine(); //takes the input

                    
                        Shell.Prompt(cmd); //takes the input and processes it in the Shell class
                    }
                }
                else
                {
                    //sets up the system language
                    Init.TranslationSetup();

                }             
            }
            catch (Exception ex)
            {
                Log.SystemCrash(ex);
                CrashHandler.SystemCrash();
            }  
        }
    }
}