/* EchOS 2022 This is the base of the operating system
 * and where most of the Operating system spends its time.
 * Note that you can do anything with this system. Republish it with or without credit,
 * modify it, Make it goofy ahh, Go crazy bro!
 * 
 * Also if you are planning to modify the code MAKE SURE that you DO have Cosmos AND Vmware Installed. Otherwise there will be build errors when compiling this.
 */

import java.util.*;


public class Kernel
{
	private Cmdman cmd = new Cmdman(); // Command manager.

	public boolean flag;
	
	
	/* When converted over to C# code replace this variable name with this:
	 *  protected override void BeforeRun()
	 */
	
	public static void BeforeRun() // 
	{
		// Console.Clear(); 
		// Clear all the 'pre' boot messages.
		// Animation frames for the 3D cube.


		System.out.println("                    #" + "\r\n" + 
"                     ######" + "\r\n" + 
"                 ####   #  ##" + "\r\n" + 
"              ####      #   ##" + "\r\n" + 
"           ####         #     ##" + "\r\n" + 
"        ###             #      ##" + "\r\n" + 
"      ##                #       ###" + "\r\n" + 
"      ###               #         ##" + "\r\n" + 
"      # ##              #           ##" + "\r\n" + 
"      #   ##            #          ###" + "\r\n" + 
"      #    ##           #       ###  #" + "\r\n" + 
"      #      ##         #    ###     #" + "\r\n" + 
"      #       ##        #####        #" + "\r\n" + 
"      #         ##    ###            #" + "\r\n" + 
"      #          #####  #            #" + "\r\n" + 
"      #            #    #            #" + "\r\n" + 
"      #            #    #            #" + "\r\n" + 
"      #            #    #            #" + "\r\n" + 
"      #            #    #            #" + "\r\n" + 
"      #            #    #            #" + "\r\n" + 
"      #            #    #            #" + "\r\n" + 
"      #            #  #####          #" + "\r\n" + 
"      #            ###    ##         #" + "\r\n" + 
"      #        #####        ##       #" + "\r\n" + 
"      #     ###    #         ##      #" + "\r\n" + 
"      #  ###       #           ##    #" + "\r\n" + 
"      ###          #            ##   #" + "\r\n" + 
"      ##           #              ## #" + "\r\n" + 
"        ##         #               ###" + "\r\n" + 
"         ###       #                ##" + "\r\n" + 
"           ##      #             ###" + "\r\n" + 
"            ##     #         ####" + "\r\n" + 
"              ##   #      ####" + "\r\n" + 
"               ##  #   ####" + "\r\n" + 
"                 ######" + "\r\n" + 
"                   #");
		// Console.Clear(); (Uncomment when converted)
		System.out.println("  #" + "\r\n" + 
"              ######" + "\r\n" + 
"            ## #    ###" + "\r\n" + 
"           ##  #       ###" + "\r\n" + 
"         ##    #          ####" + "\r\n" + 
"        ##     #              ####" + "\r\n" + 
"      ##       #                 ##" + "\r\n" + 
"     ##        #                ###" + "\r\n" + 
"    #          #               ## #" + "\r\n" + 
"   ##          #             ##   #" + "\r\n" + 
"   # ####      #            ##    #" + "\r\n" + 
"   #     ####  #           #      #" + "\r\n" + 
"   #        ####         ##       #" + "\r\n" + 
"   #           #####   ##         #" + "\r\n" + 
"   #           #    ####          #" + "\r\n" + 
"   #           #      #           #" + "\r\n" + 
"   #           #      #           #" + "\r\n" + 
"   #           #      #           #" + "\r\n" + 
"   #           #      #           #" + "\r\n" + 
"   #           #      #           #" + "\r\n" + 
"   #           #      #           #" + "\r\n" + 
"   #          ####    #           #" + "\r\n" + 
"   #         ##   #####           #" + "\r\n" + 
"   #       ##         ####        #" + "\r\n" + 
"   #      #           #  ####     #" + "\r\n" + 
"   #    ##            #      #### #" + "\r\n" + 
"   #   ##             #          ##" + "\r\n" + 
"   # ##               #          #" + "\r\n" + 
"   ###                #        ##" + "\r\n" + 
"   ##                 #       ##" + "\r\n" + 
"    ####              #     ##" + "\r\n" + 
"        ####          #    ##" + "\r\n" + 
"            ###       #  ##" + "\r\n" + 
"               ###    # ##" + "\r\n" + 
"                  ######" + "\r\n" + 
"                      #");
		// Console.Clear(); (Uncomment when converted)
		System.out.println("" + "\r\n" + 
"              ######" + "\r\n" + 
"            ## #    ###" + "\r\n" + 
"           ##  #       ###" + "\r\n" + 
"         ##    #          ####" + "\r\n" + 
"        ##     #              ####" + "\r\n" + 
"      ##       #                 ##" + "\r\n" + 
"     ##        #                ###" + "\r\n" + 
"    #          #               ## #" + "\r\n" + 
"   ##          #             ##   #" + "\r\n" + 
"   # ####      #            ##    #" + "\r\n" + 
"   #     ####  #           #      #" + "\r\n" + 
"   #        ####         ##       #" + "\r\n" + 
"   #           #####   ##         #" + "\r\n" + 
"   #           #    ####          #" + "\r\n" + 
"   #           #      #           #" + "\r\n" + 
"   #           #      #           #" + "\r\n" + 
"   #           #      #           #" + "\r\n" + 
"   #           #      #           #" + "\r\n" + 
"   #           #      #           #" + "\r\n" + 
"   #           #      #           #" + "\r\n" + 
"   #          ####    #           #" + "\r\n" + 
"   #         ##   #####           #" + "\r\n" + 
"   #       ##         ####        #" + "\r\n" + 
"   #      #           #  ####     #" + "\r\n" + 
"   #    ##            #      #### #" + "\r\n" + 
"   #   ##             #          ##" + "\r\n" + 
"   # ##               #          #" + "\r\n" + 
"   ###                #        ##" + "\r\n" + 
"   ##                 #       ##" + "\r\n" + 
"    ####              #     ##" + "\r\n" + 
"        ####          #    ##" + "\r\n" + 
"            ###       #  ##" + "\r\n" + 
"               ###    # ##" + "\r\n" + 
"                  ######" + "\r\n" + 
"                      #");
		// Console.Clear();
		System.out.print("    #" + "\r\n" + 
"          ##############" + "\r\n" + 
"          #             ##########" + "\r\n" + 
"         ##                     ##" + "\r\n" + 
"         ##                     ##" + "\r\n" + 
"        ###                    ###" + "\r\n" + 
"        # #                    # #" + "\r\n" + 
"        # #                    # #" + "\r\n" + 
"       ## #                   ## #" + "\r\n" + 
"       #  #                   #  #" + "\r\n" + 
"      ##  #                   #  #" + "\r\n" + 
"      ##############         #   #" + "\r\n" + 
"      #   #         ##########   #" + "\r\n" + 
"      #   #                  #   #" + "\r\n" + 
"      #   #                  #   #" + "\r\n" + 
"      #   #                  #   #" + "\r\n" + 
"      #   #                  #   #" + "\r\n" + 
"      #   #                  #   #" + "\r\n" + 
"      #   #                  #   #" + "\r\n" + 
"      #   #                  #   #" + "\r\n" + 
"      #   #                  #   #" + "\r\n" + 
"      #   ##########         #   #" + "\r\n" + 
"      #   #         ##############" + "\r\n" + 
"      #  #                   #  ##" + "\r\n" + 
"      #  #                   #  #" + "\r\n" + 
"      # ##                   # ##" + "\r\n" + 
"      # #                    # #" + "\r\n" + 
"      # #                    # #" + "\r\n" + 
"      ###                    ###" + "\r\n" + 
"      ##                     ##" + "\r\n" + 
"      ##                     ##" + "\r\n" + 
"      ##########             #" + "\r\n" + 
"                ##############" + "\r\n" + 
"                             #");

		// Give the OS A little more time to boot. (Resson for the Thread Sleeps.)
		// Console.Clear(); (Uncomment when converted)
		// Thread.sleep(2000); (Uncomment when converted)
		System.out.println("EchOS");
		// Thread.sleep(2000); (Uncomment when converted)
		// Console.Clear(); (Uncomment when converted)
		System.out.println("Booting.");
		// Thread.sleep(2000); (Uncomment when converted)
		System.out.println("Booting..");
		// Thread.sleep(2000); (Uncomment when converted)
		System.out.println("Booting...");
		// Thread.sleep(2000); (Uncomment when converted)
		// Console.Clear(); (Uncomment when converted)
		System.out.println("EchOS Has successfully booted!");
		// Thread.sleep(2000); (Uncomment when converted)
		// Console.Clear(); (Uncomment when converted)

		System.out.println("Welcome!");
		System.out.println("#########################################");
		System.out.println("               EchOS 3.0");
		System.out.println("#########################################");
		System.out.println("Type 'Help;' to get a list of commands.");
	}

	/* Replace with protected override void Run() when
	 * converted to C# code.
	 */
	public static void Run() // While loop by default.
	{
		System.out.print("[0]: ");
		String input_cmd = new Scanner(System.in).nextLine();

		switch (input_cmd)
		{
				case "Help;":
					Cmdman.Help();
					break;

				case "System.Shutdown();":
					Cmdman.Shutdown();
					break;

				case "System.Reboot();":
					Cmdman.Reboot();
					break;

				case "Clear.Src();":
					Cmdman.Clear_Src();
					break;

				case "BackgroundColor.Change();":
					Cmdman.BackgroundColor_Change();
					break;

				case "Calculator();":
					Cmdman.Calculator();
					break;

				case "About();":
					Cmdman.About();
					break;


				default:
					System.out.println("'" + input_cmd + "' Is not a vaild command.");
					System.out.println("NOTE: Every command has a semicolumn at the end and a capital at the beginning.");
					break;


		}
			if (input_cmd == null || input_cmd.length() == 0)
			{
				System.out.println("Command cannot be empty or null.");
			}
	}
}
