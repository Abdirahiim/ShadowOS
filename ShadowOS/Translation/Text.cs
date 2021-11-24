using System;
using Shadow_OS.Core;
using Shadow_OS.System;

namespace Shadow_OS.Translation
{
    //The translations for miscellaneous texts and the texts in functions
    class Text
    {
        public static void Help()
        {
            switch (Kernel.Lang)
            {
                case "en_us":
                    Console.WriteLine(@"
                Usage: help
                       [commmand] --help
                - reboot (reboots the system)
                - shutdown (shutdowns the system)
                - clear (clears the screen)
                - log (shows information about the latest logs)
                - systeminfo (fetches the system information)
                - diskinfo (fetches the disk information)
                - dir (lists everything in the current directory)
                - cd (navigate to a different directory)
                - del (delete the specified file)
                - touch (create a new file)
                - cat (read a file)
                - rmdir (remove a directory)
                - mkdir (create a new directory)
                - miv (opens the MIV editor)
                - snake (opens the snake game)
                - cryptotool (shows the chosen hash of a given input)
                                        ");
                    break;
                case "da":
                    Console.WriteLine(@"
               Brug: help
                     [kommando] --help
                - reboot (genstarter systemet)
                - shutdown (lukker systemet ned)
                - clear (rydder skærmen)
                - log (viser information om de seneste crash logs)
                - systeminfo (henter systemoplysningernene)
                - diskinfo (henter diskoplysningerne)
                - dir (lister alt i det nuværende mappe)
                - cd (naviger til den oenskede sti)
                - del (slet den angivne fil)
                - touch (skab en ny fil)
                - cat (læs en fil)
                - rmdir (slet en mapppe)
                - mkdir (lav en ny mappe)
                - miv (aabner MIV)
                - snake (aabner spillet Snake)
                - cryptotool (viser den valgte hash for et angivet input)
                                        ");
                    break;
                case "so":
                    Console.WriteLine(@"
             Isticmaalid: help
                          [amar] --help
             - reboot (wuxu dib u daaraya system ka)
             - shutdown (wuxu xidhaya system ka)
             - clear (wuxu masaxaya shaashada)
             - log (wuxu ku tusaya crash logs ga ugu dambyeeys)
             - systeminfo (wuxu soo qabanaya macluumaadka system ka)
             - diskinfo (wuxu soo qabanaya macluumaadka dhisgika)
             - dir (wuxu taxahaya wax walba ee ku jira direktoriga aad joogtid)
             - cd (qabo direktoriga aad doonaysid)
             - del (masax faylka aad u sheegtid)
             - touch (samee fayl cusub)
             - cat (akhri fayl)
             - rmdir (masax direktori)
             - mkdir (samee direktori cusub)
             - miv (wuxu furaya MIV)
             - snake (wuxu furaya ciyaarta Snake)
             - cryptotool (wuxu ku tusaya hash ga waxaad gelisid)
                                        ");
                    break;

            }
        }

        public static void SystemInfoTL()
        {
            switch (Kernel.Lang)
            {
                case "en_us":
                    Console.WriteLine($"Host             :  {Kernel.ComputerName}");
                    Console.WriteLine("OS               :  ShadowOS");
                    Console.WriteLine($"OS Version       :  {Kernel.CurrentVersion}");
                    Console.WriteLine($"Total Memory     :  {SystemInfo.GetAmountRAM()}");
                    Console.WriteLine($"Processor        :  {SystemInfo.GetCPUDetails()}");
                    Console.WriteLine($"System Boot Time :  {Kernel.BootHour}:{Kernel.BootMinute}:{Kernel.BootSecond}");
                    Console.WriteLine($"System locale    :  {Kernel.Lang}");
                    Console.WriteLine("Developed by     :  Abdirahiim Yassin");
                    break;

                case "da":
                    Console.WriteLine($"Host             :  {Kernel.ComputerName}");
                    Console.WriteLine("OS               :  ShadowOS");
                    Console.WriteLine($"OS Version       :  {Kernel.CurrentVersion}");
                    Console.WriteLine($"Total hukommelse :  {SystemInfo.GetAmountRAM()}");
                    Console.WriteLine($"Processor        :  {SystemInfo.GetCPUDetails()}");
                    Console.WriteLine($"System Boot Tid  :  {Kernel.BootHour}:{Kernel.BootMinute}:{Kernel.BootSecond}");
                    Console.WriteLine($"System sprog     :  {Kernel.Lang}");
                    Console.WriteLine("Udviklet af      :  Abdirahiim Yassin");
                    break;
                case "so":
                    Console.WriteLine($"Magaca computer ka             :  {Kernel.ComputerName}");
                    Console.WriteLine("OS                             :  ShadowOS");
                    Console.WriteLine($"OS Version                     :  {Kernel.CurrentVersion}");
                    Console.WriteLine($"RAM ka oo dhameystiran         :  {SystemInfo.GetAmountRAM()}");
                    Console.WriteLine($"Maskaxda                       :  {SystemInfo.GetCPUDetails()}");
                    Console.WriteLine($"Goorta la daaray               :  {Kernel.BootHour}:{Kernel.BootMinute}:{Kernel.BootSecond}");
                    Console.WriteLine($"Luuqada system ka              :  {Kernel.Lang}");
                    Console.WriteLine("Waxa sameeyey                  :  Abdirahiim Yassin");
                    break;
            }
        }

        public static void DiskInfoTL()
        {
            switch (Kernel.Lang)
            {
                case "en_us":
                    Console.WriteLine($"Volume Label      :  {Kernel.PrimaryVolumeLabel}");
                    Console.WriteLine($"root              :  {Kernel.PrimaryDrive}");
                    Console.WriteLine("Total Storage     :  " + Kernel.PrimaryDrive.TotalSize / 1024 / 1024 + " Megabytes");
                    Console.WriteLine("Available Storage :  " + Kernel.PrimaryDrive.AvailableFreeSpace / 1024 / 1024 + " Megabytes");
                    break;

                case "da":
                    Console.WriteLine($"Volume Navn               :  {Kernel.PrimaryVolumeLabel}");
                    Console.WriteLine($"root                      :  {Kernel.PrimaryDrive}");
                    Console.WriteLine("Samlet lagerplads         :  " + Kernel.PrimaryDrive.TotalSize / 1024 / 1024 + " Megabytes");
                    Console.WriteLine("Tilgaengelig lagerplads   :  " + Kernel.PrimaryDrive.AvailableFreeSpace / 1024 / 1024 + " Megabytes");
                    break;
                case "so":
                    Console.WriteLine($"Magaca Volume ka        :  {Kernel.PrimaryVolumeLabel}");
                    Console.WriteLine($"root                    :  {Kernel.PrimaryDrive}");
                    Console.WriteLine("Qaadka oo dhameystiran  :  " + Kernel.PrimaryDrive.TotalSize / 1024 / 1024 + " Megabytes");
                    Console.WriteLine("Inta qaadka ka banaan   :  " + Kernel.PrimaryDrive.AvailableFreeSpace / 1024 / 1024 + " Megabytes");
                    break;
            }
        }

        public static void CommandNotFound(string command)
        {
            switch (Kernel.Lang)
            {
                case "en_us":
                    Console.WriteLine(command + ": command not found");
                    break;

                case "da":
                    Console.WriteLine(command + ": kommando ikke fundet");
                    break;

                case "so":
                    Console.WriteLine(command + ": amarka ma helin");
                    break;
            }
        }

        public static void LogNotFound()
        {
            switch (Kernel.Lang)
            {
                case "en_us":
                    Console.WriteLine("No log found");
                    break;

                case "da":
                    Console.WriteLine("Ingen log fundet");
                    break;

                case "so":
                    Console.WriteLine("Fayl log ma helin");
                    break;
            }
        }
    }
}