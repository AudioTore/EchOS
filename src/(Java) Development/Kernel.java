// Pretty much the base of the system

import java.util.Scanner;

public class Kernel {

	// System objects.
	public static Scanner scan = new Scanner(System.in);
	
	// For commands
	public static Cmdman cmdman = new Cmdman();
	
	public static void main(String[] args) {
		BeforeRun();
	}
	 public static void BeforeRun() {
		// Give the user more time to load.
		System.out.println(""
				+ "       				######\r\n"
				+ "                 ####   #  ##\r\n"
				+ "              ####      #   ##\r\n"
				+ "           ####         #     ##\r\n"
				+ "        ###             #      ##\r\n"
				+ "      ##                #       ###\r\n"
				+ "      ###               #         ##\r\n"
				+ "      # ##              #           ##\r\n"
				+ "      #   ##            #          ###\r\n"
				+ "      #    ##           #       ###  #\r\n"
				+ "      #      ##         #    ###     #\r\n"
				+ "      #       ##        #####        #\r\n"
				+ "      #         ##    ###            #\r\n"
				+ "      #          #####  #            #\r\n"
				+ "      #            #    #            #\r\n"
				+ "      #            #    #            #\r\n"
				+ "      #            #    #            #\r\n"
				+ "      #            #    #            #\r\n"
				+ "      #            #    #            #\r\n"
				+ "      #            #    #            #\r\n"
				+ "      #            #  #####          #\r\n"
				+ "      #            ###    ##         #\r\n"
				+ "      #        #####        ##       #\r\n"
				+ "      #     ###    #         ##      #\r\n"
				+ "      #  ###       #           ##    #\r\n"
				+ "      ###          #            ##   #\r\n"
				+ "      ##           #              ## #\r\n"
				+ "        ##         #               ###\r\n"
				+ "         ###       #                ##\r\n"
				+ "           ##      #             ###\r\n"
				+ "            ##     #         ####\r\n"
				+ "              ##   #      ####\r\n"
				+ "               ##  #   ####\r\n"
				+ "                 ######");
		try {
			Thread.sleep(1000);
		}
		catch(InterruptedException e)
		{
			// Do nothing.
		}
		
		System.out.println("    ######\r\n"
				+ "            ## #    ###\r\n"
				+ "           ##  #       ###\r\n"
				+ "         ##    #          ####\r\n"
				+ "        ##     #              ####\r\n"
				+ "      ##       #                 ##\r\n"
				+ "     ##        #                ###\r\n"
				+ "    #          #               ## #\r\n"
				+ "   ##          #             ##   #\r\n"
				+ "   # ####      #            ##    #\r\n"
				+ "   #     ####  #           #      #\r\n"
				+ "   #        ####         ##       #\r\n"
				+ "   #           #####   ##         #\r\n"
				+ "   #           #    ####          #\r\n"
				+ "   #           #      #           #\r\n"
				+ "   #           #      #           #\r\n"
				+ "   #           #      #           #\r\n"
				+ "   #           #      #           #\r\n"
				+ "   #           #      #           #\r\n"
				+ "   #           #      #           #\r\n"
				+ "   #          ####    #           #\r\n"
				+ "   #         ##   #####           #\r\n"
				+ "   #       ##         ####        #\r\n"
				+ "   #      #           #  ####     #\r\n"
				+ "   #    ##            #      #### #\r\n"
				+ "   #   ##             #          ##\r\n"
				+ "   # ##               #          #\r\n"
				+ "   ###                #        ##\r\n"
				+ "   ##                 #       ##\r\n"
				+ "    ####              #     ##\r\n"
				+ "        ####          #    ##\r\n"
				+ "            ###       #  ##\r\n"
				+ "               ###    # ##\r\n"
				+ "                  ######");
		try {
			Thread.sleep(1000);
		}
		catch(InterruptedException e)
		{
			// Do nothing.
		}
		
		System.out.println("    ######\r\n"
				+ "            ## #    ###\r\n"
				+ "           ##  #       ###\r\n"
				+ "         ##    #          ####\r\n"
				+ "        ##     #              ####\r\n"
				+ "      ##       #                 ##\r\n"
				+ "     ##        #                ###\r\n"
				+ "    #          #               ## #\r\n"
				+ "   ##          #             ##   #\r\n"
				+ "   # ####      #            ##    #\r\n"
				+ "   #     ####  #           #      #\r\n"
				+ "   #        ####         ##       #\r\n"
				+ "   #           #####   ##         #\r\n"
				+ "   #           #    ####          #\r\n"
				+ "   #           #      #           #\r\n"
				+ "   #           #      #           #\r\n"
				+ "   #           #      #           #\r\n"
				+ "   #           #      #           #\r\n"
				+ "   #           #      #           #\r\n"
				+ "   #           #      #           #\r\n"
				+ "   #          ####    #           #\r\n"
				+ "   #         ##   #####           #\r\n"
				+ "   #       ##         ####        #\r\n"
				+ "   #      #           #  ####     #\r\n"
				+ "   #    ##            #      #### #\r\n"
				+ "   #   ##             #          ##\r\n"
				+ "   # ##               #          #\r\n"
				+ "   ###                #        ##\r\n"
				+ "   ##                 #       ##\r\n"
				+ "    ####              #     ##\r\n"
				+ "        ####          #    ##\r\n"
				+ "            ###       #  ##\r\n"
				+ "               ###    # ##\r\n"
				+ "                  ######");
		try {
			Thread.sleep(1000);
		}
		catch(InterruptedException e)
		{
			// Do nothing.
		}
		
		System.out.println("   ##############\r\n"
				+ "          #             ##########\r\n"
				+ "         ##                     ##\r\n"
				+ "         ##                     ##\r\n"
				+ "        ###                    ###\r\n"
				+ "        # #                    # #\r\n"
				+ "        # #                    # #\r\n"
				+ "       ## #                   ## #\r\n"
				+ "       #  #                   #  #\r\n"
				+ "      ##  #                   #  #\r\n"
				+ "      ##############         #   #\r\n"
				+ "      #   #         ##########   #\r\n"
				+ "      #   #                  #   #\r\n"
				+ "      #   #                  #   #\r\n"
				+ "      #   #                  #   #\r\n"
				+ "      #   #                  #   #\r\n"
				+ "      #   #                  #   #\r\n"
				+ "      #   #                  #   #\r\n"
				+ "      #   #                  #   #\r\n"
				+ "      #   #                  #   #\r\n"
				+ "      #   ##########         #   #\r\n"
				+ "      #   #         ##############\r\n"
				+ "      #  #                   #  ##\r\n"
				+ "      #  #                   #  #\r\n"
				+ "      # ##                   # ##\r\n"
				+ "      # #                    # #\r\n"
				+ "      # #                    # #\r\n"
				+ "      ###                    ###\r\n"
				+ "      ##                     ##\r\n"
				+ "      ##                     ##\r\n"
				+ "      ##########             #\r\n"
				+ "                ##############\r\n"
				+ "                             #\");");
				try {
					Thread.sleep(1000);
				}
				catch(InterruptedException e)
				{
					// Do nothing.
				}
				
				// Console.Clear();
				System.out.println("EchOS 3.0");
				try {
					Thread.sleep(1000);
				}
				catch(InterruptedException e)
				{
					// Do nothing.
				}
				// Console.Clear();
				// Console.Beep();
				System.out.println("EchOS Has successfully booted!");
				try {
					Thread.sleep(1000);
				}
				catch(InterruptedException e)
				{
					// Do nothing.
				}
				// Console.Clear();
				 System.out.println("Welcome!");
				 System.out.println("===========================================");
				 System.out.println("|#########################################|");
				 System.out.println("|               EchOS 3.0				   |");
				 System.out.println("|#########################################|");
				 System.out.println("===========================================");
				 System.out.println("Type 'Help();' to get a list of commands.");
				 Run();
	
	}
	 public static void Run() {
		 while(true) {
			 System.out.print("[0]: ");
	         String input_cmd = scan.nextLine();
	         switch(input_cmd) {
	         	case "Help();":
	         		cmdman.Help();
	         		break;
	         		
	         	case "System.Shutdown();":
	         		break;
	         		
	         	case "System.Reboot();":
	         		break;
	         		
	         	case "Clear.Src();":
	         		break;
	         		
	         	case "BackgroundColor.Change();":
	         		break;
	         		
	         	case "Calculator();":
	         		break;
	         		
	         	case "About();":
	         		break;
	         		
	         	default:
	         		// Console.Beep();
	         		System.out.println("'" + input_cmd + "' Is not a vaild command.");
	         		System.out.println("NOTE: Every command starts with a Capital and ends with a '();' ");
	         		break;
	         }
		 }
		 
	 }
	
	
}
		
		
