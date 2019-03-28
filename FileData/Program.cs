using System;
using System.Collections.Generic;
using System.Linq;
using ThirdPartyTools;

namespace FileData
{
    public static class Program
    {
        public static void Main(string[] args)
        {



            if (args != null && args.Length != 2)
            {
                Console.WriteLine("sInvalid arguments are passed");
                return;
            }
            if (args[0] != "v" && args[0] != "s")
            {
                Console.WriteLine("Invalid arguments are passed");
                return;
            }
            switch (args[0])
            {
                case "v":
                    Console.WriteLine(getFileVersion(args[1]));
                    break;
                case "s":
                    Console.WriteLine(getFileSize(args[1]));
                    break;
                default:
                    break;
            }
            Console.ReadLine();
        }


        private static string getFileSize(string filePath)
        {
            var fd = new FileDetails();

            return fd.Size(filePath).ToString();
        }
        private static string getFileVersion(string filePath)
        {
            var fd = new FileDetails();

            return fd.Version(filePath);
        }
    }
}
