using System;
using System.Collections.Generic;
using System.Text;
using Sys = Cosmos.System;
using System.Threading;
// All the functions to commands.
namespace EchOS_Dev
{

	
	public class Cmdman
	{

		public static int num1;
		public static int num2;

		public static void boot()
		{
			Console.Clear(); // Clear all the 'pre' boot messages.
							 // Animation frames for the 3D cube.


			Console.WriteLine(@"                    #
                     ######
                 ####   #  ##
              ####      #   ##
           ####         #     ##
        ###             #      ##
      ##                #       ###
      ###               #         ##
      # ##              #           ##
      #   ##            #          ###
      #    ##           #       ###  #
      #      ##         #    ###     #
      #       ##        #####        #
      #         ##    ###            #
      #          #####  #            #
      #            #    #            #
      #            #    #            #
      #            #    #            #
      #            #    #            #
      #            #    #            #
      #            #    #            #
      #            #  #####          #
      #            ###    ##         #
      #        #####        ##       #
      #     ###    #         ##      #
      #  ###       #           ##    #
      ###          #            ##   #
      ##           #              ## #
        ##         #               ###
         ###       #                ##
           ##      #             ###
            ##     #         ####
              ##   #      ####
               ##  #   ####
                 ######
                   #");
			Console.Clear();
			Console.WriteLine(@"  #
              ######
            ## #    ###
           ##  #       ###
         ##    #          ####
        ##     #              ####
      ##       #                 ##
     ##        #                ###
    #          #               ## #
   ##          #             ##   #
   # ####      #            ##    #
   #     ####  #           #      #
   #        ####         ##       #
   #           #####   ##         #
   #           #    ####          #
   #           #      #           #
   #           #      #           #
   #           #      #           #
   #           #      #           #
   #           #      #           #
   #           #      #           #
   #          ####    #           #
   #         ##   #####           #
   #       ##         ####        #
   #      #           #  ####     #
   #    ##            #      #### #
   #   ##             #          ##
   # ##               #          #
   ###                #        ##
   ##                 #       ##
    ####              #     ##
        ####          #    ##
            ###       #  ##
               ###    # ##
                  ######
                      #");
			Console.Clear();
			Console.WriteLine(@"
              ######
            ## #    ###
           ##  #       ###
         ##    #          ####
        ##     #              ####
      ##       #                 ##
     ##        #                ###
    #          #               ## #
   ##          #             ##   #
   # ####      #            ##    #
   #     ####  #           #      #
   #        ####         ##       #
   #           #####   ##         #
   #           #    ####          #
   #           #      #           #
   #           #      #           #
   #           #      #           #
   #           #      #           #
   #           #      #           #
   #           #      #           #
   #          ####    #           #
   #         ##   #####           #
   #       ##         ####        #
   #      #           #  ####     #
   #    ##            #      #### #
   #   ##             #          ##
   # ##               #          #
   ###                #        ##
   ##                 #       ##
    ####              #     ##
        ####          #    ##
            ###       #  ##
               ###    # ##
                  ######
                      #");
			Console.Clear();
			Console.Write(@"    #
          ##############
          #             ##########
         ##                     ##
         ##                     ##
        ###                    ###
        # #                    # #
        # #                    # #
       ## #                   ## #
       #  #                   #  #
      ##  #                   #  #
      ##############         #   #
      #   #         ##########   #
      #   #                  #   #
      #   #                  #   #
      #   #                  #   #
      #   #                  #   #
      #   #                  #   #
      #   #                  #   #
      #   #                  #   #
      #   #                  #   #
      #   ##########         #   #
      #   #         ##############
      #  #                   #  ##
      #  #                   #  #
      # ##                   # ##
      # #                    # #
      # #                    # #
      ###                    ###
      ##                     ##
      ##                     ##
      ##########             #
                ##############
                             #");

			// Give the OS A little more time to boot. (Resson for the Thread Sleeps.)
			Console.Clear();
			Thread.Sleep(1000);
			Console.WriteLine("EchOS");
			Thread.Sleep(2000);
			Console.Clear();
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

			Console.WriteLine("Welcome!");
			Console.WriteLine("#########################################");
			Console.WriteLine("               EchOS 2.0");
			Console.WriteLine("#########################################");
			Console.WriteLine("Type 'Help;' to get a list of commands.");

		}


		public static void help()
		{
			Console.WriteLine("NOTE: Every command ends with a ';' ");

			Console.WriteLine("================================================================================");
			Console.WriteLine("Command List: ");
			Console.WriteLine("System_Shutdown, System_Reboot, Clear_Src, BackgroundColor_Change");
			Console.WriteLine("Calculator, About");
			Console.WriteLine("================================================================================");
		}




		// Reboot and shutdown commands.
		public static void Shutdown()
		{
			Cosmos.System.Power.Shutdown();
		}


		public static void Reboot()
		{
			Cosmos.System.Power.Reboot();
		}

		/* Sadly These reboot and shutdown commands
		 * don't work for every virtual machine platform like Vbox 
		 * (Virtualbox) Which is why you should always use vmware */




		public static void Calculator()
		{
			double num1 = 0;
			double num2 = 0;
			double result = 0;

			while (true)
			{
				Console.WriteLine("You are about to open Calculator. Continue?");
				Console.Write("[YES/NO]: ");
				string cal_open = Console.ReadLine();
				if (cal_open == "YES")
				{
					Console.WriteLine("***WARNING: Strings will not work. and will give you an error and shutdown***");
					Console.Write("Enter a number: ");
					num1 = Convert.ToDouble(Console.ReadLine());

					Console.Write("Enter another number: ");
					num2 = Convert.ToDouble(Console.ReadLine());

					Console.WriteLine("Operands: + - / *");
					string operands = Console.ReadLine();
					if (operands == "+")
					{
						result = num1 + num2;
						Console.WriteLine("answer" + result);
						break;
					}
					else if (operands == "-")
					{
						result = num1 - num2;
						Console.WriteLine("answer" + result);
						break;
					}
					else if (operands == "/")
					{
						result = num1 / num2;
						Console.WriteLine("answer" + result);
						break;
					}
					else if (operands == "*")
					{
						result = num1 * num2;
						Console.WriteLine("answer" + result);
						break;
					}
					else
					{
						Console.WriteLine("'" + cal_open + "' Not a vaild option. Choose '+', '-', '/', '*'");
					}
				}
				else if (cal_open == "NO")
				{
					break; // Break and do nothing but return back to the 'run' function of the kernel.
				}
				else
				{
					Console.WriteLine("'" + cal_open + "' Not a vaild option. Choose 'YES', 'NO'");
				}

			}
					
        }

		public static void About()
		{
			Console.WriteLine("EchOS 2.0");
		}



		public static void Clear_Src()
		{
			Console.Clear();
			Console.WriteLine("#########################################");
			Console.WriteLine("               EchOS 2.0");
			Console.WriteLine("#########################################");
			Console.WriteLine("Type 'help;' to get a list of commands.");
		}






		public static void BackgroundColor_Change()
		{						
				Console.WriteLine("Are you sure you want to change your terminal Color?");
				Console.WriteLine("[You can always change it to black.]");
				Console.WriteLine("Yes: will change the color of terminal to blue.");
				Console.WriteLine("NO: Will keep the current terminal color.");
				Console.WriteLine("BLACK: Will change the terminal color back to black.");
				Console.WriteLine(" "); // Spaces
				Console.WriteLine(" "); // Spaces

				Console.WriteLine("NOTE: Color resets to default once the System OS reboots, shutdowns.");
				while (true)
				{
					Console.Write("[YES/NO/BLACK]: ");
					string input_answer = Console.ReadLine();

					if (input_answer == "YES")
					{
						Console.BackgroundColor = ConsoleColor.Blue; // First, Foreground color Second, Text color.
					}
					else if (input_answer == "NO")
					{					
						break; // Break out of while loop and return to the "Run" function in the kernel.
					}
					else if (input_answer == "BLACK")
					{
						Console.BackgroundColor = ConsoleColor.Black;
					}
					else
					{
						Console.WriteLine("'" + input_answer + "' Not a vaild option. Choose 'YES', 'NO', 'BLACK'");
					}
				}				           
		}
	}

}

