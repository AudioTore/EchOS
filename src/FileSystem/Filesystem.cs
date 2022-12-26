// Source code owned by: audiotore341
// 2022 License: GNU GENERAL PUBLIC LICENSE v2

using System;
using System.IO;
using Sys = Cosmos.System;


namespace EchOS
{

    public class Filesystem
    {

        public static Kernel kernel = new Kernel();

        public static void Filemake()
        {

            var fs = new Sys.FileSystem.CosmosVFS();

            try
            {

                Sys.FileSystem.VFS.VFSManager.CreateFile(@"0:\" + Kernel.filemake);
                Console.WriteLine("Successfully written file!");
                Console.WriteLine("Clearing buffer.. Press any key to continue!");
                Console.ReadKey();

            }

            catch (Exception e)
            {

                Console.WriteLine("Problem while making file!");
                Console.ReadLine();

            }

        }

        public static void listdir()
        {

            var directoryList = Sys.FileSystem.VFS.VFSManager.GetDirectoryListing(@"0:\");

            foreach (var directoryEntry in directoryList)
            {

                Console.WriteLine(directoryEntry.mName);

            }

        }


        public static void Filedelete()
        {

            var fs = new Sys.FileSystem.CosmosVFS();

            try
            {

                Sys.FileSystem.VFS.VFSManager.DeleteFile(@"0:\" + Kernel.filedelete);
                Console.WriteLine("Successfully deleted file!");
                Console.WriteLine("Clearing buffer.. Press any key to continue!");
                Console.ReadKey();

            }

            catch (Exception)
            {

                Console.WriteLine("Problem while deleting file!");
                Console.ReadLine();

            }

        }

        public static void Dirmake()
        {

            var fs = new Sys.FileSystem.CosmosVFS();

            try
            {

                Sys.FileSystem.VFS.VFSManager.CreateDirectory(@"0:\" + Kernel.dirmake);
                Console.WriteLine("Successfully written directory!");
                Console.WriteLine("Clearing buffer.. Press any key to continue!");
                Console.ReadKey();

            }

            catch (Exception e)
            {

                Console.WriteLine("Problem while making Directory!");
                Console.ReadLine();

            }

        }

        public static void Dirdelete()
        {

            var fs = new Sys.FileSystem.CosmosVFS();

            try
            {

                Sys.FileSystem.VFS.VFSManager.DeleteDirectory(@"0:\" + Kernel.dirdelete, true);
                Console.WriteLine("Successfully deleted directory!");
                Console.WriteLine("Clearing buffer.. Press any key to continue!");
                Console.ReadKey();

            }

            catch (Exception e)
            {

                Console.WriteLine("Problem while deleting directory!");
                Console.ReadKey();

            }

        }

        public static void Fileread()
        {

            try
            {

                Console.WriteLine(File.ReadAllText(@"0:\" + Kernel.fileread));

            }

            catch (Exception e)
            {

                Console.WriteLine("Problem while reading file!");

            }

        }

    }

}
