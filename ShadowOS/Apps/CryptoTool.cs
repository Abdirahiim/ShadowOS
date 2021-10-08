using System;
using Shadow_OS.Security;
using Shadow_OS.Translation;

namespace Shadow_OS.Apps
{
    class CryptoTool
    {

        // generates the SHA256 hash of a given input
        public static void GenerateSHA256(string file)
        {

            string hash = Sha256.hash(file);

            Console.WriteLine("SHA256 - " + hash);
        }

        // generates the MD5 hash of a given input
        public static void GenerateMD5(string file)
        {
            string hash = MD5.hash(file);

            Console.WriteLine("MD5 - " + hash);
        }

        public static void PrintHelp()
        {
            Help.CryptoTool();
        }
    }
}


