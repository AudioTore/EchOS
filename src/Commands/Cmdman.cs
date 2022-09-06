
using System;
using System.Threading;

/* Where all the commands and their functionality go. You can make a command by making a function in this Class.
 * Then call the function from this class using the kernel class. I think you can figure it out if your a 
 * developer. If not I highly recommend you watch a couple of tutorials C# to get the basics of it. */

public class Cmdman
{

    public static void Help()
    {

        Console.WriteLine("Note: Every command ends with a '();' ");

        Console.WriteLine("================================================================================");
        Console.WriteLine("Command List: ");
        Console.WriteLine("System.Shutdown(); - Shuts the OS Down. (Please use this)");
        Console.WriteLine("System.Reboot(); - Reboots the OS.");
        Console.WriteLine("Calculator(); - Opens the systems calculator.");
        Console.WriteLine("BackgroundColor.Change(); - Changes the terminals background color.");
        Console.WriteLine("System.About(); - Tells more information about the OS");
        Console.WriteLine("Console.Clear(); - Clears the console.");
        Console.WriteLine("================================================================================");

    }




    public static void Shutdown()
    {

        while (true)
        {

            Console.WriteLine("You are about to shutdown this System?");
            Console.Write("[YES/NO]: ");
            string shutdown = Console.ReadLine();


            if (shutdown == "YES")
            {

                try
                {

                    Cosmos.System.Power.Shutdown();

                }
                catch
                {

                    Console.WriteLine("Whoops! Shutdown doesn't seem to work. Try force shut down your computer by using the powerbutton.");
                    Console.WriteLine("Or if your on a virtualmachine shutdown using the power tab!");
                    Console.WriteLine("Note: Virtualbox doesn't work with this so try using vmware if your on a virtual machine.");
                    Thread.Sleep(5000);
                    break;

                }

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

                try
                {

                    Cosmos.System.Power.Reboot();

                }

                catch
                {

                    Console.Clear();
                    Console.Beep();
                    Console.WriteLine("Whoops! Shutdown doesn't seem to work. Try force shut down your computer by using the powerbutton.");
                    Console.WriteLine("Or if your on a virtualmachine shutdown using the power tab!");
                    Console.WriteLine("Note: Virtualbox doesn't work with this so try using vmware if your on a virtual machine.");
                    Thread.Sleep(5000);
                    break;

                }

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




    public static void Calculator()
    {
        while (true)
        {
            Console.WriteLine("You are about to open Calculator. Continue?");
            Console.Write("[YES/NO]: ");
            string cal_open = Console.ReadLine();

            if (cal_open == "YES")
            {

                Calculate();
                break; // Break out of our previous loop.
            
            }

            else if (cal_open == "NO")
            {

                Console.WriteLine("Going back..");
                break; // Break and do nothing but return back to the 'run' function of the kernel.
            
            }
            else
            {

                Console.WriteLine("Not a vaild command..");
            
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
            try
            {

                Console.Write("Enter a number: ");
                num1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter another number: ");
                num2 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine(">> 1. Addition.");
                Console.WriteLine(">> 2. Subtraction.");
                Console.WriteLine(">> 3. Multiplication. ");
                Console.WriteLine(">> 4. Division.");
                Console.Write("[]: ");
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

            /* If an unexpected error occurs. 
             * Normally meaning that the user inputted a string instead
             * Of an int. */
            catch
            {

                Console.Clear();
                Console.Beep();
                Console.WriteLine("ERROR: Calculator has failed to provide an answer.");
                Console.WriteLine("Strings or invaild inputs not allowed.");
                Console.WriteLine("If you still get this error report an issue on our github page: github.com/AudioTore/EchOS");
                Thread.Sleep(2000);

            }

        }

    }

    public static void About()
    {

        Console.WriteLine("System OS: EchOS");
        Console.WriteLine("Version: 3.0");
        Console.WriteLine("Release date: [9/6/2022]");
        Console.WriteLine("Language written in: C#");

    }



    public static void Clear_Src()
    {

        Console.Clear();
        Console.WriteLine("===========================================");
        Console.WriteLine("||########################################||");
        Console.WriteLine("||               EchOS 3.0                ||");
        Console.WriteLine("||########################################||");
        Console.WriteLine("===========================================");
        Console.WriteLine("Type 'Help();' to get a list of commands.");

    }






    public static void BackgroundColor_Change()
    {

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
                break;

            }
            else
            {

                Console.Beep();
                Console.WriteLine("Invaild command...");

            }

        }

    }

    public static void color_change()
    {

        while (true)
        {

            Console.WriteLine("Pick a background color.");
            Console.WriteLine("1. Black. (default)");
            Console.WriteLine("2. Blue.");
            Console.WriteLine("3. Yellow.");
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

                Console.BackgroundColor = ConsoleColor.Yellow;

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

}
   




