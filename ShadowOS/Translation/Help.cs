using System;
using Shadow_OS.Core;

namespace Shadow_OS.Translation
{
    // The translations for the --help argument of commmands
    class Help
    {
        public static void Shutdown()
        {
            switch (Kernel.Lang)
            {
                case "en_us":
                    Console.WriteLine("Description: Shutdowns the system");
                    break;

                case "da":
                    Console.WriteLine("Beskrivelse: Lukker systemet ned");
                    break;

                case "so":
                    Console.WriteLine("Faafaahin: Wuxu xidhaya system ka");
                    break;

            }
        }

        public static void Reboot()
        {
            switch (Kernel.Lang)
            {
                case "en_us":
                    Console.WriteLine("Description: Reboots the system");
                    break;

                case "da":
                    Console.WriteLine("Beskrivelse: Genstarter systemet");
                    break;

                case "so":
                    Console.WriteLine("Faafaahin: Wuxu dib u daaraya system ka");
                    break;

            }
        }

        public static void SystemInfo()
        {

            switch (Kernel.Lang)
            {
                case "en_us":
                    Console.WriteLine("Description: Fetches the system information");
                    break;

                case "da":
                    Console.WriteLine("Beskrivelse: Henter systemoplysningerne");
                    break;

                case "so":
                    Console.WriteLine("Faafaahin: Wuxu soo qabanaya macluumaadka system ka");
                    break;

            }
        }

        public static void DiskInfo()
        {

            switch (Kernel.Lang)
            {
                case "en_us":
                    Console.WriteLine("Description: Fetches the disk information");
                    break;

                case "da":
                    Console.WriteLine("Beskrivelse: Henter diskoplysningerne");
                    break;

                case "so":
                    Console.WriteLine("Faafaahin: Wuxu soo qabanaya macluumaadka dhisgika");
                    break;

            }
        }

        public static void CommandClear()
        {
            switch (Kernel.Lang)
            {
                case "en_us":
                    Console.WriteLine("Description: Clears the screen");
                    break;

                case "da":
                    Console.WriteLine("Beskrivelse: Rydder skærmen");
                    break;

                case "so":
                    Console.WriteLine("Faafaahin: Wuxu masaxaya shaashada");
                    break;

            }
        }

        public static void CommandDir()
        {
            switch (Kernel.Lang)
            {
                case "en_us":
                    Console.WriteLine("Description: Lists everything in the current directory");
                    break;

                case "da":
                    Console.WriteLine("Beskrivelse: Lister alt i det nuværende mappe");
                    break;

                case "so":
                    Console.WriteLine("Faafaahin: Wuxu taxahaya wax walba ee ku jira direktoriga aad joogtid");
                    break;

            }
        }

        public static void CommandDel()
        {
            switch (Kernel.Lang)
            {
                case "en_us":
                    Console.WriteLine("Description:   Delete the specified file");
                    Console.WriteLine("Usage:   del [file]");
                    break;

                case "da":
                    Console.WriteLine("Beskrivelse:   Slet den angivne fil");
                    Console.WriteLine("Brug:   del [fil]");
                    break;

                case "so":
                    Console.WriteLine("Faafaahin:   Masax faylka aad u sheegtid");
                    Console.WriteLine("Isticmaalid:   del [fayl]");
                    break;

            }
        }

        public static void CommandTouch()
        {
            switch (Kernel.Lang)
            {
                case "en_us":
                    Console.WriteLine("Description:   Create a new file");
                    Console.WriteLine("Usage:   touch [file]");
                    break;

                case "da":
                    Console.WriteLine("Beskrivelse:   Lav en ny fil");
                    Console.WriteLine("Brug:   touch [fil]");
                    break;

                case "so":
                     Console.WriteLine("Faafaahin:   Samee fayl cusub");
                    Console.WriteLine("Isticmaalid:   touch [fayl]");
                    break;

            }
        }

        public static void CommandCat()
        {
            switch (Kernel.Lang)
            {
                case "en_us":
                    Console.WriteLine("Description:   Read a file");
                    Console.WriteLine("Usage:   cat [file]");
                    break;

                case "da":
                    Console.WriteLine("Beskrivelse:   Læs en fil");
                    Console.WriteLine("Brug:   touch [fil]");
                    break;

                case "so":
                    Console.WriteLine("Faafaahin:   Akhri fayl");
                    Console.WriteLine("Isticmaalid:   touch [fayl]");
                    break;

            }
        }

        public static void CommandRmdir()
        {
            switch (Kernel.Lang)
            {
                case "en_us":
                    Console.WriteLine("Description:   remove a directory");
                    Console.WriteLine("Usage:   rmdir [path]");
                    break;
                   
                case "da":
                    Console.WriteLine("Description:   Slet en mapppe");
                    Console.WriteLine("Brug:   rmdir [sti]");
                    break;

                case "so":
                    Console.WriteLine("Faafaahin:   Masax direktori");
                    Console.WriteLine("Isticmaalid:   rmdir [direktori]");
                    break;

            }
        }

