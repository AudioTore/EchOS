// Source code owned by: audiotore341
// 2022 License: GNU GENERAL PUBLIC LICENSE v2

using Cosmos.System.FileSystem.VFS;
using EchOS;
using System;
using System.Threading;
using Sys = Cosmos.System;

/* Where all the commands and their functionality go. You can make a command by making a function in this Class.
 * Then call the function from this class using the kernel class. I think you can figure it out if your a 
 * developer. If not I highly recommend you watch a couple of tutorials C# to get the basics of it. 
 * If the functionality of a command is going to take a LOT of code store that code in another class. and call 
 * it from the kernel..
 */

public class Cmdman
{

    public static void Help()
    {

        Console.WriteLine("Note: Every command ends with a '();' ");
        Console.WriteLine("================================================================================");
        Console.WriteLine("Command List: ");
        Console.WriteLine("Disk.GetInformation(); - Tells you information of the current drive");
        Console.WriteLine("Disk.ListDir(); - List all the files in the 0:\\ directory");
        Console.WriteLine("File.create [file] - Creates a File. Takes two or more arguments.");
        Console.WriteLine("File.delete [file] - Deletes a File. Takes two or more arguments.");
        Console.WriteLine("File.read [file] - Reads and prints the contents of a text file. Takes two or more arguments.");
        Console.WriteLine("Directory.create [directory] - Creates a directory. Takes two or more arguments.");
        Console.WriteLine("Directory.delete [directory] - Deletes a directory. Takes two or more arguments.");
        Console.WriteLine("Open.TextPad(); - Allows you to type text and save it.");
        Console.WriteLine("Open.Tour - Take a tour and teaches you about how to use EchOS!");
        Console.WriteLine("System.Shutdown(); - Shuts the OS Down. (Please use this)");
        Console.WriteLine("System.Reboot(); - Reboots the OS.");
        Console.WriteLine("Open.Calculator(); - Opens the systems calculator.");
        Console.WriteLine("BackgroundColor.Change(); - Changes the terminals background color.");
        Console.WriteLine("System.About(); - Tells more information about the OS");
        Console.WriteLine("CMD.Clear(); - Clears the console.");
        Console.WriteLine("Execute.Ticktacktoe();");
        Console.WriteLine("Orlov [file] - Use the orlov language to build apps. mov ah, \"Hello!\"");
        Console.WriteLine("================================================================================");

    }


    /// <summary>
    /// "Cosmos.System.power.Shutdown();" doesn't support all Hardware.
    /// It doesn't support all virtualization software. Virtualbox just crashes using this line of code.
    /// Vmware works just fine with it so its recommended to use vmware at all times when using EchOS as vbox
    /// doesn't like EchOS it seems.
    /// </summary>

    public static void Shutdown()
    {

        while (true)
        {

            Console.WriteLine("You are about to shutdown this System?");
            Console.Write("[YES/NO]: ");
            string shutdown = Console.ReadLine();


            if (shutdown == "YES")
            {

                // [
                try
                {
                    Cosmos.System.Power.Shutdown();
                }

                catch (Exception e)
                {
                    Console.WriteLine("ERROR: " + e.Message);
                    Console.WriteLine("Please ask about this in the issues tab of the EchOS Repository.");
                    Console.WriteLine("Link: github.com/AudioTore/EchOS");
                    Thread.Sleep(3000);
                    break;
                }
                // ]

            }

            else if (shutdown == "NO")
            {

                Console.WriteLine("Going back..");
                break;

            }

            else
            {

                Console.WriteLine("Not a vaild command.");

            }

        }

    }

    public static void starttic()
    {

        Ticktacktoe.start();

    }


    public static void Reboot()
    {

        while (true)
        {

            Console.WriteLine("You are about to reboot this System?");
            Console.Write("[YES/NO]: ");
            string input = Console.ReadLine();

            if (input == "YES")
            {

                // [
                try
                {
                    Cosmos.System.Power.Reboot();
                }

                catch (Exception e)
                {
                    Console.WriteLine("ERROR: " + e.Message);
                    Console.WriteLine("Please ask about this in the issues tab of the EchOS Repository.");
                    Console.WriteLine("Link: github.com/AudioTore/EchOS");
                    Thread.Sleep(3000);
                    break;
                }
                // ]

            }

            else if (input == "NO")
            {

                Console.WriteLine("Going back..");
                break;

            }

            else
            {

                Console.WriteLine("Not a vaild command.");

            }

        }

    }


    public static void Calculate()
    {

        double num1 = 0;
        double num2 = 0;
        double result = 0;

        while (true)
        {

            Console.WriteLine("*** WARNING: Strings will not work. ***");



            Console.Write("Enter a number: ");

            // [
            try
            {

                num1 = Convert.ToDouble(Console.ReadLine());
            }

            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            // ]


            Console.Write("Enter another number: ");

            // [
            try
            {
                num2 = Convert.ToDouble(Console.ReadLine());
            }

            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            // ]

            /* If an unexpected error occurs. 
             * Normally meaning that the user inputted a string instead
             * Of an int. */

            Console.WriteLine(">> 1. Addition.");
            Console.WriteLine(">> 2. Subtraction.");
            Console.WriteLine(">> 3. Multiplication. ");
            Console.WriteLine(">> 4. Division.");

            Console.Write(">>>: ");

            string operands = Console.ReadLine();

            if (operands == "1")
            {

                result = num1 + num2;
                Console.WriteLine("answer: " + result);
                break;

            }

            else if (operands == "2")
            {

                result = num1 - num2;
                Console.WriteLine("answer: " + result);
                break;

            }

            else if (operands == "3")
            {

                result = num1 * num2;
                Console.WriteLine("answer: " + result);
                break;

            }

            else if (operands == "4")
            {

                result = num1 / num2;
                Console.WriteLine("answer: " + result);
                break;

            }

            else
            {

                Console.Beep();
                Console.WriteLine("Not a vaild command..");

            }

        }

    }





