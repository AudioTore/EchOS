using System;
using System.Collections.Generic;
using System.Text;
using Sys = Cosmos.System;
using System.Threading;
namespace EchOS_Dev
{
    public class Kernel : Sys.Kernel
    {
        Cmdman cmd = new Cmdman();


        protected override void BeforeRun()
        {
            Console.Clear(); // Clear all the 'pre' boot messages.

            // Give the OS A little more time to boot. (Resson for the Thread Sleeps.)
            Console.WriteLine("Booting.");
            Thread.Sleep(1000);
            Console.WriteLine("Booting..");
            Thread.Sleep(1000);
            Console.WriteLine("Booting...");
            Thread.Sleep(1000);
            Console.Clear();
            Console.WriteLine("EchOS Has successfully booted!");
            Thread.Sleep(2000);
            Console.Clear();

            Console.WriteLine("#########################################");
            Console.WriteLine("               EchOS 1.0");
            Console.WriteLine("#########################################");
            Console.WriteLine("Type 'help;' to get a list of commands.");
        }

        protected override void Run() // While loop by default.
        {
            Console.Write("[0]>: ");
            string input_cmd = Console.ReadLine();
            if (input_cmd == "help;")
            {
                Cmdman.help();
            }
            else if (input_cmd == "System_Shutdown;")
            {
                Cmdman.Shutdown();
            }

            else if (input_cmd == "System_Reboot;")
            {
                Cmdman.Reboot();
            }
            else if (input_cmd == "Calculator;")
            {
                Cmdman.Calculator();
            }
            else if (input_cmd == "About;")
            {
                Cmdman.About();
            }
            else if (input_cmd == "Clear_Src;")
            {
                Cmdman.Clear_Src();
            }
            else // If the user enters an invaild command.
            {
                Console.WriteLine("'" + input_cmd + "' Is not a known command. Type 'help' to get a list of commands.");
                Console.WriteLine("A SemiColumn may be missing.");
            }


            



        }


    }
}