        public static void CommandMkdir()
        {
            switch (Kernel.Lang)
            {
                case "en_us":
                    Console.WriteLine("Description:   Create a new directory");
                    Console.WriteLine("Usage:   mkdir [dir]");
                    break;

                case "da":
                    Console.WriteLine("Beskrivelse:   Laver en ny mappe");
                    Console.WriteLine("Usage:   mkdir [sti]");
                    break;

                case "so":
                    Console.WriteLine("Faafaahin:  Samee direktori cusub");
                    Console.WriteLine("Isticmaalid:   mkdir [dir]");
                    break;

            }
        }

        public static void CommandCD()
        {
            switch (Kernel.Lang)
            {
                case "en_us":
                    Console.WriteLine("Description: Navigate to a different directory");
                    Console.WriteLine("Usage: cd [option]");
                    Console.WriteLine("          [directory]");
                    Console.WriteLine("Navigate to your desired directory\n");
                    Console.WriteLine("dir             follow the specified directory");
                    Console.WriteLine("/               get back to the primary drive");
                    Console.WriteLine("..              get back to the parent directory");
                    break;

                case "da":
                    Console.WriteLine("Beskrivelse: Naviger til den oenskede sti");
                    Console.WriteLine("brug: cd [valg]");
                    Console.WriteLine("         [sti]");
                    Console.WriteLine("dir             foelg den angivet mappe");
                    Console.WriteLine("/               kommer tilbage til den primaere drev");
                    Console.WriteLine("..              kommer tilbage til den forige mappe");
                    break;

                case "so":
                    Console.WriteLine("Faahfaahin: Qabo direktoriga aad doonaysid");
                    Console.WriteLine("Isticmaalid: cd [doorasho]");
                    Console.WriteLine("                [direktori]");
                    Console.WriteLine("Qabo wadada aad doonaysid\n");
                    Console.WriteLine("dir             geynaya direktoriga aad sheegtay");
                    Console.WriteLine("/               dib ugu noqonaya drayfga");
                    Console.WriteLine("..              get back to the parent directory");
                    break;

            }
        }

        public static void Log()
        {
            switch (Kernel.Lang)
            {
                case "en_us":
                    Console.WriteLine("Description:   shows information about the latest crash logs");
                    Console.WriteLine("Usage:   log [option]");
                    Console.WriteLine("--system             shows the latest system crash");
                    Console.WriteLine("--normal             shows the latest non-kernel crash logs");
                    Console.WriteLine("--app                shows the latest app crash log");
                    break;

                case "da":
                    Console.WriteLine("Beskrivelse:   viser information om de seneste crash logs");
                    Console.WriteLine("Brug:   log [valg]");
                    Console.WriteLine("--system             viser den seneste system crash");
                    Console.WriteLine("--normal             Viser den seneste ikke kernel crash log");
                    Console.WriteLine("--app                viser den seneste app crash log");
                    break;

                case "so":
                    Console.WriteLine("Faahfaahin:   wuxu ku tusaya crash logs ga ugu dambyeey");
                    Console.WriteLine("Isticmaalid:   log [doorasho]");
                    Console.WriteLine("--system             Wuxu soo saaraya system crash ga ugu dambeeyey");
                    Console.WriteLine("--normal             Wuxu soo saaraya system crash ga ugu dambeeyey ee aan ahayn mid kernel");
                    Console.WriteLine("--app                Wuxu soo saaraya app crash ga ugu dambeeyey");
                    break;

            }
        }

        public static void MIV()
        {
            switch (Kernel.Lang)
            {
                case "en_us":
                    Console.WriteLine("Description: Opens MIV");
                    break;

                case "da":
                    Console.WriteLine("Beskrivelse: aabner MIV");
                    break;

                case "so":
                    Console.WriteLine("Faafaahin: Wuxu furaya MIV");
                    break;

            }
        }

        public static void Snake()
        {
            switch (Kernel.Lang)
            {
                case "en_us":
                    Console.WriteLine("Description: Opens the game Snake");
                    break;

                case "da":
                    Console.WriteLine("Beskrivelse: aabner spillet Snake");
                    break;

                case "so":
                    Console.WriteLine("Faafaahin: Wuxu furaya ciyaarta Snake");
                    break;

            }
        }

        public static void CryptoTool()
        {
            switch (Kernel.Lang)
            {
                case "en_us":
                    Console.WriteLine("Description: Shows the chosen hash of a given input");
                    Console.WriteLine("Usage:   cryptotool [option]");
                    Console.WriteLine("--md5             shows the md5 hash of a given input");
                    Console.WriteLine("--sha256          shows the sha256 of a given input");
                    break;

                case "da":
                    Console.WriteLine("Beskrivelse: Viser den valgte hash for et angivet input");
                    Console.WriteLine("Brug:   cryptotool [valg]");
                    Console.WriteLine("--md5             viser md5 hash for et angivet input");
                    Console.WriteLine("--sha256          viser sha256 hash for et angivet input");
                    break;

                case "so":
                    Console.WriteLine("Faafaahin: Wuxu ku tusaya hash ga waxaad gelisid");
                    Console.WriteLine("Brug:   cryptotool [doorasho]");
                    Console.WriteLine("--md5             wuxu ku tusaya md5 hash ga waxaad gelisid");
                    Console.WriteLine("--sha256          wuxu ku tusaya sha256 hash ga waxaad gelisid");
                    break;

            }
        }
    }
}
