// Source code owned by: audiotore341
// 2022 License: GNU GENERAL PUBLIC LICENSE v2

using System;
using System.IO;
using System.Text;
using Sys = Cosmos.System;

namespace EchOS
{

    public class Terminalbackground
    {

        public static void Checkcolor()
        {

            string path = @"0:\colorpick.txt";

            bool fileExist = File.Exists(path);


            if (fileExist)
            {

                while (true)
                {

                    Console.WriteLine("====================");
                    Console.WriteLine("Choose your color!");
                    Console.WriteLine("1. Black");
                    Console.WriteLine("2. Blue");
                    Console.WriteLine("3. Yellow");
                    Console.WriteLine("4. Cyan");
                    Console.WriteLine("5. Exit");
                    Console.WriteLine("====================");

                    Console.Write(">>>: ");
                    string checknow = Console.ReadLine();

                    if (checknow == "1")
                    {

                        Console.BackgroundColor = ConsoleColor.Black;
                        Cmdman.Clear_Src();

                    }

                    else if (checknow == "2")
                    {

                        Console.BackgroundColor = ConsoleColor.Blue;
                        Cmdman.Clear_Src();

                    }

                    else if (checknow == "3")
                    {

                        Console.BackgroundColor = ConsoleColor.Yellow;
                        Cmdman.Clear_Src();

                    }

                    else if (checknow == "4")
                    {

                        Console.BackgroundColor = ConsoleColor.Cyan;
                        Cmdman.Clear_Src();

                    }

                    else if (checknow == "5")
                    {

                        Cmdman.Clear_Src();
                        break;

                    }

                    if (checknow == "1" || checknow == "2" || checknow == "3" || checknow == "4")
                    {

                        var helloFile = Sys.FileSystem.VFS.VFSManager.GetFile(@"0:\colorpick.txt");
                        var helloFileStream = helloFile.GetFileStream();

                        if (helloFileStream.CanWrite)
                        {

                            byte[] textToWrite = Encoding.ASCII.GetBytes(checknow);
                            helloFileStream.Write(textToWrite, 0, textToWrite.Length);

                        }

                    }

                    else
                    {

                        // Do nothing and continue.

                    }


                }

            }

            else
            {

                Console.WriteLine("ERROR: File does not EXIST!");
                Console.WriteLine("Something has failed in the system");
                Console.WriteLine("Restart EchOS or create it with File.create");

                // Continue and exit to the kernel.

            }

        }

    }

}
