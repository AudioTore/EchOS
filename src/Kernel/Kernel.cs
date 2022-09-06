using System;
using System.Threading;
using Sys = Cosmos.System;

/* EchOS 2022 This is the base of the operating system
 * and where most of the Operating system spends its time.
 * Note that you can do anything with this system. Republish it with or without credit,
 * modify it, Make it goofy ahh, Go crazy bro!
 * 
 * Also if you are planning to modify the code MAKE SURE that you DO have Cosmos AND Vmware Installed. Otherwise there will be build errors when compiling this.
 * Go figure this out yourself as I will most likely not be providing any documentation on how to do this. If you have some experience in coding editing the source code should be fairly easy.
 * as this used super basic code.
 */

namespace EchOS
{

	public class Kernel : Sys.Kernel
	{

		protected override void BeforeRun()
		{

			Thread.Sleep(2000);
			Console.Clear();

            for (int index = 0; index < 5; index+=1)
            {

                Console.WriteLine("Booting.");
                Thread.Sleep(1000);

				Console.WriteLine("Booting..");
				Thread.Sleep(1000);

                Console.WriteLine("Booting...");
                Thread.Sleep(1000);

                Console.Clear();

            }

            Console.Beep();
			Console.WriteLine("EchOS Successfully booted!");
			Thread.Sleep(2000);	

			Console.Clear();

            Console.WriteLine("===========================================");
            Console.WriteLine("||########################################||");
            Console.WriteLine("||               EchOS 3.0                ||");
            Console.WriteLine("||########################################||");
			Console.WriteLine("===========================================");
			Console.WriteLine("Type 'Help();' to get a list of commands.");


        }

		protected override void Run() // While loop by default.
		{

			while (true)
			{
				
				Console.Write(@"[0:\\]: ");
				string input_cmd = Console.ReadLine();

					switch (input_cmd)
					{

						case "Help();":
							Cmdman.Help();
							break;

						case "System.Shutdown();":
							Cmdman.Shutdown();
							break;

						case "System.Reboot();":
							Cmdman.Reboot();
							break;

						case "Console.Clear();":
							Cmdman.Clear_Src();
							break;

						case "BackgroundColor.Change();":
							Cmdman.BackgroundColor_Change();
							break;

						case "Calculator();":
							Cmdman.Calculator();
							break;

						case "System.About();":
							Cmdman.About();
							break;


						default:
							Console.WriteLine("'" + input_cmd + "' Is not a vaild command.");
							Console.WriteLine("NOTE: Every command has a capital at the beginning and a '();' at the end.");
							break;

					}

					// If input null.
					if (string.ReferenceEquals(input_cmd, null) || input_cmd.Length == 0)
					{

						Console.WriteLine("Command cannot be empty or null.");

					}
				
			}
				
		}
				
	}

}




		