    public static void About()
    {

        Console.WriteLine(@"

					:~7Y5PPPP5YJ?!^.                          
				:75GBBBBBBBGGGPP55J7^.				    
			:JG#BBB###BBBBBBBBBG5YY?~.				   
			!G#BB##BBBBBBBBGGGGBBBG5JJ7:        System OS: EchOS
			7B#B##BBBBBBBBBBBBBGGGGG#P???:
			~BBB##BBBB#BPY?77?YPBBGGGG#P??7.    Version: 1.5   
			YBBB#BBBB#GY!.    :!JBBPPGG#J??^   
			5BGB#BBGB#P?.      :7P#GPGG#Y??~    Release date: [UNKNOWN]
			JGGG#BBBB#GJ!.    .~JBBPGGG#J??^      
			^PGPB#BBGGBB5J7!!7J5BBPPGG#P??7.    Language written in: C#        
			!PPPB#BGGGGBBBBBBBBGPPGG#P???:   
			~YP5PBBBGGGGGGGPPPGGBBGY??7:        Developer: audioTore (Github)
			.7YYY5PGBBBGGGBBBGG5J??7^:G     
				.~7?JJJYYY55YYJJ??7!:                        
					.:~!!777777!~^:.    


			");

    }



    public static void Clear_Src()
    {

        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("===============================================================================");
        Console.WriteLine("||###########################################################################||");
        Console.WriteLine("||                                 EchOS 1.5                                 ||");
        Console.WriteLine("||###########################################################################||");
        Console.WriteLine("===============================================================================");
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("Type \"Help();\" to get a list of commands.");

    }


    public static void BackgroundColor_Change()
    {

        Terminalbackground.Checkcolor();

    }

    public static void color_change()
    {

        while (true)
        {

            Console.WriteLine("Pick a background color.");
            Console.WriteLine("1. Black;");
            Console.WriteLine("2. Blue.");
            Console.WriteLine("3. Orange.");
            Console.WriteLine("4. Cyan");
            Console.WriteLine("5. Exit");
            Console.Write(">>: ");
            string color_select = Console.ReadLine();

            if (color_select == "1")
            {

                Console.BackgroundColor = ConsoleColor.Black;

            }

            else if (color_select == "2")
            {

                Console.BackgroundColor = ConsoleColor.Blue;

            }

            else if (color_select == "3")
            {

                Console.BackgroundColor = ConsoleColor.Yellow; // The "Yellow" here actually looks like orange.

            }

            else if (color_select == "4")
            {

                Console.BackgroundColor = ConsoleColor.Cyan;

            }

            else if (color_select == "5")
            {

                Cmdman.Clear_Src();
                break;

            }

            else
            {

                Console.Beep();
                Console.WriteLine("Invaild command...");

            }

        }

    }


    public static void DiskGetInformation()
    {
        try // Gets all drive information.
        {

            var fs = new Sys.FileSystem.CosmosVFS();

            var available_space = VFSManager.GetAvailableFreeSpace(@"0:\");
            var getfstype = VFSManager.GetFileSystemType(@"0:\");


            Console.WriteLine(@"Disk Drive: 0:\");
            Console.WriteLine("Disk space: " + available_space);
            Console.WriteLine("Disk Type: " + getfstype);

            // Space.
            Console.WriteLine("");

        }
        catch (Exception e)
        {

            Console.WriteLine(e.Message);
            Console.ReadKey();

        }

    }

    public static void RedScreenOfDeath()
    {

        Console.Clear();

        if (Cosmos.System.VMTools.IsVirtualBox)
        {

            Console.BackgroundColor = ConsoleColor.Red;
            Console.Clear();

            while (true)
            {

                Console.Beep();

                Console.WriteLine("ERROR RSOD: DEVICE NOT COMPATIBLE.");
                Console.WriteLine("VIRTUALBOX IS NOT COMPATIBLE WITH");
                Console.WriteLine("ECHOS TRY AGAIN WITH VMWARE");

                Console.WriteLine("");

                Thread.Sleep(4000);
                Console.Clear();

            }

        }

        else if (Cosmos.System.VMTools.IsQEMU)
        {

            Console.BackgroundColor = ConsoleColor.Red;
            Console.Clear();

            while (true)
            {



                Console.Beep();

                Console.WriteLine("ERROR RSOD: DEVICE NOT COMPATIBLE.");
                Console.WriteLine("QEMU IS NOT COMPATIBLE WITH");
                Console.WriteLine("ECHOS TRY AGAIN WITH VMWARE");

                Console.WriteLine("");

                Thread.Sleep(4000);
                Console.Clear();

            }

        }

        else
        {

            // Do nothing and continue.

        }


    }

}





