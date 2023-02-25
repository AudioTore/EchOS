package EchOS;


import java.util.Scanner;
import java.io.*;

public class Cmdman {
	
		static Scanner scan = new Scanner(System.in);
	
		public static void clear() {
			System.out.print("\033[H\033[2J");  // "\033[H\033[2J" Clears the screen.
			System.out.flush();
			System.out.println("===============================================================================");
			System.out.println("||###########################################################################||");
			System.out.println("||                                 EchOS 1.6                                 ||");
			System.out.println("||###########################################################################||");
			System.out.println("===============================================================================");
		}
		
		public static void help() {
			    System.out.println("Note: Every command ends with a '();' ");
			    System.out.println("================================================================================");
			    System.out.println("Command List: ");
			    System.out.println("Disk.ListDir(); - List all the files in the 0:\\ directory");
			    System.out.println("File.create [file] - Creates a File. Takes two or more arguments.");
			    System.out.println("File.delete [file] - Deletes a File. Takes two or more arguments.");
			    System.out.println("File.read [file] - Reads and prints the contents of a text file. Takes two or more arguments.");
			    System.out.println("Directory.create [directory] - Creates a directory. Takes two or more arguments.");
			    System.out.println("Directory.delete [directory] - Deletes a directory. Takes two or more arguments.");
			    System.out.println("Open.TextPad(); - Allows you to type text and save it.");
			    System.out.println("Open.Tour(); - Take a tour and teaches you about how to use EchOS!");
			    System.out.println("System.Shutdown(); - Shuts the OS Down. (Please use this to properly shutdown the System.)");
			    System.out.println("System.Reboot(); - Reboots the OS.");
			    System.out.println("Open.Calculator(); - Opens the systems calculator.");
			    System.out.println("BackgroundColor.Change(); - Changes the terminals background color.");
			    System.out.println("System.About(); - Tells more information about the OS");
			    System.out.println("CMD.Clear(); - Clears the console.");
			    System.out.println("Execute.Ticktacktoe();");
			    System.out.println("Orlov [file] - Use the orlov language to build apps. mov ah, \"Hello!\"");
			    System.out.println("echo [string] - Echos anything back to you.");
			    System.out.println("================================================================================");
		}
		
		public static void About() {
			System.out.println("[EchOS] 1.6");
			System.out.println("Developer: audiotore341");
			System.out.println("Languages: Java");
		}
		
		public static void Shutdown() throws InterruptedException {
			while (true) {
				String shutdown_command = "shutdown -h now";
				
				File checkexists = new File("bin/01000101"); 
				
				/* Later check if there's a file called "01000101" in the bin 
				 * If there is actually shutdown the computer itself. Otherwise exit out of the JVM.
				 * If the user downloaded the bootable version it comes with the file automatically.
				 * */
				
				System.out.println("You are about to shutdown this System?");
				System.out.print("[YES/NO]: ");
				String shutdown = scan.nextLine();
				
				if (shutdown.equals("YES")) {
					if (checkexists.exists()) {
						try {
							Process process = Runtime.getRuntime().exec(shutdown_command);
							System.out.println("Shutting down..");
							Thread.sleep(5000);
						}
						catch (Exception err) {
							System.out.println("[ACPI]: Failed to shutdown..");
						}
					}
					else if (!checkexists.exists())
					{
						try {
							System.out.println("Shutting down...");
							System.exit(0);
						}
						catch (Exception err)
						{
							System.out.println("[ACPI] Failed to shutdown..");
						}
					}
				}
				
				else if (shutdown.equals("NO")) {
					System.out.println("Going back..");
					break;
					// Return back...
				}
				
				else
				{
					System.out.println("Not a vaild command.");
				}
			}
		}
		
		public static void Reboot() throws IOException, InterruptedException {
			while (true) {
				File checkexists = new File("bin/01000101"); 
				
				/* Later check if there's a file called "01000101" in the bin 
				 * If there is actually reboot the computer itself. Otherwise exit out of the JVM.
				 * If the user downloaded the bootable version it comes with the file automatically.
				 * */
				
				System.out.println("You are about to shutdown this System?");
				System.out.print("[YES/NO]: ");
				String shutdown = scan.nextLine();
				
				String reboot_command = "reboot";
				if (shutdown.equals("YES")) {
					if (checkexists.exists()) {
						Process process = Runtime.getRuntime().exec(reboot_command);
						System.out.println("Rebooting...");
						Thread.sleep(5000);
					}
					else if (!checkexists.exists())
					{
						System.out.print("\033[H\033[2J");  // "\033[H\033[2J" Clears the screen.
						System.out.flush();
						System.out.println("Rebooting...");
						try {
							Thread.sleep(2000);
							Kernel.main(null);
						}
						catch (Exception err) {
							System.out.println("[ACPI]: Failed to reboot...");
						}
					}
				}
				else if (shutdown.equals("NO")) {
					System.out.println("Going back..");
					break;
				}
				else
				{
					System.out.println("Not a vaild command.");
				}
			}
		}
		
		public static void Calculate() {
	        double num1 = 0;
	        double num2 = 0;
	        double result = 0;
	        while (true) {
	            System.out.println("*** WARNING: Strings will not work. ***");
	            System.out.print("Enter a number: ");
	            //  [
	            try {
	                num1 = Double.parseDouble(System.console().readLine());
	            }
	            catch (Exception e) {
	                System.out.println(e.getMessage());
	            }
	            
	            //  ]
	            System.out.print("Enter another number: ");
	            //  [
	            try {
	                num2 = Double.parseDouble(System.console().readLine());
	            }
	            catch (Exception e) {
	                System.out.println(e.getMessage());
	            }
	            
	            //  ]
	            System.out.println(">> 1. Addition.");
	            System.out.println(">> 2. Subtraction.");
	            System.out.println(">> 3. Multiplication. ");
	            System.out.println(">> 4. Division.");
	            System.out.print(">>>: ");
	            String operands = System.console().readLine();
	            
	            if ((operands.equals("1"))) {
	                result = (num1 + num2);
	                System.out.println(("answer: " + result));
	                break;
	            }
	            else if ((operands.equals("2"))) {
	                result = (num1 - num2);
	                System.out.println(("answer: " + result));
	                break;
	            }
	            else if ((operands.equals("3"))) {
	                result = (num1 * num2);
	                System.out.println(("answer: " + result));
	                break;
	            }
	            else if ((operands.equals("4"))) {
	                result = (num1 / num2);
	                System.out.println(("answer: " + result));
	                break;
	            }
	            else {
	                System.out.println("Not a vaild command..");
	            }
	        }
	    }	
}