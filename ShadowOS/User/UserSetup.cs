using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Shadow_OS.FileSystem;
using Shadow_OS.Security;
using Shadow_OS.Core;
namespace Shadow_OS.User
{
    class UserSetup
    {
        static List<string> usersfile = new List<string>();
        public static string[] users;
        static string[] reset;

        public static void User()
        {
            
            if (File.Exists(Kernel.CurrentDirectory + @"\users.db"))
            {
                
                Console.WriteLine("Please enter your password");
                var input = Console.ReadLine();

                var HashedInput = Sha256.hash(input);

                var password = CommandCat.ReadFile(Kernel.CurrentDirectory + @"\users.db");
                var HashedPassword = Sha256.hash(password);
                Console.Clear();
                Console.WriteLine(Kernel.Logo);

                if (HashedInput == HashedPassword)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write(" root");

                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write("@" + Kernel.ComputerName);

                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write("$ ");

                    Console.ForegroundColor = ConsoleColor.White;

                    string cmd = Console.ReadLine(); //takes the input


                    Shell.Prompt(cmd); //takes the input and processes it in the Terminal class
                }
                else if(HashedInput != HashedPassword)
                {
                    Console.WriteLine("Wrong password");
                }


            }
            else
            {
                CommandTouch.CreateFile(Kernel.CurrentDirectory + @"\users.db");

                
                Console.WriteLine("Please enter your new password:");
                var password = Console.ReadLine();
                var HashedPassword = Sha256.hash(password);

                File.WriteAllText(Kernel.CurrentDirectory + @"\users.db", HashedPassword);

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write(" root");

                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("@" + Kernel.ComputerName);

                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("$ ");

                Console.ForegroundColor = ConsoleColor.White;

                string cmd = Console.ReadLine(); //takes the input


                Shell.Prompt(cmd); //takes the input and processes it in the Shell class

            }
        }

        public static void Create(string username, string password, string type = "standard")
        {
            try
            {
                password = Sha256.hash(password);
                LoadUsers();
                if (GetUser("user").StartsWith(username))
                {
                    //Text.Display("user:existalready", username);
                    return;
                }
                PutUser("user:" + username, password + "|" + type);
                PushUsers();
                //Text.Display("user:hasbeencreated", username);
                Console.WriteLine("Password created!");

                //InitUserDirs(username);
              //  Text.Display("user:personaldirectories", username);
            }
            catch
            {
               
            }

        }

        public static void PutUser(string parameter, string value)
        {
            bool contains = false;

            foreach (string line in users)
            {
                usersfile.Add(line);
                if (line.StartsWith(parameter))
                {
                    contains = true;
                }
            }

            if (!contains)
            {
                usersfile.Add(parameter + ":" + value);
            }

            users = usersfile.ToArray();

            usersfile.Clear();
        }

        public static string GetUser(string parameter)
        {
            string value = "null";

            foreach (string line in users)
            {
                usersfile.Add(line);
            }

            foreach (string element in usersfile)
            {
                if (element.StartsWith(parameter))
                {
                    value = element.Remove(0, parameter.Length + 1);
                }
            }

            usersfile.Clear();

            return value;
        }

        public static void PushUsers()
        {
            File.WriteAllLines(@"0:\users.db", users);
        }

        public void InitUserDirs(string user)
        {
            if (user == "root")
            {
                string[] RootDirectories =
                {
                    @"0:\Users\" + user + @"\root"
                };
                foreach (string dirs in RootDirectories)
                    if (!Directory.Exists(dirs))
                        Directory.CreateDirectory(dirs);
                return;
            }
            else
            {
                string[] DefaultDirectories =
                {
                    @"0:\Users\" + user + @"\Desktop",
                    @"0:\Users\" + user + @"\Documents",
                    @"0:\Users\" + user + @"\Downloads",
                    @"0:\Users\" + user + @"\Music",
                };
                foreach (string dirs in DefaultDirectories)
                    if (!Directory.Exists(dirs))
                        Directory.CreateDirectory(dirs);
            }
        }

        public static void LoadUsers()
        {
            //reset of users string array in memory if there is "something"
            users = reset;
            //load
            users = File.ReadAllLines(@"0:\users.db");
        }
    }
}
