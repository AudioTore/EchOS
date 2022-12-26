// Source code owned by: audiotore341
// 2022 License: GNU GENERAL PUBLIC LICENSE v2

/* This class is what makes it possible to make sure the terminal color stays the same even after reboot.
 * So nontemp settings that can only be changed if the user wants to change them.
 */

using System;
using System.IO;
using System.Text;
using Sys = Cosmos.System;

namespace EchOS
{

    public class Colorhandle
    {

        public static string read_final;
        public static string color;

        public static void settings()
        {

            var fs = new Sys.FileSystem.CosmosVFS();

            if (File.Exists(@"0:\colorpick.txt"))
            {
                read_final = File.ReadAllText(@"0:\colorpick.txt");

                if (read_final.Contains("1"))
                {
                    Console.BackgroundColor = ConsoleColor.Black;
                    color = "Black";
                }

                else if (read_final.Contains("2"))
                {

                    Console.BackgroundColor = ConsoleColor.Blue;
                    color = "Blue";

                }

                else if (read_final.Contains("3"))
                {

                    Console.BackgroundColor = ConsoleColor.Yellow;
                    color = "Yellow";

                }

                else if (read_final.Contains("4"))
                {

                    Console.BackgroundColor = ConsoleColor.Cyan;
                    color = "Cyan";

                }

                else
                {
                    Console.BackgroundColor = ConsoleColor.Black;
                    color = "Black";
                }

            }

            else
            {

                try
                {

                    File.Create(@"0:\colorpick.txt");
                    File.WriteAllText(@"0:\colorpick.txt", "1");
                    color = "Black";
                }

                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }

            }
            

        }

    }

}
