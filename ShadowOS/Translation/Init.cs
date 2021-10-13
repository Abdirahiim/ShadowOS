using System;
using System.IO;
using Shadow_OS.Core;

namespace Shadow_OS.Translation
{
    class Init
    {
        //The global variable named Lang is used across the system to check what system language is set

        //checks what language file exists
        public static void Translation()
        {
            if (File.Exists(@"0:\System\en_us"))
                {
                    Kernel.Lang = "en_us"; //sets the system language
                }
                else if (File.Exists(@"0:\System\da"))
                {
                    Kernel.Lang = "da";
                }
                else if (File.Exists(@"0:\System\so"))
                {
                    Kernel.Lang = "so";
                }
            else
            {
                TranslationSetup();
            }
        }

        //sets up the os with your preferred language
        public static void TranslationSetup()
        {
            Console.WriteLine("Please choose your preferred language");
            Console.WriteLine("1- English    2- Danish   3- Somali");
            Console.Write("Type: ");
            var input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    Directory.CreateDirectory(Kernel.CurrentDirectory + @"\System");
                    File.Create(@"0:\System\en_us");
                    Kernel.Lang = "en_us";
                    break;

                case "2":
                    Directory.CreateDirectory(Kernel.CurrentDirectory + @"\System");
                    File.Create(@"0:\System\da");
                    Kernel.Lang = "da";
                    break;

                case "3":
                    Directory.CreateDirectory(Kernel.CurrentDirectory + @"\System");
                    File.Create(@"0:\System\so");
                    Kernel.Lang = "so";
                    break;

                default:
                    Console.WriteLine("Invalid input");
                    break;
            }
        }
    }   
}
