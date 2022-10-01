using System;
using System.IO;

namespace EchOS
{

    class Tour
    {

        public static void tour()
        {

            string answer; // This will need to be public for the class to work properly.

            Console.Clear();
            Console.WriteLine("Welcome to the EchOS!");
            Console.WriteLine("I will be your guide on how to use this software correctly.");

            // Spaces.
            Console.WriteLine("");

            Console.WriteLine("[Press any key to continue]");
            Console.ReadKey();

            Console.Clear();

            Console.WriteLine("Since EchOS is a dos operating system.");
            Console.WriteLine("Commands are what your gonna use all the time.");

            // Spaces.
            Console.WriteLine("");

            Console.WriteLine("[Press any key to continue]");
            Console.ReadKey();

            Console.Clear();

            Console.WriteLine("One of the most helpfull commands would be \"Help();\" ");
            Console.WriteLine("Go ahead and try it!");

            // Spaces.
            Console.WriteLine("");

            Console.WriteLine("Type \"Help();\" ");

            while (true)
            {

                Console.Write(">>>: ");
                string input = Console.ReadLine();

                if (input == "Help();")
                {

                    Cmdman.Help();
                    break;

                }

                else
                {

                    Console.WriteLine("Invaild command..");

                }

            }

            Console.WriteLine("As you can see it prints out a list of commands");
            Console.WriteLine("As well as what they do.");

            // Spaces.
            Console.WriteLine("");

            Console.WriteLine("If you ever need to figure out what to do the Help command would be your best bet.");

            // Spaces.
            Console.WriteLine("");

            Console.WriteLine("[Press any key to continue]");
            Console.ReadKey();

            Console.Clear();

            Console.WriteLine("You can also calculate numbers using the \"Open.Calculator();\" ");
            Console.WriteLine("The calculator is helpful for calculating numbers. See if you need help with your 4 billion hours of math homework");
            Console.WriteLine("A calculator may just help.");

            // Spaces.
            Console.WriteLine("");
            Console.WriteLine("");

            Console.WriteLine("[Press any key to continue]");
            Console.ReadKey();

            Console.WriteLine("One more command that may come into use is the \"Open.TextPad();\" command.");
            Console.WriteLine("The textpad can allow you create textfiles and enter text into it. It also allows you ");
            
            // Spaces.
            Console.WriteLine("");

            Console.WriteLine("let's try it!");

            // Spaces.
            Console.WriteLine("");

            Console.WriteLine("[Press any key to continue]");
            Console.ReadKey();

            Console.Clear();

            Console.WriteLine("Create a text file. Make sure your input ends with \".txt\" ");

            while (true)
            {

                Console.Write(">>>: ");
                string input = Console.ReadLine();
                answer = input;

                // [
                try
                    {
                        File.Create(@"0:\" + input);
                    }

                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }
                // ]

                Console.Clear();
                break;


            }

            Console.WriteLine("Now enter text into the text file: But there are some limitations. no numbers or any special characters that can crash the OS.");
            Console.WriteLine("Just good old plain text.");
            Console.WriteLine("Type \"exit\" once your done!");

            while (true)
            {

                Console.Write(">>>: ");
                string type_input = Console.ReadLine();

                // [
                try
                    {
                    
                        // This will make sure whenever the user enters a new line of text it skips to the next line.
                        File.AppendAllText(@"0:\" + answer, type_input.ToString() + Environment.NewLine);

                    }

                    catch (Exception e)
                    {

                        Console.WriteLine(e.Message);

                    }
                // ]

                if (type_input == "exit")
                {

                    break;
                
                }
            
            }

            Console.Clear();
            Console.WriteLine(File.ReadAllText(@"0:\" + answer));

            // Spaces.
            Console.WriteLine("");
            Console.WriteLine("");

            Console.WriteLine("As you can see we have a working textpad as well!");
            Console.WriteLine("The textpad can write and print out text files.");

            // Spaces.
            Console.WriteLine("");

            Console.WriteLine("[Press any key to continue]");
            Console.ReadKey();

            Console.WriteLine("EchOS is pretty much just entering commands to do certain functions.");
            Console.WriteLine("Also know that EchOS gets updates every month go check out our github page");
            Console.WriteLine("for bug reporting, feature suggestions, or downloading the latest update. :)");

            // Spaces.
            Console.WriteLine("");

            Console.WriteLine("[Press any key to exit]");
            Console.ReadKey();

            Cmdman.Clear_Src();
            return;

        }
        public static void Main(String[] args)
        {

            while (true)
            {

                Console.WriteLine("You are about to take a Tour. Continue?");
                Console.Write("[YES/NO]: ");
                string input = Console.ReadLine();

                if (input == "YES")
                {

                    tour();
                    break;

                }

                else if (input == "NO")
                {

                    break;

                }

                else
                {

                    Console.WriteLine("Not a vaild command.");

                }

            }
            

        }

    }

}
