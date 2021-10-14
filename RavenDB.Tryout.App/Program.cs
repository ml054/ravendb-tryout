using System;

namespace RavenDB.Tryout.App
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                Console.WriteLine("No argument provided.");
                return;
            }
            
            var arg = args[0];

            switch (arg)
            {
                case "create":
                    CreateDocument();
                    break;
                
                case "read":
                case "update":
                    ReadAndUpdateDocument();
                    break;
                
                case "delete":
                    DeleteDocument();
                    break;
                
                default:
                    Console.WriteLine("No matching argument provided.");
                    break;
            }
        }

        private static void CreateDocument()
        {
            throw new NotImplementedException("TODO");
        }

        private static void ReadAndUpdateDocument()
        {
            throw new NotImplementedException("TODO");
        }

        private static void DeleteDocument()
        {
            throw new NotImplementedException("TODO");
        }
    }
}
