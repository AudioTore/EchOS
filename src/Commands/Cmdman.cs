using Sys = Cosmos.System;
using System;
using System.Threading;
using Cosmos.System.FileSystem.VFS;

/* Where all the commands and their functionality go. You can make a command by making a function in this Class.
 * Then call the function from this class using the kernel class. I think you can figure it out if your a 
 * developer. If not I highly recommend you watch a couple of tutorials C# to get the basics of it. 
 * If the functionality of a command is going to take a LOT of code store that code in another class. and call 
 * it from the kernel..
 */

public class Cmdman
{

    Sys.FileSystem.CosmosVFS fs = new Sys.FileSystem.CosmosVFS();

    public static void Help()
    {

        Console.WriteLine("Note: Every command ends with a '();' ");

        Console.WriteLine("================================================================================");
        Console.WriteLine("Command List: ");
        Console.WriteLine("Disk.GetInformation(); - tells you the free space of the drive.");
        Console.WriteLine("Open.TextPad(); - Allows you to type text and save it.");
        Console.WriteLine("Open.Tour - Take a tour and teaches you about how to use EchOS!");
        Console.WriteLine("System.Shutdown(); - Shuts the OS Down. (Please use this)");
        Console.WriteLine("System.Reboot(); - Reboots the OS.");
        Console.WriteLine("Open.Calculator(); - Opens the systems calculator.");
        Console.WriteLine("BackgroundColor.Change(); - Changes the terminals background color.");
        Console.WriteLine("System.About(); - Tells more information about the OS");
        Console.WriteLine("Console.Clear(); - Clears the console.");
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

        Console.WriteLine("System OS: EchOS");
        Console.WriteLine("Version: 1.3");
        Console.WriteLine("Release date: [october 1, 2022]");
        Console.WriteLine("Language written in: C#");
        Console.WriteLine("Developer: audioTore (Github)");

    }



    public static void Clear_Src()
    {

        Console.Clear();
        Console.WriteLine("===========================================");
        Console.WriteLine("||########################################||");
        Console.WriteLine("||               EchOS 1.3                ||");
        Console.WriteLine("||########################################||");
        Console.WriteLine("===========================================");
        Console.WriteLine("Type 'Help();' to get a list of commands.");

    }


    public static void BackgroundColor_Change()
    {

        Console.Clear();

        while (true)
        {

            Console.WriteLine("You are about to open the BackgroundColor_Change. Continue?");
            Console.Write("[YES/NO]: ");
            string input = Console.ReadLine();
            if (input == "YES")
            {
                color_change();
                break;

            }
            else if (input == "NO")
            {

                Console.WriteLine("Going back..");
                Cmdman.Clear_Src();
                break;

            }
            else
            {

                Console.WriteLine("Invaild command...");

            }

        }

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
        // Gets all drive information.
        var available_space = VFSManager.GetAvailableFreeSpace(@"0:\");
        var getfstype = VFSManager.GetFileSystemType(@"0:\");

        Console.WriteLine(@"Disk Drive: 0:\");
        Console.WriteLine("Disk space: " + available_space);
        Console.WriteLine("Disk Type: " + getfstype);

        // Space.
        Console.WriteLine("");

    }

}
   




